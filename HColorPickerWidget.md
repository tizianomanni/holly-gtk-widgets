# Introduction #

A adobe photoshop like color picker dialog.

![http://lh6.ggpht.com/fr.daniil/SE5kKOy3aKI/AAAAAAAAAEI/wE-bDhxayho/color_picker_extended1.jpg](http://lh6.ggpht.com/fr.daniil/SE5kKOy3aKI/AAAAAAAAAEI/wE-bDhxayho/color_picker_extended1.jpg)
![http://lh6.ggpht.com/fr.daniil/SE5kKQSKwSI/AAAAAAAAAEQ/fElLuPTJCl8/color_picker_extended2.jpg](http://lh6.ggpht.com/fr.daniil/SE5kKQSKwSI/AAAAAAAAAEQ/fElLuPTJCl8/color_picker_extended2.jpg)
![http://lh4.ggpht.com/fr.daniil/SE7A0Ia9rXI/AAAAAAAAAEY/kzr4mHEFP3g/gtk-sharp-adobe-hsl-rgb-cmyk-color-picker.jpg](http://lh4.ggpht.com/fr.daniil/SE7A0Ia9rXI/AAAAAAAAAEY/kzr4mHEFP3g/gtk-sharp-adobe-hsl-rgb-cmyk-color-picker.jpg)


Properties:

| _string_ | **ColorHexa** | gets/sets the current color in hexa  |
|:---------|:--------------|:-------------------------------------|
| _GraphUtil.CMYK_ | **ColorCMYK**    | gets/sets the current cmyk color     |
| _Gdk.Color_ | **ColorGDK**    | gets/sets the current gdk color      |
| _System.Drawing.Color_ | **ColorRGB**    | gets/sets the current rgb color      |
| _GraphUtil.HSL_ | **ColorHSL**    | gets/sets the current hsl color      |

# Details #

you can use the HColorPicker dialog or the HColorPickerWidget widget.

```
using System.Drawing;
...
	HColorPickerDialog dlg = new HColorPickerDialog();
	dlg.ColorRGB   = Color.AliceBlue;
	if( dlg.Run() == (int)Gtk.ResponseType.Ok )
	{
		Console.WriteLine( dlg.ColorHexa );
	}
	dlg.Destroy()
```