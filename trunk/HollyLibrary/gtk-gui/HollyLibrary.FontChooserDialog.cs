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
    
    
    public partial class FontChooserDialog {
        
        private Gtk.VBox vbox1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private HollyLibrary.HSimpleList TvFonts;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.FontChooserDialog
            this.Name = "HollyLibrary.FontChooserDialog";
            this.Title = Mono.Unix.Catalog.GetString("FontChooserDialog");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(1));
            this.Decorated = false;
            // Container child HollyLibrary.FontChooserDialog.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.TvFonts = new HollyLibrary.HSimpleList();
            this.TvFonts.CanFocus = true;
            this.TvFonts.Name = "TvFonts";
            this.TvFonts.HeadersClickable = true;
            this.TvFonts.ItemHeight = 0;
            this.TvFonts.SelectedIndex = 0;
            this.TvFonts.OwnerDraw = true;
            this.GtkScrolledWindow.Add(this.TvFonts);
            this.vbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
            w2.Position = 0;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 228;
            this.DefaultHeight = 173;
            this.Show();
            this.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnButtonPressEvent);
            this.TvFonts.RowActivated += new Gtk.RowActivatedHandler(this.OnTvFontsRowActivated);
            this.TvFonts.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnTvFontsButtonPressEvent);
            this.TvFonts.DrawItem += new HollyLibrary.DrawItemEventHandler(this.OnTvFontsDrawItem);
            this.TvFonts.MeasureItem += new HollyLibrary.MeasureItemEventHandler(this.OnTvFontsMeasureItem);
            this.TvFonts.SelectedIndexChanged += new System.EventHandler(this.OnTvFontsSelectedIndexChanged);
        }
    }
}
