using System.Windows.Controls;
using System.Windows.Shapes;

namespace Onyx.Objects {
    public class Point3D : AObject3D {
        readonly Ellipse ellipse;

        public Point3D(double x, double y, double z, OnyxWorld aWorld) : base(x, y, z, aWorld) {
            ellipse = new Ellipse
            {
                Fill = System.Windows.Media.Brushes.DarkBlue,
                Width = 5,
                Height = 5
            };
            aWorld.canvas.Children.Add(ellipse);
        }

        public static void RotateX(ref double y, ref double z, double angle) {
            var sinTheta = Math.Sin(angle);
            var cosTheta = Math.Cos(angle);

            var px = y * cosTheta + z * sinTheta;
            z = z * cosTheta - y * sinTheta;
            y = px;
        }

        public static void RotateY(ref double x, ref double z, double angle) {
            var sinTheta = Math.Sin(angle);
            var cosTheta = Math.Cos(angle);

            var px = x * cosTheta + z * sinTheta;
            z = z * cosTheta - x * sinTheta;
            x = px;
        }

        double ang = 0.0;
        public override void Render() {
            var px = X;
            var py = Y;
            var pz = Z;

            RotateX(ref py, ref pz, ang);
            RotateY(ref px, ref pz, ang);
            ang += 0.03;
            pz += 200.0;
            
            var x = 250.0 * px / pz;
            var y = 250.0 * py / pz;

            Canvas.SetLeft(ellipse, x + 0.5 * world.canvas.ActualWidth);
            Canvas.SetTop(ellipse, y + 0.5 * world.canvas.ActualHeight);
        }
    }
}