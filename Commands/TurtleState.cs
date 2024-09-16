using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulmeSharp.Commands
{
    public class TurtleState
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public double DirX { get; set; }
        public double DirY { get; set; }

        private Graphics G;
        private float PixelPerUnit;

        public TurtleState(Graphics g, float pixelPerUnit)
        {
            DirY = -1;
            G = g;
            PixelPerUnit = pixelPerUnit;
        }

        public void SetPos(double x, double y)
        {
            

            float oldX = (float)TransformCoord(X);
            float oldY = (float)TransformCoord(Y);
            float newX = (float)TransformCoord(x);
            float newY = (float)TransformCoord(y);

            X = x;
            Y = y;

            G.DrawLine(Pens.Black, oldX, oldY, newX, newY);
        }

        private double TransformCoord(double coordVal)
        {
            return ((100 + coordVal) * PixelPerUnit);
        }
    }
}
