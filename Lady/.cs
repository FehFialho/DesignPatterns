using System.Drawing.Drawing2D;
using Lady.Interfaces;

public class Empty : IDrawStrategy
{
    public void Execute(Graphics g, GraphicsPath path)
    {
        var pen = new Pen(Color.Black, 2);
        g.DrawPath(pen, path);
    }
}
public class Fill : IDrawStrategy
{
    public void Execute(Graphics g, GraphicsPath path)
    {
        var brush = new SolidBrush(Color.SkyBlue);
        g.FillPath(brush, path);
    }
}




public class Circle(int x, int y, int ray = 50) : IShape
{
    private int X=x, Y=y, Ray=ray;
    public override GraphicsPath GetGeometry()
    {
        var path = new GraphicsPath();
        path.AddEllipse(X - Ray, Y - Ray, Ray * 2, Ray * 2); 
        return path;
    }
}

public class Square(int x, int y, int size = 50) : IShape
{
    private int X=x, Y=y, Size=size;
    public override GraphicsPath GetGeometry()
    {
        var path = new GraphicsPath();
        path.AddRectangle(new Rectangle(X - Size/2, Y - Size/2, Size, Size)); 
        return path;
    }
}
