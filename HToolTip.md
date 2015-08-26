# Introduction #

A nice baloon tooltip window for GTK.

![http://lh4.ggpht.com/fr.daniil/SDayVaJcrpI/AAAAAAAAACo/0Ec8bJ6thso/h-gtk-baloon-tooltip.jpg](http://lh4.ggpht.com/fr.daniil/SDayVaJcrpI/AAAAAAAAACo/0Ec8bJ6thso/h-gtk-baloon-tooltip.jpg)

If you want to add the tooltip to a Gtk.Image or an Gtk.Label you have to put those widgets first in a Gtk.EventBox, and set the tooltip to the eventbox.
```
using HollyLibrary;
...
   Gtk.Label lbl = new Gtk.Label("my label");
   Gtk.EventBox eventBox = new Gtk.EventBox();
   eventBox.Add( lbl );
   //add here your eventbox to the window
   ...
   ///and set the tooltip:
   HToolTip.SetToolTip( eventBox, "title 1", "text"  );  
```


---


Methods:

|_void_ | static **SetToolTip**|( Gtk.Widget widget, String title, String text, String StockIcon )|  Sets the tooltip for widget, with a title, a body text and a stock icon.|
|:------|:-------|:-----------------------------------------------------------------|:-------------------------------------------------------------------------|
|_void_ |  static **SetToolTip**|( Gtk.Widget widget, String title, String text, Color color1, Color color2 )|  Sets the tooltip for widget, with a title, a body text and custom gradient colors.|
|_void_ |  static **SetToolTip**|( Gtk.Widget widget, String title, String text )|  Sets the tooltip for widget, with a title and a body text using default colors and icon.|
|_void_ |  static **SetToolTip**|( Gtk.Widget widget, String title, String text, Color color1, Color color2, String StockIcon )|  Sets the tooltip for widget, with a title, a body text , custom gradient colors and custom stock icon.|

Properties:

| _int_ |  static **ToolTipInterval** | Sets the tooltip appear interval in miliseconds |
|:------|:----------------------------|:------------------------------------------------|


---


Code sample:
```
using HollyLibrary;
...

   //optional line - you can set from here the tooltip appear interval( in miliseconds )
   HollyLibrary.HToolTip.ToolTipInterval = 10; 
   //assign tooltips to some buttons
   String text = "My first line of text \r\n";
   text       += "Second line of text bla bla \r\n";
   text       += "last line of text";
   //add the first simple tooltip ( with the default icon and colors )
   HToolTip.SetToolTip( button1, "title 1", text  );  
   //add the second tooltip with another stock-icon
   HToolTip.SetToolTip( button2, "title 2", text, "gtk-yes" );
   //add the third tooltip with customized colors
   HToolTip.SetToolTip( button3, "title 3", text, Color.White, Color.Black );
   //add the last tooltip with customized colors and another stock icon
   HToolTip.SetToolTip( button4, "title 4", text, Color.Yellow, Color.Orange, "gtk-no" );

```