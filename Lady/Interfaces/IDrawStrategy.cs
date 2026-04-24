using System.Drawing.Drawing2D;

namespace Lady.Interfaces;

public interface IDrawStrategy
{
    public void Execute(Graphics g, GraphicsPath path);
}