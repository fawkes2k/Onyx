namespace Onyx.Mathematics
{
    public static class Rotator
    {
        public static void RotateX(ref double y, ref double z, double angle)
        {
            double sinTheta = Math.Sin(angle), cosTheta = Math.Cos(angle);

            double py = y * cosTheta + z * sinTheta;
            z = z * cosTheta - y * sinTheta;
            y = py;
        }

        public static void RotateY(ref double x, ref double z, double angle)
        {
            double sinTheta = Math.Sin(angle), cosTheta = Math.Cos(angle);

            double px = x * cosTheta + z * sinTheta;
            z = z * cosTheta - x * sinTheta;
            x = px;
        }

        public static void RotateZ(ref double x, ref double y, double angle)
        {
            double sinTheta = Math.Sin(angle), cosTheta = Math.Cos(angle);

            double px = x * cosTheta + y * sinTheta;
            y = y * cosTheta - x * sinTheta;
            x = px;
        }
    }
}