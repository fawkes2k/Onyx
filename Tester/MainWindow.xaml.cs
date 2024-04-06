using Onyx;
using Onyx.Objects;
using System;
using System.Windows;
using System.Windows.Threading;

namespace Tester {
    public partial class MainWindow : Window {
        readonly OnyxWorld world;

        public MainWindow() {
            InitializeComponent();

            world = new OnyxWorld(GameworldCanvas);

            world.Add(new Point3D(50, 50, 50, world));
            world.Add(new Point3D(-50, 50, 50, world));
            world.Add(new Point3D(50, 50, -50, world));
            world.Add(new Point3D(-50, 50, -50, world));
            world.Add(new Point3D(50, -50, 50, world));
            world.Add(new Point3D(-50, -50, 50, world));
            world.Add(new Point3D(50, -50, -50, world));
            world.Add(new Point3D(-50, -50, -50, world));

            for (double i = -80.0; i < 81; i += 10.0) world.Add(new Point3D(i, i, 0, world));

            DispatcherTimer timer = new() { Interval = TimeSpan.FromMilliseconds(10) };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e) { world.Render(); }
    }
}