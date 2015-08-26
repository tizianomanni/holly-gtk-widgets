# Introduction #

This is an extended Gtk.TreeView, wich you can use more easy/faster.

![http://lh3.ggpht.com/fr.daniil/SDqlsaY_NNI/AAAAAAAAAC4/3WrR4PqqRNU/gtk-htreeview.jpg](http://lh3.ggpht.com/fr.daniil/SDqlsaY_NNI/AAAAAAAAAC4/3WrR4PqqRNU/gtk-htreeview.jpg)



---


Methods:
| _void_ | **selectNode** | ( HTreeNode node ) | selects a specific node and move cursor on it |
|:-------|:---------------|:-------------------|:----------------------------------------------|
| _void_ | **expandNode** | ( HTreeNode node ) | expand a specific node                        |
| _void_ | **collapseNode** | ( HTreeNode node ) | collapses a specific node                     |
| _HTreeNode_ | **getNodeFromIter** | ( Gtk.TreeIter iter ) | gets the HTreeNode from a Gtk.TreeIter, else returns null |


Properties:
| _bool_ | **NodeIconVisible** | if true, nodes have icon |
|:-------|:--------------------|:-------------------------|
| _bool_ | **IsCheckBoxTree**  | if true, nodes have checkbox |
| _bool_ | **Editable**        | if true, nodes are editable |
| _NodeCollection_ | **Nodes**           | the node collection of the tree |
| _HTreeNode[.md](.md)_ | **SelectedNodes**   | gets the selected nodes as an array |
| _HTreeNode_ | **SelectedNode**    | gets the selected node   |


Events:
|_NodeEventHandler_| **NodeExpanded** | - raised after a node is expanded |
|:-----------------|:-----------------|:----------------------------------|
|_NodeEventHandler_| **NodeCollapsed** | - raised after a node is collapsed |
|_NodeEventHandler_| **BeforeNodeExpand** | - raised before a node is expanded |
|_NodeEventHandler_| **BeforeNodeCollapse** | - raised before a node is collapsed |
|_NodeEventHandler_| **NodeEdited**   | - raised when an node's text is changed |

---





# Details #
  * Adding nodes:
```
    //make the tree to show node icons and have checkboxes and to be editable
    treeview.NodeIconVisible = true;
    treeview.IsCheckBoxTree  = true;
    treeview.Editable        = true;

    //add a root element
    HTreeNode root   = new HTreeNode( "root node" );
    //IMPORTANT: before adding childs, add base root elements to the treeview
    treeview.Nodes.Add( root );

    //lets add a few childs
    root.Nodes.Add( new HTreeNode("child1") );

    //lets add a node with icon
    Gdk.Pixbuf icon = GraphUtil.pixbufFromStock("gtk-yes", Gtk.IconSize.Button );
    root.Nodes.Add( new HTreeNode("child2", icon ) );

    //add a node with a different icon when it's expanded
    Gdk.Pixbuf icon_expanded = GraphUtil.pixbufFromStock("gtk-no", Gtk.IconSize.Button );
    root.Nodes.Add( new HTreeNode("child3", icon, icon_expanded) );

    //add a simple node that is checked
    root.Nodes.Add( new HTreeNode("i'm checked!", true ) );
```

  * Removing/changing nodes:
```
   HTreeNode nod_to_be_removed = treeview.Nodes[0];
   treeview.Nodes.Remove( nod_to_be_removed );

   //change a node
   HTreeNode new_node = new HTreeNode( "my new node!" );
   treeview.Nodes[0]  = new_node;
```

  * Get the selected node
```
   HTreeNode node = treeview.SelectedNode;
```

  * Get the selected nodes with multiple selection
```
   treeview.Selection.Mode = Gtk.SelectionMode.Multiple;
   ...
   foreach( HTreeNode node in treeview.SelectedNodes )
   {
       Console.WriteLine("selected node: "+ node.Text );
   }
```

  * Other nodes methods/properties :
| **Method**    | **Description** |
|:--------------|:----------------|
| `HTreeNode.selectAllChilds()` | select all nodes childs   |
| `deselectAllChilds()`         | deselect all nodes childs |
| `IsExpanded`                  | returns true if the nod is expanded |
| `Icon`                        | node's icon               |
| `Text`                        | node's text               |
| `Checked`                     | returns true if the nod is checked |
| `OpenedIcon`                  | node's icon when it's expanded     |
| `ParentNode`                  | node's father or null if it's root node |