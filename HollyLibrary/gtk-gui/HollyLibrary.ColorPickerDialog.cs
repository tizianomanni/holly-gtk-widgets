// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HollyLibrary {
    
    
    public partial class ColorPickerDialog {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Table TblColors;
        
        private Gtk.Button BtnMoreColors;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.ColorPickerDialog
            this.Name = "HollyLibrary.ColorPickerDialog";
            this.Title = "ColorPickerDialog";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Resizable = false;
            this.AllowGrow = false;
            this.Decorated = false;
            this.DestroyWithParent = true;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Container child HollyLibrary.ColorPickerDialog.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            this.vbox1.BorderWidth = ((uint)(5));
            // Container child vbox1.Gtk.Box+BoxChild
            this.TblColors = new Gtk.Table(((uint)(5)), ((uint)(8)), true);
            this.TblColors.Name = "TblColors";
            this.TblColors.RowSpacing = ((uint)(1));
            this.TblColors.ColumnSpacing = ((uint)(1));
            this.vbox1.Add(this.TblColors);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.TblColors]));
            w1.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.BtnMoreColors = new Gtk.Button();
            this.BtnMoreColors.CanFocus = true;
            this.BtnMoreColors.Name = "BtnMoreColors";
            this.BtnMoreColors.UseUnderline = true;
            // Container child BtnMoreColors.Gtk.Container+ContainerChild
            Gtk.Alignment w2 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w3 = new Gtk.HBox();
            w3.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w4 = new Gtk.Image();
            w4.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-color-picker", Gtk.IconSize.Menu, 16);
            w3.Add(w4);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w6 = new Gtk.Label();
            w6.LabelProp = "More";
            w6.UseUnderline = true;
            w3.Add(w6);
            w2.Add(w3);
            this.BtnMoreColors.Add(w2);
            this.vbox1.Add(this.BtnMoreColors);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox1[this.BtnMoreColors]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 230;
            this.DefaultHeight = 160;
            this.Show();
            this.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnButtonPressEvent);
            this.BtnMoreColors.Clicked += new System.EventHandler(this.OnBtnMoreColorsClicked);
        }
    }
}
