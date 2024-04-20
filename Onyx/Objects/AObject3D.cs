namespace Onyx.Objects
{
    public abstract class AObject3D
    {
        public Vector3D V;
        public OnyxWorld world;

        public AObject3D(Vector3D v, OnyxWorld aWorld)
        {
            V = v;
            world = aWorld;
        }

        public abstract void Render();
    }
}