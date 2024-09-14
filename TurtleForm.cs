using BulmeSharp.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulmeSharp
{
    public partial class TurtleForm : Form
    {
        private List<CommandBase> Commands;
        public TurtleForm()
        {
            Commands = new List<CommandBase>();
            InitializeComponent();
        }

        public void AddCommand(CommandBase cmd)
        {
            Commands.Add(cmd);
        }

        private void TurtleForm_Shown(object sender, EventArgs e)
        {
            var screen = Screen.FromControl(this);

            var minLength = Math.Min(screen.Bounds.Width, screen.Bounds.Height);

            this.Width = (int)(minLength * 0.8);
            this.Height = (int)(minLength * 0.8);
            this.Left = (screen.Bounds.Width - this.Width) / 2;
            this.Top = (screen.Bounds.Height - this.Height) / 2;

        }

        private void TurtleForm_Paint(object sender, PaintEventArgs e)
        {
            var minLength = Math.Min(e.ClipRectangle.Width, e.ClipRectangle.Height);
            float pixelPerUnit = minLength / 200.0f;

            DrawCoordSys(e, pixelPerUnit);
            DrawTurtle(e.Graphics, -40, -59, 1, 0, 7, pixelPerUnit);

        }

        private void DrawCoordSys(PaintEventArgs e, float pixelPerUnit)
        {
            float center = 100 * pixelPerUnit;
            Graphics g = e.Graphics;
            g.DrawLine(Pens.LightGray, 0, center, e.ClipRectangle.Width, center);
            g.DrawLine(Pens.LightGray, center, 0, center, e.ClipRectangle.Height);
            g.DrawString("(0/0)", SystemFonts.CaptionFont, Brushes.Gray, center, center);

            g.DrawString("50", SystemFonts.CaptionFont, Brushes.Gray, center * 1.5f, center);
            g.DrawString("-50", SystemFonts.CaptionFont, Brushes.Gray, center * .5f, center);
            g.DrawString("50", SystemFonts.CaptionFont, Brushes.Gray, center, center * .5f);
            g.DrawString("-50", SystemFonts.CaptionFont, Brushes.Gray, center, center * 1.5f);

            g.DrawLine(Pens.LightGray, center * .5f, center - pixelPerUnit, center * .5f, center + pixelPerUnit);
            g.DrawLine(Pens.LightGray, center * 1.5f, center - pixelPerUnit, center * 1.5f, center + pixelPerUnit);

            g.DrawLine(Pens.LightGray, center - pixelPerUnit, center * .5f, center + pixelPerUnit, center * .5f);
            g.DrawLine(Pens.LightGray, center - pixelPerUnit, center * 1.5f, center + pixelPerUnit, center * 1.5f);

            g.DrawString("(X-Achse)", SystemFonts.CaptionFont, Brushes.Gray, center * 0.01f, center);
            g.DrawString("(Y-Achse)", SystemFonts.CaptionFont, Brushes.Gray, center, center * 0.01f);
        }

        private void DrawTurtle(Graphics g, double x, double y, double dirX, double dirY, int size, float pixelPerUnit)
        {
            x += 100;
            y += 100;

            x *= pixelPerUnit;
            y *= pixelPerUnit;

            
            float radius = size * pixelPerUnit * 0.1f;

            // Rotation angle in degrees
            float rotationAngle = (float)(Math.Atan2(dirY, dirX) * 180 / Math.PI);

            // Ellipse parameters (relative to rotation point)
            float ellipseWidth = size * 0.75f * pixelPerUnit;
            float ellipseHeight = size * pixelPerUnit;
            float ellipseX = -ellipseWidth / 2; // Center the ellipse horizontally around the rotation point
            float ellipseY = -ellipseHeight / 2; // Center the ellipse vertically around the rotation point

            // Apply transformations: translate to the rotation point, rotate, then translate back
            g.TranslateTransform((float)x, (float)y);
            g.RotateTransform(rotationAngle);

            g.FillEllipse(Brushes.DarkGreen,
                (float)-radius * 2,
                (float)- radius*8,
                radius * 4, radius * 4);

            g.FillEllipse(Brushes.DarkGreen,
                (float)-radius * 1.5f + radius * 4,
                (float)-radius * 1.5f + radius * 3,
                radius * 3, radius * 3);

            g.FillEllipse(Brushes.DarkGreen,
                (float)-radius * 1.5f + radius * 4,
                (float)-radius * 1.5f - radius * 3,
                radius * 3, radius * 3);

            g.FillEllipse(Brushes.DarkGreen,
                (float)-radius * 1.5f - radius * 4,
                (float)-radius * 1.5f + radius * 3,
                radius * 3, radius * 3);

            g.FillEllipse(Brushes.DarkGreen,
                (float)-radius * 1.5f - radius * 4,
                (float)-radius * 1.5f - radius * 3,
                radius * 3, radius * 3);


            // Draw the ellipse (which is now rotated around rotationX, rotationY)
            g.FillEllipse(Brushes.Green, ellipseX, ellipseY, ellipseWidth, ellipseHeight);
            g.DrawEllipse(Pens.DarkGreen, ellipseX, ellipseY, ellipseWidth, ellipseHeight);

            // Reset transformations to avoid affecting other drawings
            g.ResetTransform();

        }

    }
}
