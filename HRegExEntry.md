# Introduction #

![http://lh3.ggpht.com/fr.daniil/SDFlIXasyTI/AAAAAAAAAB4/5mN7NVnXC-c/regex1.jpg](http://lh3.ggpht.com/fr.daniil/SDFlIXasyTI/AAAAAAAAAB4/5mN7NVnXC-c/regex1.jpg)
![http://lh4.ggpht.com/fr.daniil/SDFlInasyUI/AAAAAAAAACA/-uKsC6BXGos/regex2.jpg](http://lh4.ggpht.com/fr.daniil/SDFlInasyUI/AAAAAAAAACA/-uKsC6BXGos/regex2.jpg)




---


Methods:
_none_

Properties:
| _Gtk.Entry_ | **Entry** | gets the inner Entry |
|:------------|:----------|:---------------------|
| _string_    | **Text**  | gets/sets the current text |
| _bool_      | **IsTextValid** | returns true if current text is valid |
| _string_    | **RegularExpression** | regular expression used to check the text |
| _string_    | **OkMessage** | the tooltip message when text is valid |
| _string_    | **ErrorMessage** | the tooltip message when text is not valid |


Events:
_none_


---



# Details #
  * Code sample:

```
// Test.cs created with MonoDevelop

using System;
using HollyLibrary;


namespace test
{
	
	
	public class Test : Gtk.Window
	{
		
		HRegExEntry entry = new HRegExEntry();
		Gtk.Button  btn   = new Gtk.Button("push me");

                public Test() : base(Gtk.WindowType.Toplevel)
                {
			this.DeleteEvent   += new Gtk.DeleteEventHandler( this.OnDeleteEvent );
			
			btn.Clicked        += new EventHandler( this.on_btn_clicked );
			entry.RegularExpression = "\\d{3}-\\d{2}-\\d{4}";
			entry.ErrorMessage      = "Wrong format!";
			entry.OkMessage         = "Yeah, it's ok now";
			
			Gtk.VBox layout = new Gtk.VBox();
			
			layout.PackStart( entry );
			layout.PackStart( btn   );
			
			this.Add(layout);
			//show window
			this.ShowAll();
                }

		private void on_btn_clicked( object o, EventArgs args )
		{
			Console.WriteLine( "Entry is valid: " + entry.IsTextValid  );
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
                   Test win = new Test();
                   win.Show ();
                   Gdk.Threads.Enter();
                   Application.Run ();
                   Gdk.Threads.Leave();
                }

	}
}

```