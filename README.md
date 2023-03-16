# State Design Pattern

```sh
   Useful when a method behave differently depending on the state 
```

If we have a program like photoshop, then we need  the canvas to behave differently based on the tool that is selected.

So, we have to write alot of if-else or switch block to check the type of the tool that is selected.

Later if we want to add new tool, we must go to these functions to add if-else block to check the new tool


## Example
```sh
public void MouseUp(){
    if(currentTool == ToolType.SELECTION)
    {
        //Do selection mouse down logic
    }
    if(currentTool == ToolType.BRUSH)
    {
        //Do brush mouse down logic
    }
}
public void MouseDown(){
    if(currentTool == ToolType.SELECTION)
    {
        //Do selection mouse up logic
    }
    if(currentTool == ToolType.BRUSH)
    {
        //Do brush mouse up logic
    }
}
```
## Solution
Create an abstract class or interface that contains the bahvior methods and make the concrete types inherits from it
### Example
```sh
public interface ITool
{
    void MouseDown();
    void MouseUp();
}

public class SelectionTool : ITool
{
    public void MouseDown()
    {
        Console.WriteLine("Selection Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw Dashed Rectangle");
    }
}
public class BrushTool : ITool
{
    public void MouseDown()
    {
        Console.WriteLine("Brush Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw A Line");
    }
}
```






