using System.Windows.Media;

namespace Onyx.Objects;

public class LissajousCurve3D : AObject3D
{
    private readonly int _count;
    private readonly List<Point3D> _points = new();

    public LissajousCurve3D(double x, double y, double z, double amplitudeX, double amplitudeY, double amplitudeZ,
        int frequencyX, int frequencyY, int frequencyZ, double phase, OnyxWorld aWorld, int count,
        Color color) : base(x, y, z, aWorld)
    {
        _count = count;
        var angleStep = 360.0 / _count;

        for (int i = 0; i < _count; i++)
        {
            var radian = i * angleStep * Math.PI / 180;
            var px = x + amplitudeX * Math.Sin(frequencyX * radian + phase);
            var py = y + amplitudeY * Math.Sin(frequencyY * radian);
            var pz = z + amplitudeZ * Math.Sin(frequencyZ * radian);

            _points.Add(new Point3D(px, py, pz, color, aWorld));
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