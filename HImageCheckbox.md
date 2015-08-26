# Introduction #

A checkbox widget that allows you to use custom icons for checked/unchecked states.


# Details #

![http://lh5.ggpht.com/fr.daniil/SNPPLTJMA0I/AAAAAAAAAIE/A0ENHUdHraE/chk1.jpg](http://lh5.ggpht.com/fr.daniil/SNPPLTJMA0I/AAAAAAAAAIE/A0ENHUdHraE/chk1.jpg)![http://lh5.ggpht.com/fr.daniil/SNPPLVKgTpI/AAAAAAAAAIM/-zRjebWLiYw/chk2.jpg](http://lh5.ggpht.com/fr.daniil/SNPPLVKgTpI/AAAAAAAAAIM/-zRjebWLiYw/chk2.jpg)

Properties:
| _HPosition_ | **TextPosition**       | gets/sets the text position |
|:------------|:-----------------------|:----------------------------|
| _bool_      | **Checked**            | gets/sets if the checkbox is checked   |
| _Pixbuf_    | **CheckedImage**       | gets/sets the checked image |
| _Pixbuf_    | **UncheckedImage**     | gets/sets the unchecked image |
| _string_    | **Text**               | the text displayed          |


HPosition enum:
**Top, Bottom, Left, Right, TopLeft, TopRight, BottomLeft, BottomRight, Center**


Code sample:
```
    HImageCheckBox chk = new HImageCheckBox("Holly widgets are the best");
    chk.CheckedImage   = GraphUtil.pixbufFromStock( "gtk-yes", Gtk.IconSize.Button );
    chk.UncheckedImage = GraphUtil.pixbufFromStock( "gtk-no" , Gtk.IconSize.Button );
    chk.TextPosition   = HPosition.Center;
    this.Add( chk );
```