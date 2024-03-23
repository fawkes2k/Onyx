using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Onyx.Objects {
    public class Point3D : AObject3D {
        Ellipse ellipse;

        public Point3D(double x, double y, double z) : base(x, y, z) {
            ellipse = new Ellipse {
                Fill = Brushes.DarkBlue,
                Width = 5,
                Height = 5
            };
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
        }

        public override void Register(Canvas aCanvas) {
            aCanvas.Children.Add(ellipse);
        }
    }
}