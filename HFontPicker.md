# Introduction #

This widget is an office like font picker.

# Details #
![http://lh6.ggpht.com/fr.daniil/SC2w4HasyPI/AAAAAAAAABU/7iB3NWBAf7Q/font-picker.jpg](http://lh6.ggpht.com/fr.daniil/SC2w4HasyPI/AAAAAAAAABU/7iB3NWBAf7Q/font-picker.jpg)




---


Methods:
| _void_ | **ShowPopup()** | - | shows the font popup |
|:-------|:----------------|:--|:---------------------|

Properties:
| _string_ | **Font** | gets/sets the current selected font |
|:---------|:---------|:------------------------------------|

Events:
|_FontEventHandler_| **FontChange** | - raised when the current font changes |
|:-----------------|:---------------|:---------------------------------------|


---



  * code sample:
```
using HollyLibrary;
using Gtk;

public class MainWin : Gtk.Window
{
	public MainWin() : base(Gtk.WindowType.Toplevel)
	{
            this.DeleteEvent  += new Gtk.DeleteEventHandler( this.OnDeleteEvent );
            //create the picker widget
            HFontPicker picker = new HFontPicker();
            picker.FontChange += new FontEventHandler( this.OnFontChange );
            //add the widget to the window
            this.add( picker );
            //show window
            this.ShowAll();
        }

        protected virtual void OnFontChange (object sender, FontEventArgs args)
	{
	    Console.WriteLine( "font changed to:" + args.Font );		
	}

        protected virtual void OnDeleteEvent (object o, Gtk.DeleteEventArgs args)
	{
		Gtk.Application.Quit();
		args.RetVal = true;
	}

        public static void Main (string[] args)
	{
		Gdk.Threads.Init ();
		Application.Init ();
		MainWin win = new MainWin();
		win.Show ();
		Gdk.Threads.Enter();
		Application.Run ();
		Gdk.Threads.Leave();
	}
}
```