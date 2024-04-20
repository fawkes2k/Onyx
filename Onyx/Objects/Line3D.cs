using System.Windows.Media;

namespace Onyx.Objects
{
    public class Line3D : AObject3D
    {
        readonly List<Point3D> points;

        public Line3D(Vector3D v1, Vector3D v2, int n, Color c, OnyxWorld aWorld) : base(v1, aWorld)
        {
            points = new List<Point3D>();

            for (int i = 0; i < n; i++)
            {
                Vector3D p = v1 + (i / (n - 1.0)) * (v2 - v1);
                points.Add(new Point3D(p, c, aWorld));
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