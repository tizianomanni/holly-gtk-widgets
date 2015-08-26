# VERSION 2.0 TODO #

**HComboFolder**
  * ~~now it's using the system theme folder / drive icon~~

**HSimpleList**  new features:
  * ~~support checkbox to each item.~~
  * ~~new events :~~
> > ~~ItemCheck~~
  * ~~new properties:~~
> > ~~IsCheckboxList~~
> > ~~CheckedItems~~
> > ~~CheckedItemIndexes~~
  * ~~add the ItemRightClick event~~
  * ~~make drag and drop work~~ ~~some testing to the drag and drop is still needed~~
  * ~~make IsEditable property~~
  * ~~update changes on wiki and write code sample~~
  * ~~no need to add icon support, because I have the ownerdrawn property.~~
  * update wiki

**HLabel**
  * ~~a nicer label widget with support for icon, icon position and text position~~
  * ~~add support for a horizontal line in the right of the text like a groupbox header~~
  * ~~fix drawing bugs when there are multiple widgets on the same window near the label~~
  * ~~update wiki page~~

**HTreeView**  new features:
  * ~~make sure that drag and drop is working~~
  * ~~replace text cell renderer with custom renderer and implement ItemDraw and MeasureItem~~
  * ~~added the NodeRightClick event~~
  * update wiki


_New widget:_ **HNumericEntry**
  1. a entry only for numeric values ( not a numeric up/down )
  1. support for negative values

_New dialog:_ **HColorPickerWidget** && **HColorPickerDialog**
  1. ~~an adobe like color picker nicer then what gtk has by default~~

_New widget:_ **HComboCalculator**
  1. a combobox with a calculator popup to do calculations

**HImageCheckbox**
  1. ~~a checkbox with images for Checked and Unchecked state~~
  1. ~~draw selection rectangle when widget has focus~~
  1. write wiki page

_New widget:_ **HPictureBox**
  1. a picturebox widget similar to the winforms one
  1. ErrorImage property - Gets or sets the image to display when an error occurs during the image-loading process or if the image load is canceled.
  1. Image        - Gets or sets the image that is displayed ( winforms image );
  1. ImagePixbuf  - Gets or sets the image that is displayed ( gtk pixbuf );
  1. ImagePixmap  - Gets or sets the image that is displayed ( gtk pixmap );
  1. InitialImage - Gets or sets the image displayed in the PictureBox control when the main image is loading.
  1. SizeMode     - Indicates how the image is displayed.

|Member name|Description|
|:----------|:----------|
|CenterImage|The image is displayed in the center if the PictureBox is larger than the image. If the image is larger than the PictureBox, the picture is placed in the center of the PictureBox and the outside edges are clipped. |
|Normal     |The image is placed in the upper-left corner of the PictureBox. The image is clipped if it is larger than the PictureBox it is contained in. |
|StretchImage|The image within the PictureBox is stretched or shrunk to fit the size of the PictureBox. |
|Zoom       |The size of the image is increased or decreased maintaining the size ratio.|

  1. SaveAs( String file, String type ) method ( type= jpg/png etc )
  1. ImageChanged, ImageLoaded event

_New widget:_ **HGridView**
  1. a simpler version of [SourceGrid](http://www.codeproject.com/KB/grid/csharpgridcontrol.aspx), or the XPTable, or a swt-table like widget.  Still thinking. [This](http://www.telerik.com/products/winforms/controls/gridview/overview.aspx) is nice also...



  * rebuild HFontPicker to be an extended HSimpleComboBox - also add a nice icon to each font - and maibe do the picker to be like the abiword's one ( it would load faster )
  * verify if i have rights to create a new folder on the HComboFolder widget
  * study data binding in winforms, maybe do something similar for gtk widgets
  * remove any cairo binding - use only System.Drawing ( it's really faster )
  * make a nicer analog clock :) Nice example [here](http://wwww.vgdotnet.com/blog/shiny_clock.png)
  * ~~downgrade Gtk sharp version requirement to 2.10~~

_New widget:_ **HSchedulingCalendar**
  1. a nice calendar widget with scheduling features
  1. see [here](http://www.devexpress.com/Products/NET/WinForms/XtraScheduler) a nice one

**HColorPicker**
  * ~~fix button bug - in some themes, buttons do not renderer corectly~~