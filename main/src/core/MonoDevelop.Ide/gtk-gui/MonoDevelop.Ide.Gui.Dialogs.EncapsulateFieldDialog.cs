// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class EncapsulateFieldDialog {
        
        private Gtk.VBox vbox;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView treeview;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button buttonSelectAll;
        
        private Gtk.Button buttonUnselectAll;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.Label labelUpdateRefs;
        
        private Gtk.HBox hboxUpdateRefs;
        
        private Gtk.Label labelSpacer;
        
        private Gtk.VBox vboxUpdateChoices;
        
        private Gtk.RadioButton radioUpdateExternal;
        
        private Gtk.RadioButton radioUpdateAll;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Image imageError;
        
        private Gtk.Label labelError;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog";
            this.Title = Mono.Unix.Catalog.GetString("Encapsulate Fields...");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox = new Gtk.VBox();
            this.vbox.Name = "vbox";
            this.vbox.Spacing = 6;
            this.vbox.BorderWidth = ((uint)(6));
            // Container child vbox.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.treeview = new Gtk.TreeView();
            this.treeview.CanFocus = true;
            this.treeview.Name = "treeview";
            this.treeview.HeadersClickable = true;
            this.GtkScrolledWindow.Add(this.treeview);
            this.vbox.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox[this.GtkScrolledWindow]));
            w3.Position = 0;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSelectAll = new Gtk.Button();
            this.buttonSelectAll.CanFocus = true;
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.UseUnderline = true;
            this.buttonSelectAll.Label = Mono.Unix.Catalog.GetString("Select All");
            this.hbox1.Add(this.buttonSelectAll);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSelectAll]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonUnselectAll = new Gtk.Button();
            this.buttonUnselectAll.CanFocus = true;
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.UseUnderline = true;
            this.buttonUnselectAll.Label = Mono.Unix.Catalog.GetString("Unselect All");
            this.hbox1.Add(this.buttonUnselectAll);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonUnselectAll]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            this.vbox.Add(this.hbox1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox1]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox.Add(this.hseparator2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox[this.hseparator2]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.labelUpdateRefs = new Gtk.Label();
            this.labelUpdateRefs.Name = "labelUpdateRefs";
            this.labelUpdateRefs.Xalign = 0F;
            this.labelUpdateRefs.LabelProp = Mono.Unix.Catalog.GetString("_Update references:");
            this.labelUpdateRefs.UseUnderline = true;
            this.vbox.Add(this.labelUpdateRefs);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox[this.labelUpdateRefs]));
            w8.Position = 3;
            w8.Expand = false;
            w8.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hboxUpdateRefs = new Gtk.HBox();
            this.hboxUpdateRefs.Name = "hboxUpdateRefs";
            this.hboxUpdateRefs.Spacing = 6;
            // Container child hboxUpdateRefs.Gtk.Box+BoxChild
            this.labelSpacer = new Gtk.Label();
            this.labelSpacer.Name = "labelSpacer";
            this.labelSpacer.Xalign = 0F;
            this.labelSpacer.LabelProp = "    ";
            this.hboxUpdateRefs.Add(this.labelSpacer);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hboxUpdateRefs[this.labelSpacer]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child hboxUpdateRefs.Gtk.Box+BoxChild
            this.vboxUpdateChoices = new Gtk.VBox();
            this.vboxUpdateChoices.Name = "vboxUpdateChoices";
            this.vboxUpdateChoices.Spacing = 6;
            // Container child vboxUpdateChoices.Gtk.Box+BoxChild
            this.radioUpdateExternal = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_External"));
            this.radioUpdateExternal.CanFocus = true;
            this.radioUpdateExternal.Name = "radioUpdateExternal";
            this.radioUpdateExternal.DrawIndicator = true;
            this.radioUpdateExternal.UseUnderline = true;
            this.radioUpdateExternal.Group = new GLib.SList(System.IntPtr.Zero);
            this.vboxUpdateChoices.Add(this.radioUpdateExternal);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vboxUpdateChoices[this.radioUpdateExternal]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vboxUpdateChoices.Gtk.Box+BoxChild
            this.radioUpdateAll = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_All"));
            this.radioUpdateAll.CanFocus = true;
            this.radioUpdateAll.Name = "radioUpdateAll";
            this.radioUpdateAll.DrawIndicator = true;
            this.radioUpdateAll.UseUnderline = true;
            this.radioUpdateAll.Group = this.radioUpdateExternal.Group;
            this.vboxUpdateChoices.Add(this.radioUpdateAll);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vboxUpdateChoices[this.radioUpdateAll]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            this.hboxUpdateRefs.Add(this.vboxUpdateChoices);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hboxUpdateRefs[this.vboxUpdateChoices]));
            w12.Position = 1;
            this.vbox.Add(this.hboxUpdateRefs);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox[this.hboxUpdateRefs]));
            w13.Position = 4;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.imageError = new Gtk.Image();
            this.imageError.Name = "imageError";
            this.hbox2.Add(this.imageError);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox2[this.imageError]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.labelError = new Gtk.Label();
            this.labelError.Name = "labelError";
            this.labelError.LabelProp = "";
            this.hbox2.Add(this.labelError);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox2[this.labelError]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.vbox.Add(this.hbox2);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox2]));
            w16.Position = 5;
            w16.Expand = false;
            w16.Fill = false;
            w1.Add(this.vbox);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(w1[this.vbox]));
            w17.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.EncapsulateFieldDialog.ActionArea
            Gtk.HButtonBox w18 = this.ActionArea;
            w18.Name = "dialog1_ActionArea";
            w18.Spacing = 6;
            w18.BorderWidth = ((uint)(5));
            w18.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w19 = ((Gtk.ButtonBox.ButtonBoxChild)(w18[this.buttonCancel]));
            w19.Expand = false;
            w19.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w20 = ((Gtk.ButtonBox.ButtonBoxChild)(w18[this.buttonOk]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 465;
            this.DefaultHeight = 427;
            this.Show();
        }
    }
}
