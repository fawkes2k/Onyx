﻿using Onyx.Mathematics;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Onyx.Objects
{
    public class Point3D : AObject3D
    {
        readonly Ellipse ellipse;
        public Vector3D VV;
        public Color color;

        public Point3D(Vector3D v, Color point_color, OnyxWorld aWorld) : base(v, aWorld)
        {
            VV = v;
            color = point_color;
            ellipse = new Ellipse
            {
                Fill = Brushes.DarkBlue,
                Width = 5,
                Height = 5
            };
            aWorld.canvas.Children.Add(ellipse);
        }

        double ang = 0.0;
        public override void Render()
        {
            double px = VV.X, py = VV.Y, pz = VV.Z;

            Rotator.RotateX(ref py, ref pz, ang);
            Rotator.RotateY(ref px, ref pz, ang);
            ang += 0.03;
            pz += 200.0;
            
            double x = 250.0 * px / pz, y = 250.0 * py / pz;
            Canvas.SetLeft(ellipse, x + 0.5 * world.canvas.ActualWidth);
            Canvas.SetTop(ellipse, y + 0.5 * world.canvas.ActualHeight);
            ellipse.Fill = new SolidColorBrush(color);
        }
    }
}