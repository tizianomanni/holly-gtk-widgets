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
    
    
    public partial class ComboListWindow {
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private HollyLibrary.HSimpleList TvList;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.ComboListWindow
            this.Name = "HollyLibrary.ComboListWindow";
            this.Title = Mono.Unix.Catalog.GetString("ComboListWindow");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Decorated = false;
            // Container child HollyLibrary.ComboListWindow.Gtk.Container+ContainerChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.TvList = new HollyLibrary.HSimpleList();
            this.TvList.CanFocus = true;
            this.TvList.Name = "TvList";
            this.TvList.HeadersClickable = true;
            this.TvList.ItemHeight = 0;
            this.TvList.SelectedIndex = 0;
            this.TvList.OwnerDraw = false;
            this.GtkScrolledWindow.Add(this.TvList);
            this.Add(this.GtkScrolledWindow);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 264;
            this.DefaultHeight = 242;
            this.Show();
        }
    }
}
