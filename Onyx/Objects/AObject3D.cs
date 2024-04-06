namespace Onyx.Objects {
    public abstract class AObject3D {
        public double X, Y, Z;
        protected OnyxWorld world;

        public AObject3D(double x, double y, double z, OnyxWorld aWorld) {
            X = x;
            Y = y;
            Z = z;

            world = aWorld;
        }

        public abstract void Render();
    }
}