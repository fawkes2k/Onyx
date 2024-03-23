using Onyx;
using Onyx.Objects;
using System.Windows;

namespace Tester {
    public partial class MainWindow : Window {
        OnyxWorld world;
        public MainWindow() {
            InitializeComponent();
            world = new(GameworldCanvas);
            world.Add(new Point3D(30, 60, 0));
            world.Add(new Point3D(129, 40, 0));
        }
    }
}