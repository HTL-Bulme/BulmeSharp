using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulmeSharp.Commands
{
    public class BeginFillCommand : CommandBase
    {
        
        public BeginFillCommand() : base("beginFill")
        {
          
        }

        public override void Execute(TurtleState state)
        {
            state.BeginFill();
        }
    }
}
