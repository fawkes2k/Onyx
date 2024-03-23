using System.Windows.Controls;

namespace Onyx.Objects {
    public abstract class AObject3D {
        public double X, Y, Z;
        public AObject3D() {
            X = Y = Z = 0;
        }
        public AObject3D(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }
        public abstract void Register(Canvas aCanvas);
    }
}
