// 
// LogWidget.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.IO;
using Gtk;
using MonoDevelop.Core;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Ide;
using System.Text;
using System.Threading;

namespace MonoDevelop.VersionControl.Views
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class LogWidget : Gtk.Bin
	{
		MonoDevelop.VersionControl.Revision[] history;
		public Revision[] History {
			get {
				return history;
			}
			set {
				history = value;
				UpdateHistory ();
			}
		}
		DiffWidget diffWidget;
		ListStore logstore = new ListStore (typeof (Revision));
		ListStore changedpathstore = new ListStore (typeof(Gdk.Pixbuf), typeof (string), typeof(Gdk.Pixbuf), typeof (string), typeof (string), typeof (string));
		VersionControlDocumentInfo info;
		string preselectFile;
		
		
		class RevisionGraphCellRenderer : Gtk.CellRenderer
		{
			public override void GetSize (Widget widget, ref Gdk.Rectangle cell_area, out int x_offset, out int y_offset, out int width, out int height)
			{
				x_offset = y_offset = 0;
				width = 16;
				height = cell_area.Height;
			}
			
			protected override void Render (Gdk.Drawable window, Widget widget, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gdk.Rectangle expose_area, CellRendererState flags)
			{
				using (Cairo.Context cr = Gdk.CairoHelper.Create (window)) {
					cr.Arc (cell_area.X + cell_area.Width / 2, cell_area.Y + cell_area.Height / 2, 5, 0, 2 * Math.PI);
					cr.Color = new Cairo.Color (0, 0, 0);
					cr.Stroke ();
					double h = (cell_area.Height - 10) / 2;
					
					cr.MoveTo (cell_area.X + cell_area.Width / 2, cell_area.Y - 1);
					cr.LineTo (cell_area.X + cell_area.Width / 2, cell_area.Y + h);
					cr.Stroke ();
					
					cr.MoveTo (cell_area.X + cell_area.Width / 2, cell_area.Y + cell_area.Height + 1);
					cr.LineTo (cell_area.X + cell_area.Width / 2, cell_area.Y + cell_area.Height - h);
					cr.Stroke ();
				}
				
			}
			
		}
		
		public LogWidget (VersionControlDocumentInfo info)
		{
			this.Build ();
			this.info = info;
			this.preselectFile = info.Document.FileName;
			CellRendererText messageRenderer = new CellRendererText ();
			messageRenderer.Ellipsize = Pango.EllipsizeMode.End;
			TreeViewColumn colRevMessage = new TreeViewColumn ();
			colRevMessage.Title = GettextCatalog.GetString ("Message");
			colRevMessage.PackStart (new RevisionGraphCellRenderer (), false);
			colRevMessage.PackStart (messageRenderer, true);
			colRevMessage.SetCellDataFunc (messageRenderer, MessageFunc);
			colRevMessage.Sizing = TreeViewColumnSizing.Autosize;
			colRevMessage.MinWidth = 300;
			colRevMessage.Resizable = true;
			treeviewLog.AppendColumn (colRevMessage);

			CellRendererText textRenderer = new CellRendererText ();
			TreeViewColumn colRevDate = new TreeViewColumn (GettextCatalog.GetString ("Date"), textRenderer);
			colRevDate.SetCellDataFunc (textRenderer, DateFunc);
			colRevDate.Resizable = true;
			treeviewLog.AppendColumn (colRevDate);
			
			TreeViewColumn colRevAuthor = new TreeViewColumn (GettextCatalog.GetString ("Author"), textRenderer);
			colRevAuthor.SetCellDataFunc (textRenderer, AuthorFunc);
			colRevAuthor.Resizable = true;
			treeviewLog.AppendColumn (colRevAuthor);

			TreeViewColumn colRevNum = new TreeViewColumn (GettextCatalog.GetString ("Revision"), textRenderer);
			colRevNum.SetCellDataFunc (textRenderer, RevisionFunc);
			colRevNum.Resizable = true;
			treeviewLog.AppendColumn (colRevNum);

			treeviewLog.Model = logstore;
			treeviewLog.Selection.Changed += TreeSelectionChanged;
			
			TreeViewColumn colChangedFile = new TreeViewColumn ();
			var crp = new CellRendererPixbuf ();
			var crt = new CellRendererText ();
			colChangedFile.Title = GettextCatalog.GetString ("File");
			colChangedFile.PackStart (crp, false);
			colChangedFile.PackStart (crt, true);
			colChangedFile.AddAttribute (crp, "pixbuf", 2);
			colChangedFile.AddAttribute (crt, "text", 3);
			treeviewFiles.AppendColumn (colChangedFile);
			
			TreeViewColumn colOperation = new TreeViewColumn ();
			colOperation.Title = GettextCatalog.GetString ("Operation");
			colOperation.PackStart (crp, false);
			colOperation.PackStart (crt, true);
			colOperation.AddAttribute (crp, "pixbuf", 0);
			colOperation.AddAttribute (crt, "text", 1);
			treeviewFiles.AppendColumn (colOperation);
			
			TreeViewColumn colChangedPath = new TreeViewColumn ();
			colChangedPath.Title = GettextCatalog.GetString ("Path");
			colChangedPath.PackStart (crt, true);
			colChangedPath.AddAttribute (crt, "text", 4);
			treeviewFiles.AppendColumn (colChangedPath);
			
			treeviewFiles.AppendColumn (colChangedPath);
			treeviewFiles.Model = changedpathstore;
			treeviewFiles.Selection.Changed += FileSelectionChanged;
			diffWidget = new DiffWidget (info, true);
			vboxCompareView.PackStart (diffWidget, true, true, 0);
			vboxCompareView.ShowAll ();
			textviewDetails.WrapMode = Gtk.WrapMode.Word;
		}

		void FileSelectionChanged (object sender, EventArgs e)
		{
			Revision rev = SelectedRevision;
			if (rev == null) {
				diffWidget.ComparisonWidget.OriginalEditor.Text = "";
				diffWidget.ComparisonWidget.DiffEditor.Text = "";
				return;
			}
			TreeIter iter;
			if (!treeviewFiles.Selection.GetSelected (out iter))
				return;
			string path = (string)changedpathstore.GetValue (iter, 5);
			ThreadPool.QueueUserWorkItem (delegate {
				string text = info.Item.Repository.GetTextAtRevision (path, rev);
				string prevRevision = text; // info.Item.Repository.GetTextAtRevision (path, rev.GetPrevious ());
				
				Application.Invoke (delegate {
					diffWidget.ComparisonWidget.OriginalEditor.Text = prevRevision;
					diffWidget.ComparisonWidget.DiffEditor.Text = text;
					diffWidget.ComparisonWidget.CreateDiff ();
				});
			});
		}
		
		public override void Destroy ()
		{
			base.Destroy ();
			logstore.Dispose ();
			changedpathstore.Dispose ();
		}
		
		static void DateFunc (Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			CellRendererText renderer = (CellRendererText)cell;
			var rev = (Revision)model.GetValue (iter, 0);
			string day;
			var age = rev.Time - DateTime.Now;
			if (age.TotalDays == 0) {
				day = GettextCatalog.GetString ("Today");
			} else if (age.TotalDays == 1) {
				day = GettextCatalog.GetString ("Yesterday");
			} else {
				day = rev.Time.ToShortDateString ();
			}
			string time = rev.Time.ToString ("HH:MM");
			renderer.Text = day + " " + time;
		}	
		
		static void MessageFunc (Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			CellRendererText renderer = (CellRendererText)cell;
			var rev = (Revision)model.GetValue (iter, 0);
			if (string.IsNullOrEmpty (rev.Message)) {
				renderer.Text = GettextCatalog.GetString ("(No message)");
			} else {
				string message = BlameWidget.FormatMessage (rev.Message);
				int idx = message.IndexOf ('\n');
				if (idx > 0)
					message = message.Substring (0, idx);
				renderer.Text = message;
			}
		}
		
		static void AuthorFunc (Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			CellRendererText renderer = (CellRendererText)cell;
			var rev = (Revision)model.GetValue (iter, 0);
			string author = rev.Author;
			int idx = author.IndexOf ("<");
			if (idx >= 0 && idx < author.IndexOf (">"))
				author = author.Substring (0, idx).Trim ();
			renderer.Text = author;
		}
		
		static void RevisionFunc (Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			CellRendererText renderer = (CellRendererText)cell;
			var rev = (Revision)model.GetValue (iter, 0);
			renderer.Text = rev.ToString ();
		}
		protected override void OnSizeAllocated (Gdk.Rectangle allocation)
		{
			var old = Allocation;
			base.OnSizeAllocated (allocation);
			if (old.Width != allocation.Width || old.Height != allocation.Height) {
				hpaned1.Position = allocation.Width - 380;
				hpaned2.Position = 400;
				vpaned1.Position = allocation.Width / 3;
			}
		}
		Revision SelectedRevision {
			get {
				TreeIter iter;
				if (!treeviewLog.Selection.GetSelected (out iter))
					return null;
				return (Revision)logstore.GetValue (iter, 0);
			}
		}
		
		void TreeSelectionChanged (object o, EventArgs args)
		{
			Revision d = SelectedRevision;
			changedpathstore.Clear ();
			textviewDetails.Buffer.Clear ();
			
			if (d == null)
				return;
			Gtk.TreeIter selectIter = Gtk.TreeIter.Zero;
			bool select = false;
			foreach (RevisionPath rp in d.ChangedFiles) {
				Gdk.Pixbuf actionIcon;
				string action = null;
				if (rp.Action == RevisionAction.Add) {
					action = GettextCatalog.GetString ("Add");
					actionIcon = ImageService.GetPixbuf (Gtk.Stock.Add, Gtk.IconSize.Menu);
				} else if (rp.Action == RevisionAction.Delete) {
					action = GettextCatalog.GetString ("Delete");
					actionIcon = ImageService.GetPixbuf (Gtk.Stock.Remove, Gtk.IconSize.Menu);
				} else if (rp.Action == RevisionAction.Modify) {
					action = GettextCatalog.GetString ("Modify");
					actionIcon = ImageService.GetPixbuf ("gtk-edit", Gtk.IconSize.Menu);
				} else if (rp.Action == RevisionAction.Replace) {
					action = GettextCatalog.GetString ("Replace");
					actionIcon = ImageService.GetPixbuf ("gtk-edit", Gtk.IconSize.Menu);
				} else {
					action = rp.ActionDescription;
					actionIcon = ImageService.GetPixbuf (MonoDevelop.Ide.Gui.Stock.Empty, Gtk.IconSize.Menu);
				}
				Gdk.Pixbuf fileIcon = DesktopService.GetPixbufForFile (rp.Path, Gtk.IconSize.Menu);
				var iter = changedpathstore.AppendValues (actionIcon, action, fileIcon, System.IO.Path.GetFileName (rp.Path), System.IO.Path.GetDirectoryName (rp.Path), rp.Path);
				if (rp.Path == preselectFile) {
					selectIter = iter;
					select = true;
				}
			}
			StringBuilder sb = new StringBuilder ();
			sb.AppendLine (string.Format (GettextCatalog.GetString ("Author: {0}"), d.Author));
			sb.AppendLine (string.Format (GettextCatalog.GetString ("Date: {0}"), d.Time));
			sb.AppendLine (string.Format (GettextCatalog.GetString ("Revision: {0}"), d.ToString ()));
			sb.AppendLine ();
			sb.AppendLine (d.Message);
			
			textviewDetails.Buffer.Text = sb.ToString ();
			
			if (select)
				treeviewFiles.Selection.SelectIter (selectIter);
		}
		
		void UpdateHistory ()
		{
			var h = History;
			if (h == null)
				return;
			logstore.Clear ();
			foreach (var rev in h) {
				logstore.AppendValues (rev);
			}
		}
	}
}