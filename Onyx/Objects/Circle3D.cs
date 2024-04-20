using System.Windows.Media;

namespace Onyx.Objects;

public class Circle3D : AObject3D
{
    private readonly int _count;
    private readonly List<Point3D> _points = new();

    public Circle3D(double x, double y, double z, double radius, OnyxWorld aWorld, int count, Color color) : base(x, y, z, aWorld)
    {
        _count = count;
        var angleStep = 360.0 / _count;

        for (int i = 0; i < _count; i++)
        {
            var angle = i * angleStep;
            var radian = angle * Math.PI / 180;
            var px = x + radius * Math.Cos(radian);
            var py = y + radius * Math.Sin(radian);

            _points.Add(new Point3D(px, py, z, color, aWorld));
        }
    }

    public override void Render()
    {
        foreach (var point in _points)
        {
            point.Render();
        }
    }
}