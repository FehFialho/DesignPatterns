using System.Drawing.Drawing2D;

namespace Lady.Interfaces;

public abstract class IShape
{
    public abstract GraphicsPath GetGeometry();
}