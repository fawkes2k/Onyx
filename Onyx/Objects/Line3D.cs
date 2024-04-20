using System.Windows.Media;

namespace Onyx.Objects
{
    public class Line3D : AObject3D
    {
        List<Point3D> points;

        public Line3D(double x, double y, double z, double x2, double y2, double z2, int n, Color c, OnyxWorld aWorld) : base(x, y, z, aWorld)
        {
            points = new List<Point3D>();

            for (int i = 0; i < n; i++)
            {
                double px = x + (i / (n - 1.0)) * (x2 - x);
                double py = y + (i / (n - 1.0)) * (y2 - y);
                double pz = z + (i / (n - 1.0)) * (z2 - z);

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