using System.Windows.Media;

namespace Onyx.Objects;

// Pronunciation: /ˈlɪsəʒuː/

public class LissajousCurve3D : AObject3D
{
    private readonly int _count;
    private readonly List<Point3D> _points = new();

    public LissajousCurve3D(Vector3D v, Vector3D amplitude, Vector3D frequency, double phase, OnyxWorld aWorld, int count, Color color) : base(v, aWorld)
    {
        _count = count;
        var angleStep = 360.0 / _count;

        for (int i = 0; i < _count; i++)
        {
            var radian = i * angleStep * Math.PI / 180;
            var px = v.X + amplitude.X * Math.Sin(frequency.X * radian + phase);
            var py = v.Y + amplitude.Y * Math.Sin(frequency.Y * radian);
            var pz = v.Z + amplitude.Z * Math.Sin(frequency.Z * radian);

            _points.Add(new Point3D(new Vector3D(px, py, pz), color, aWorld));
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