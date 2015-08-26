# Introduction #

A easy to use combobox with a treeview inside


![http://lh4.ggpht.com/fr.daniil/SDrjCtKf7XI/AAAAAAAAADA/q1RITVqwA1M/gtk-combo-tree.jpg](http://lh4.ggpht.com/fr.daniil/SDrjCtKf7XI/AAAAAAAAADA/q1RITVqwA1M/gtk-combo-tree.jpg)


Methods:
_none_

Properties:
| _string_ | **Text** | gets/sets the current text |
|:---------|:---------|:---------------------------|
| _HTreeView_ | **Tree** | gets the popup treewidget as a HTreeView |
| _int_    | **DropDownHeight** | gets/sets the current drop down height |

Events:
|_EventHandler_| **ValueChanged** | - raised when the current text changes |
|:-------------|:-----------------|:---------------------------------------|


---




# Details #

Example:
```
   HTreeNode root   = new HTreeNode( "gigi1" );
   combobox.Tree.Nodes.Add( root );
			
   root.Nodes.Add( new HTreeNode( "gigi2" ) );
   root.Nodes.Add( new HTreeNode( "gigi3" ) );
   root.Nodes.Add( new HTreeNode( "gigi4" ) );

```
see the wiki for the HTreeView [here](http://code.google.com/p/holly-gtk-widgets/wiki/HTreeView) for more info.