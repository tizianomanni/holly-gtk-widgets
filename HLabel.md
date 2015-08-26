# Introduction #

This widget is a simple label widget, as much as I could think similar to the winforms label, with support for icon, icon position and text position. Also you can display a horizontal line in the right of the text ( like a groupbox header ).

# Details #

with a horizontal line:
![http://lh6.ggpht.com/fr.daniil/SNFBxlAu1hI/AAAAAAAAAHU/GQLQBA8Zt8Y/hlabel.jpg](http://lh6.ggpht.com/fr.daniil/SNFBxlAu1hI/AAAAAAAAAHU/GQLQBA8Zt8Y/hlabel.jpg)

with text on bottom and icon on center:
![http://lh6.ggpht.com/fr.daniil/SNFCKrzOD-I/AAAAAAAAAHc/OSfjvHvcAuQ/hlabel2.jpg](http://lh6.ggpht.com/fr.daniil/SNFCKrzOD-I/AAAAAAAAAHc/OSfjvHvcAuQ/hlabel2.jpg)

Properties:
| _HPosition_ | **IconPosition**       | gets/sets the icon position |
|:------------|:-----------------------|:----------------------------|
| _HPosition_ | **TextPosition**       | gets/sets the text position |
| _bool_      | **TextOverwritesIcon** | gets/sets if the text overwrites the icon   |
| _bool_      | **HorizontalLine**     | gets/sets if text has a horizontal line in the right |
| _string_    | **Text**               | the text displayed          |


HPosition enum:
**Top, Bottom, Left, Right, TopLeft, TopRight, BottomLeft, BottomRight, Center**

# Code samples #

  * How to set the text position:
```
   lbl.TextPosition     = HPosition.Bottom;
```

  * How to set the icon position:
```
   lbl.IconPosition         = HPosition.TopRight;
```

  * code sample:
```

   hlabel1.TextOverwritesIcon = false;
   hlabel1.HorizontalLine     = true;
   hlabel1.TextPosition       = HPosition.Center;
   hlabel1.IconPosition       = HPosition.Left;

   //for example, get the theme folder icon
   Gtk.IconTheme theme = Gtk.IconTheme.Default;
   Gdk.Pixbuf buf      = theme.LoadIcon("folder",24, Gtk.IconLookupFlags.ForceSvg);
   //set icon for label
   hlabel1.Icon        = buf;
```