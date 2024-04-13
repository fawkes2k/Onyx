namespace Onyx.Mathematics {
    public static class Rotator {
        public static void RotateX(ref double y, ref double z, double angle) {
            var sinTheta = Math.Sin(angle);
            var cosTheta = Math.Cos(angle);

            var py = y * cosTheta + z * sinTheta;
            z = z * cosTheta - y * sinTheta;
            y = py;
        }

        public static void RotateY(ref double x, ref double z, double angle) {
            var sinTheta = Math.Sin(angle);
            var cosTheta = Math.Cos(angle);

            var px = x * cosTheta + z * sinTheta;
            z = z * cosTheta - x * sinTheta;
            x = px;
        }

        public static void RotateZ(ref double x, ref double y, double angle) {
            var sinTheta = Math.Sin(angle);
            var cosTheta = Math.Cos(angle);

            var px = x * cosTheta + y * sinTheta;
            y = y * cosTheta - x * sinTheta;
            x = px;
        }
    }
}