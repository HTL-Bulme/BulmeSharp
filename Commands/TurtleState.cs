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
        public bool Hidden { get; set; }
        private Color LineColor { get; set; }
        private double LineWidth { get; set; }

        private Pen CurrentPen { get; set; }
        private Brush CurrentBrush { get; set; }

        private List<PointF> FillPoints = null;

        private Graphics G;
        private float PixelPerUnit;


        public TurtleState(Graphics g, float pixelPerUnit)
        {
            DirY = -1;
            G = g;
            PixelPerUnit = pixelPerUnit;
            Hidden = false;

            LineColor = Color.Black;
            LineWidth = 1;
            CurrentPen = Pens.Black;
            CurrentBrush = Brushes.Black;
            FillPoints = new List<PointF>();
        }

        public void UpdateLineWidth(double lineWidth)
        {
            LineWidth = lineWidth;
            CurrentPen = new Pen(LineColor, (float)lineWidth);
        }
        public void UpdateLineColor(Color lineColor)
        {
            LineColor = lineColor;
            CurrentPen = new Pen(lineColor, (float)LineWidth);
            CurrentBrush = new SolidBrush(lineColor);
        }

        public void SetPos(double x, double y)
        {

            float oldX = (float)TransformCoord(X);
            float oldY = (float)TransformCoord(Y);
            float newX = (float)TransformCoord(x);
            float newY = (float)TransformCoord(y);

            X = x;
            Y = y;

            if (!Hidden)
            {
                FillPoints.Add(new PointF(newX, newY));
                G.DrawLine(CurrentPen, oldX, oldY, newX, newY);
            }
        }

        public void PaintDot(double diameter)
        {
            if (!Hidden)
            {
                float diameterTransformed = (float)(PixelPerUnit * diameter);
                float xPos = (float)TransformCoord(X) - diameterTransformed / 2;
                float yPos = (float)TransformCoord(Y) - diameterTransformed / 2;
                G.FillEllipse(CurrentBrush, xPos, yPos, diameterTransformed, diameterTransformed);
            }
        }

        private double TransformCoord(double coordVal)
        {
            return ((100 + coordVal) * PixelPerUnit);
        }

        public void BeginFill()
        {
            float oldX = (float)TransformCoord(X);
            float oldY = (float)TransformCoord(Y);

            FillPoints = new List<PointF>();

            if (!Hidden)
            {
                FillPoints.Add(new PointF(oldX, oldY));
            }
        }

        public void EndFill()
        {
            G.FillPolygon(CurrentBrush, FillPoints.ToArray());
        }
    }
}
