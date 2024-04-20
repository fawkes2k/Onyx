using System.Windows.Media;

namespace Onyx.Objects
{
    public class Noise3D : AObject3D
    {
        readonly List<Point3D> points;

        public Noise3D(double x, double y, double z, double x2, double y2, double z2, int n, OnyxWorld aWorld) : base(x, y, z, aWorld)
        {
            Random r = new();
            points = new List<Point3D>();

            for (int i = 0; i < n; i++)
            {
                double px = (r.NextDouble() * x2) + x, py = (r.NextDouble() * y2) + y, pz = (r.NextDouble() * z2) + z;
                byte[] rgb = new byte[3];
                r.NextBytes(rgb);
                Color c = Color.FromRgb(rgb[0], rgb[1], rgb[2]);

                points.Add(new Point3D(px, py, pz, c, aWorld));
            }
        }

        public override void Render()
        {
            foreach (var point in points)
            {
                point.Render();
            }
        }
    }
}