using Onyx;
using Onyx.Objects;
using System;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Media;

namespace Tester
{
    public partial class MainWindow : Window
    {
        readonly OnyxWorld world;

        public MainWindow()
        {
            InitializeComponent();

            world = new OnyxWorld(GameworldCanvas);
            world.Add(new Line3D(new Vector3D(0, 0, 0), new Vector3D(50, 50, 50), 100, Color.FromRgb(0, 0, 0), world));
            // world.Add(new Noise3D(new Vector3D(0, 0, 0), new Vector3D(50, 100, 200), 100, world));

            DispatcherTimer timer = new()
            {
                Interval = TimeSpan.FromMilliseconds(10)
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            world.Render();
        }
    }
}