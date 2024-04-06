using Onyx.Objects;
using System.Windows.Controls;

namespace Onyx {
    public class OnyxWorld {
        public Canvas canvas;
        public List<AObject3D> objects3D;

        public OnyxWorld(Canvas aCanvas) {
            canvas = aCanvas;
            objects3D = new List<AObject3D>();
        }

        public void Add(AObject3D aObject3D) { objects3D.Add(aObject3D); }
        public void Render() { foreach (AObject3D obj in objects3D) obj.Render(); }
    }
}