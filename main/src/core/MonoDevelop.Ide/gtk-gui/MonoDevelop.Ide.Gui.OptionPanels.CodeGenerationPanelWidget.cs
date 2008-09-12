// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.OptionPanels {
    
    
    internal partial class CodeGenerationPanelWidget {
        
        private Gtk.VBox vbox8;
        
        private Gtk.VBox vbox9;
        
        private Gtk.Label hdr_code_generation_options;
        
        private Gtk.HBox hbox6;
        
        private Gtk.Label label27;
        
        private Gtk.VBox vbox11;
        
        private Gtk.CheckButton chk_blk_on_same_line;
        
        private Gtk.CheckButton chk_else_on_same_line;
        
        private Gtk.CheckButton chk_blank_lines;
        
        private Gtk.CheckButton chk_full_type_names;
        
        private Gtk.VBox vbox10;
        
        private Gtk.Label hdr_comment_generation_options;
        
        private Gtk.HBox hbox7;
        
        private Gtk.Label label15;
        
        private Gtk.VBox vbox12;
        
        private Gtk.CheckButton chk_doc_comments;
        
        private Gtk.CheckButton chk_other_comments;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.OptionPanels.CodeGenerationPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Ide.Gui.OptionPanels.CodeGenerationPanelWidget";
            // Container child MonoDevelop.Ide.Gui.OptionPanels.CodeGenerationPanelWidget.Gtk.Container+ContainerChild
            this.vbox8 = new Gtk.VBox();
            this.vbox8.Name = "vbox8";
            this.vbox8.Spacing = 12;
            // Container child vbox8.Gtk.Box+BoxChild
            this.vbox9 = new Gtk.VBox();
            this.vbox9.Name = "vbox9";
            this.vbox9.Spacing = 6;
            // Container child vbox9.Gtk.Box+BoxChild
            this.hdr_code_generation_options = new Gtk.Label();
            this.hdr_code_generation_options.Name = "hdr_code_generation_options";
            this.hdr_code_generation_options.Xalign = 0F;
            this.hdr_code_generation_options.Yalign = 0F;
            this.hdr_code_generation_options.LabelProp = Mono.Unix.Catalog.GetString("<b>Code generation options</b>");
            this.hdr_code_generation_options.UseMarkup = true;
            this.vbox9.Add(this.hdr_code_generation_options);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox9[this.hdr_code_generation_options]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox9.Gtk.Box+BoxChild
            this.hbox6 = new Gtk.HBox();
            this.hbox6.Name = "hbox6";
            // Container child hbox6.Gtk.Box+BoxChild
            this.label27 = new Gtk.Label();
            this.label27.Name = "label27";
            this.label27.Xalign = 0F;
            this.label27.Yalign = 0F;
            this.label27.LabelProp = "    ";
            this.hbox6.Add(this.label27);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox6[this.label27]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox6.Gtk.Box+BoxChild
            this.vbox11 = new Gtk.VBox();
            this.vbox11.Name = "vbox11";
            this.vbox11.Spacing = 6;
            // Container child vbox11.Gtk.Box+BoxChild
            this.chk_blk_on_same_line = new Gtk.CheckButton();
            this.chk_blk_on_same_line.Name = "chk_blk_on_same_line";
            this.chk_blk_on_same_line.Label = Mono.Unix.Catalog.GetString("_Start code block on the same line");
            this.chk_blk_on_same_line.DrawIndicator = true;
            this.chk_blk_on_same_line.UseUnderline = true;
            this.vbox11.Add(this.chk_blk_on_same_line);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox11[this.chk_blk_on_same_line]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox11.Gtk.Box+BoxChild
            this.chk_else_on_same_line = new Gtk.CheckButton();
            this.chk_else_on_same_line.Name = "chk_else_on_same_line";
            this.chk_else_on_same_line.Label = Mono.Unix.Catalog.GetString("_Else on same line as closing bracket");
            this.chk_else_on_same_line.DrawIndicator = true;
            this.chk_else_on_same_line.UseUnderline = true;
            this.vbox11.Add(this.chk_else_on_same_line);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox11[this.chk_else_on_same_line]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox11.Gtk.Box+BoxChild
            this.chk_blank_lines = new Gtk.CheckButton();
            this.chk_blank_lines.Name = "chk_blank_lines";
            this.chk_blank_lines.Label = Mono.Unix.Catalog.GetString("_Insert blank lines between members");
            this.chk_blank_lines.DrawIndicator = true;
            this.chk_blank_lines.UseUnderline = true;
            this.vbox11.Add(this.chk_blank_lines);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox11[this.chk_blank_lines]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox11.Gtk.Box+BoxChild
            this.chk_full_type_names = new Gtk.CheckButton();
            this.chk_full_type_names.Name = "chk_full_type_names";
            this.chk_full_type_names.Label = Mono.Unix.Catalog.GetString("_Use full type names");
            this.chk_full_type_names.DrawIndicator = true;
            this.chk_full_type_names.UseUnderline = true;
            this.vbox11.Add(this.chk_full_type_names);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox11[this.chk_full_type_names]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            this.hbox6.Add(this.vbox11);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox6[this.vbox11]));
            w7.Position = 1;
            w7.Expand = false;
            this.vbox9.Add(this.hbox6);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox9[this.hbox6]));
            w8.Position = 1;
            this.vbox8.Add(this.vbox9);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox8[this.vbox9]));
            w9.Position = 0;
            w9.Expand = false;
            // Container child vbox8.Gtk.Box+BoxChild
            this.vbox10 = new Gtk.VBox();
            this.vbox10.Name = "vbox10";
            this.vbox10.Spacing = 6;
            // Container child vbox10.Gtk.Box+BoxChild
            this.hdr_comment_generation_options = new Gtk.Label();
            this.hdr_comment_generation_options.Name = "hdr_comment_generation_options";
            this.hdr_comment_generation_options.Xalign = 0F;
            this.hdr_comment_generation_options.Yalign = 0F;
            this.hdr_comment_generation_options.LabelProp = Mono.Unix.Catalog.GetString("<b>Comment generation options</b>");
            this.hdr_comment_generation_options.UseMarkup = true;
            this.vbox10.Add(this.hdr_comment_generation_options);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox10[this.hdr_comment_generation_options]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox10.Gtk.Box+BoxChild
            this.hbox7 = new Gtk.HBox();
            this.hbox7.Name = "hbox7";
            // Container child hbox7.Gtk.Box+BoxChild
            this.label15 = new Gtk.Label();
            this.label15.Name = "label15";
            this.label15.Xalign = 0F;
            this.label15.Yalign = 0F;
            this.label15.LabelProp = "    ";
            this.hbox7.Add(this.label15);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox7[this.label15]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child hbox7.Gtk.Box+BoxChild
            this.vbox12 = new Gtk.VBox();
            this.vbox12.Name = "vbox12";
            this.vbox12.Spacing = 6;
            // Container child vbox12.Gtk.Box+BoxChild
            this.chk_doc_comments = new Gtk.CheckButton();
            this.chk_doc_comments.Name = "chk_doc_comments";
            this.chk_doc_comments.Label = Mono.Unix.Catalog.GetString("Generate _documentation comments");
            this.chk_doc_comments.DrawIndicator = true;
            this.chk_doc_comments.UseUnderline = true;
            this.vbox12.Add(this.chk_doc_comments);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox12[this.chk_doc_comments]));
            w12.Position = 0;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox12.Gtk.Box+BoxChild
            this.chk_other_comments = new Gtk.CheckButton();
            this.chk_other_comments.Name = "chk_other_comments";
            this.chk_other_comments.Label = Mono.Unix.Catalog.GetString("Generate _additional comments");
            this.chk_other_comments.DrawIndicator = true;
            this.chk_other_comments.UseUnderline = true;
            this.vbox12.Add(this.chk_other_comments);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox12[this.chk_other_comments]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            this.hbox7.Add(this.vbox12);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox7[this.vbox12]));
            w14.Position = 1;
            this.vbox10.Add(this.hbox7);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox10[this.hbox7]));
            w15.Position = 1;
            this.vbox8.Add(this.vbox10);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox8[this.vbox10]));
            w16.Position = 1;
            w16.Expand = false;
            this.Add(this.vbox8);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
