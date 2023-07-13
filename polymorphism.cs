public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        // Draw a circle on the screen
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        // Draw a rectangle on the screen
    }
}

public class Renderer {
	public void DrawShapes(List<Shape> shapes)
	{
		foreach (var shape in shapes)
		{
			shape.Draw();
		}
	}
}
