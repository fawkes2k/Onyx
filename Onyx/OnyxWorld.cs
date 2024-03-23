using Onyx.Objects;
using System.Windows.Controls;

namespace Onyx
{
    public class OnyxWorld {
        Canvas canvas;
        List<AObject3D> objects3D;

        public OnyxWorld(Canvas aCanvas) {
            canvas = aCanvas;
            objects3D = new List<AObject3D>();
        }

        public void Add(AObject3D aObject3D) {
            objects3D.Add(aObject3D);
            aObject3D.Register(canvas);
        }
    }
}