using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulmeSharp.Commands
{
    public class ForwardCommand: CommandBase
    {
        public double Distance { get; protected set; }
        public ForwardCommand(double distance): base("fd")
        {
            Distance = distance;
        }

        public override void Execute(TurtleState state)
        {
            state.X += Distance * state.DirX;
            state.Y += Distance * state.DirY;
        }
    }
}
