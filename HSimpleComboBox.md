# Introduction #

HSimpleComboBox is a simple combobox type widget, similar to the winforms ComboBox.  The popup inner list is a HSimpleList widget and you have access to all of the list features.

# Details #
![http://lh3.ggpht.com/fr.daniil/SDFh9XasySI/AAAAAAAAABw/kTA_B5Ts9Rs/hsimplecombobox.jpg](http://lh3.ggpht.com/fr.daniil/SDFh9XasySI/AAAAAAAAABw/kTA_B5Ts9Rs/hsimplecombobox.jpg)




---


Methods:
| _void_ | **ShowPopup()** | - | shows the list popup |
|:-------|:----------------|:--|:---------------------|

Properties:
| _bool_ | **IsEditable** | gets/sets if the combobox is editable |
|:-------|:---------------|:--------------------------------------|
| _string_ | **Text**       | gets/sets the current value as a text |
| _HSimpleList_ | **List**       | gets the popup list widget            |
| _int_  | **DropDownHeight** | gets/sets the popup height            |


Events:
|_EventHandler_| **DropDownOpened** | - raised when the popup is opened |
|:-------------|:-------------------|:----------------------------------|
|_EventHandler_| **DropDownClosed** | - raised when the popup is closed |
|_EventHandler_| **TextChanged**    | - raised when the current text changes |



---






**How to set if the combobox is editable or not:
```
   comboWidget.IsEditable = true;
   //
   comboWidget.IsEditable = false;
```**

**How to set the drop down popup height:
```
   comboWidget.DropDownHeight = 500;
```**

