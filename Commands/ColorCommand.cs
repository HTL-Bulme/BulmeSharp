using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulmeSharp.Commands
{
    public class SetColorCommand : CommandBase
    {
        public Color LineColor { get; protected set; }
        public SetColorCommand(string color) : base("setColor")
        {
            LineColor = Color.FromName(color);

            if (LineColor.A == 0)
            {
                LineColor = Color.Black;
                Console.WriteLine("Warning: Unknown Color: " + color);
            }
        }

        public override void Execute(TurtleState state)
        {
            state.UpdateLineColor(LineColor);
        }
    }
}
