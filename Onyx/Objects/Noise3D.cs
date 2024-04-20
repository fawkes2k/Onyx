using System.Windows.Media;

namespace Onyx.Objects
{
    public class Noise3D : AObject3D
    {
        readonly List<Point3D> points;

        public Noise3D(Vector3D v1, Vector3D v2, int n, OnyxWorld aWorld) : base(v1, aWorld)
        {
            Random r = new();
            points = new List<Point3D>();

            for (int i = 0; i < n; i++)
            {
                double px = (r.NextDouble() * v2.X) + v1.X, py = (r.NextDouble() * v2.Y) + v1.Y, pz = (r.NextDouble() * v2.Z) + v1.Z;
                byte[] rgb = new byte[3];
                r.NextBytes(rgb);
                Color c = Color.FromRgb(rgb[0], rgb[1], rgb[2]);

                points.Add(new Point3D(new Vector3D(px, py, pz), c, aWorld));
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