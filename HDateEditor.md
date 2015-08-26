# Introduction #

This widget is a date time picker, supporting custom formatting options.

# Details #

![http://lh5.ggpht.com/fr.daniil/SC2x63asyQI/AAAAAAAAABg/GgtQyuEU_Es/datetime-picker.jpg](http://lh5.ggpht.com/fr.daniil/SC2x63asyQI/AAAAAAAAABg/GgtQyuEU_Es/datetime-picker.jpg)




---


Methods:
| _bool_ | **IsDateValid()** | - | returns true if the date-time string is valid |
|:-------|:------------------|:--|:----------------------------------------------|

Properties:
| _DateTime_ | **CurrentDate** | gets/sets the current date-time  |
|:-----------|:----------------|:---------------------------------|
| _DateTimeFormatTypeEnum_ | **DateTimeFormatType** | gets/sets the current date-time format type |
| _Gdk.Color_ | **ErrorColor**  | gets/sets the text color when format is invalid |

Events:
|_EventHandler_| **DateChanged** | - raised when date-time value is changed |
|:-------------|:----------------|:-----------------------------------------|


---





  * Formatting types:
  1. Custom
  1. FullDateTime
  1. ShortTime
  1. ShortDate
  1. LongDate
  1. LongTime


  * Custom format example:
```
this.dateEditWidget.DateTimeFormatType = HollyLibrary.DateTimeFormatTypeEnum.Custom;
this.dateEditWidget.CustomFormat       = "dd/MM/yyyy 'and time is:' HH:mm:ss";
this.dateEditWidget.CurrentDate        = DateTime.Now;
```

  * Simple short date-only format example:
```
this.dateEditWidget.DateTimeFormatType = HollyLibrary.DateTimeFormatTypeEnum.ShortDate;
this.dateEditWidget.CurrentDate        = DateTime.Now;
```

