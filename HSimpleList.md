# Introduction #

This widget is a simple list widget, as much as I could think similar to the winforms ListBox.  I created because it's faster to use then the usual treeview gtk widget.
It also implements the nice ListBox events MeasureItem and DrawItem.
It supports multiple selection also.

# Details #
V 1.0

![http://lh3.ggpht.com/fr.daniil/SC2zgXasyRI/AAAAAAAAABo/ZCjZjHBqLdA/simple-gtk-list.jpg](http://lh3.ggpht.com/fr.daniil/SC2zgXasyRI/AAAAAAAAABo/ZCjZjHBqLdA/simple-gtk-list.jpg)

V 2.0 with checkbox support and a circle drawn with the OwnerDrawn property enabled

![http://lh3.ggpht.com/fr.daniil/SEbvw_GpFvI/AAAAAAAAADo/AmfvBCaF8KQ/gtk-holly-simple-list-2.jpg](http://lh3.ggpht.com/fr.daniil/SEbvw_GpFvI/AAAAAAAAADo/AmfvBCaF8KQ/gtk-holly-simple-list-2.jpg)

---


Methods:
| _bool_ | **IsSelected** | ( int index ) | returns true if index is the Selected index |
|:-------|:---------------|:--------------|:--------------------------------------------|
| _void_ | **RemoveAllItems** | -             | removes all items - equivalent with Items.Clear()     |
| _void_ | **Sort**       | -             | sorts the items of the list                 |
| _void_ | **Sort**       | ( IComparer comparer ) | sorts the items of the list using a custom comparer|
| _object[.md](.md)_ | **getSelectedItems** | -             | returns an array of the selected items      |
| _int[.md](.md)_    | **getSelectedIndexes** | -             | returns an array of the selected indexes    |
| _void_     | **CheckItemAt**      | ( int index ) | check's the item at the given index         |
| _void_     | **UnCheckItemAt**      | ( int index ) | uncheck's the item at the given index       |

Properties:
| _int_ | **SelectedIndex** | gets/sets the current selected index |
|:------|:------------------|:-------------------------------------|
| _int_ | **ItemHeight**    | gets/sets the item's default height  |
| _ObjectCollection_ | **Items**         | list items collection                |
| _object_  | **SelectedItem**  | gets/sets the current selected item  |
| _string_ | **Text**          | gets/sets the current selected item ( as a string ) |
| _bool_   | **OwnerDraw**     | gets/sets the items drawing mode.    |
| _Gtk.SelectionMode_   | **SelectionType** | the current list selection mode      |
| _List_

&lt;Object&gt;

 | **CheckedItems**  | the current checked item list        |
| _List_

&lt;int&gt;

    | **CheckedItemIndexes** | the indexes list of the checked items |
| _bool_              | **IsCheckBoxList** | if true, the list is a checkbox list |

Events:
|_EventHandler_| **SelectedIndexChanged** | - raised when the selection index changes |
|:-------------|:-------------------------|:------------------------------------------|
|_DrawItemEventHandler_| **DrawItem**             | - usefull when you set the OwnerDrawn to true. See code sample for example |
|_MeasureItemEventHandler_| **MeasureItem**          | - usefull when you set the OwnerDrawn to true. See code sample for example |
| _ListItemCheck_ | **ItemCheck**            | - raised when the checked state of a list item is changed |


---


# Code samples #

  * How to add a an item to the list:
```
   listWidget.Items.Add("test!");
   //or add a object 
   listWidget.Items.Add( new MyClass() );
```

  * How to add multiple items to the list:
```
   string[] items = new string[]{"red", "green", "blue", "yellow", "white"};
   listWidget.Items.AddRange( items );
```

  * How to modify an item at a given index:
```
   int index = 10;
   listWidget.Items[ index ] = "my new value!";
```

  * How to remove an item :
```
  //remove the item at the 10'th index
  int index = 10;
  listWidget.Items.RemoveAt( index );
  //remove an object item:
  listWidget.Items.Remove( item );
```

  * How to remove all items from list:
```
   listWidget.RemoveAllItems();
   //or:
   listWidget.Items.Clear();
```


  * How to get / change the selected index/item :
```
   Console.WriteLine("Selected index is:" + listWidget.SelectedIndex );
   Console.WriteLine("Selected item is :" +listWidget.SelectedItem   );
   //change current index
   listWidget.SelectedIndex = 15;
   Console.WriteLine("Selected index is:" + listWidget.SelectedIndex );
   Console.WriteLine("Selected item is :" +listWidget.SelectedItem   );
   //change current item
   listWidget.SelectedItem = "my item";
   Console.WriteLine("Selected index is:" + listWidget.SelectedIndex );
   Console.WriteLine("Selected item is :" +listWidget.SelectedItem   );
```

  * How to set the default item's height:
```
   listWidget.ItemHeight = 25;
```

  * How to sort the list items:
```
   //use the default sorting:
   listWidget.Sort();
   //or use a comparer
   listWidget.Sort( MyComparer );
```

  * SelectionType example:
Selection types are
  1. Browse
  1. Extended
  1. Multiple
  1. None
  1. Single
In this example we will use the Multiple selection type:
```
using HollyLibrary;
using Gtk;

public class MainWin : Gtk.Window
{
        HSimpleList list   = new HSimpleList();
        Button      btn    = new Button("Get selected");

        public MainWin() : base(Gtk.WindowType.Toplevel)
        {
            this.DeleteEvent  += new Gtk.DeleteEventHandler( this.OnDeleteEvent );
            btn.Clicked       += new EventHandler( this.OnBtnClicked );
            //set the selection type            
            list.SelectionType = Gtk.SelectionMode.Multiple;
			//add some items
			list.Items.AddRange( new String[] {"item1","item2","item3","item4"});
            //create a simple layout
			ScrolledWindow sw  = new ScrolledWindow();
			sw.Add( list );
            VBox layout        = new VBox();
            layout.PackStart( sw, false, false, 0 );
            layout.PackStart( btn , false, false, 0 );
            //add the widget to the window
            this.Add( layout );
            //show window
            this.ShowAll();
        }

        private void OnBtnClicked (object sender, EventArgs args)
        {
            //you have to possibilities here: use the getSelectedIndexes() or use the 
            //getSelectedItems() methods.
            object[] selected_items = list.getSelectedItems();
            foreach( object item in selected_items )
            {
                Console.WriteLine( item );
            }
            int[] selected_indexes = list.getSelectedIndexes();
            foreach( int index in selected_indexes )
            {
                Console.WriteLine( "index: " + index );
            }
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

  * How to create customized lists ( owner drawn ):
In this example we will create a font list similar to the font picker's one.
```
// Test.cs created with MonoDevelop
// User: dantes at 1:49 PM 5/19/2008
//

using System;
using System.Drawing;
using HollyLibrary;


namespace test
{
	
	
	public class Test : Gtk.Window
	{
		
	HSimpleList list   = new HSimpleList();

        public Test() : base(Gtk.WindowType.Toplevel)
        {
            this.DeleteEvent   += new Gtk.DeleteEventHandler( this.OnDeleteEvent );
	    list.OwnerDraw      = true;
	    list.OnDrawItem    += new DrawItemEventHandler( this.on_draw_item );
	    list.OnMeasureItem += new MeasureItemEventHandler( this.on_measure_item );
            //create a simple layout
	     Gtk.ScrolledWindow sw  = new Gtk.ScrolledWindow();
	     sw.Add( list );
             //add the widget to the window
             this.Add( sw );
	     //add font list to list
	     FontFamily[] fonts = FontFamily.Families;
	     int i = 0;
	     foreach( FontFamily font in fonts )
	     {
		list.Items.Add( font.Name );
	     }
            //show window
            this.ShowAll();
        }

	private void on_draw_item( object o, DrawItemEventArgs args )
	{
		String font_name     = list.Items[ args.ItemIndex ].ToString();
		Graphics g           = args.Graphics;
		g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			
		Font font            = new System.Drawing.Font( font_name, 10F );
		Color color          = System.Drawing.Color.Black;
		SolidBrush b         = new System.Drawing.SolidBrush( color );
		g.DrawString( font_name, font, b, args.CellArea.X, args.CellArea.Y );			

	}
		
	private void on_measure_item( object o, MeasureItemEventArgs args )
	{
		//make alternative heights for demonstration
		if( args.Index % 2 == 0 )
			args.ItemHeight = 20;
		else
			args.ItemHeight = 40;
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

  * How to create a checkbox list, also ownerdrawn:

```

using System;
using System.Drawing;
using HollyLibrary;


namespace test
{
	
	
	public class Test : Gtk.Window
	{
		
	HSimpleList list   = new HSimpleList();

        public Test() : base(Gtk.WindowType.Toplevel)
        {
            this.DeleteEvent   += new Gtk.DeleteEventHandler ( this.OnDeleteEvent   );
	    list.OwnerDraw      = true;
            list.IsCheckBoxList = true;
            //list events
	    list.DrawItem    += new DrawItemEventHandler   ( this.on_draw_item    );
	    list.MeasureItem += new MeasureItemEventHandler( this.on_measure_item );
            list.ItemCheck   += new ListItemCheck          ( this.on_item_check   ); 
             //create a simple layout
	     Gtk.ScrolledWindow sw  = new Gtk.ScrolledWindow();
	     sw.Add( list );
             //add the widget to the window
             this.Add( sw );
	     //add some items to the list
	    
	     list.ItemHeight = 25;
	     for( int i = 0; i < 100; i++ )
		list.Items.Add( "checked item no." + i );
		
            //show window
            this.ShowAll();
        }

	private void on_draw_item( object o, DrawItemEventArgs args )
	{
		Graphics g       = args.Graphics;
	        //get the item's text
		String item_text = list.Items[ args.ItemIndex ].ToString();
		//draw a small circle - just for fun
		Rectangle rect   = new Rectangle( args.CellArea.X , args.CellArea.Y, 20, 20 );
		g.FillEllipse( new SolidBrush( Color.DarkBlue ), rect );
		//draw the item's text
		Font font        = new Font("",12F);
		g.DrawString ( item_text, font, new SolidBrush(Color.Red), args.CellArea.X +30, args.CellArea.Y );
		//dispose
		g.Dispose();
	}

        private void on_item_check (object sender, ListItemCheckEventArgs args)
	{
                //show the checked items:
		Console.WriteLine("----------");
		foreach( object obj in list.CheckedItems )
		{
			Console.WriteLine( obj.ToString() );
		}
		Console.WriteLine("----------");
	}

        protected virtual void OnDeleteEvent (object o, Gtk.DeleteEventArgs args)
        {
                Gtk.Application.Quit();
                args.RetVal = true;
        }

        public static void Main (string[] args)
        {
                Application.Init ();
                Test win = new Test();
                win.Show ();
                Application.Run ();
        }
    }
}

```