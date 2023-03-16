using State_Design_Pattern;

var canvas = new Canvas();

canvas.CurrentTool = new SelectionTool();
canvas.MouseDown();
canvas.MouseUp();

canvas.CurrentTool = new BrushTool();
canvas.MouseDown();
canvas.MouseUp();