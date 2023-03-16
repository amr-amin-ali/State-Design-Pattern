namespace State_Design_Pattern
{
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
}
