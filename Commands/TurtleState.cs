using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulmeSharp.Commands
{
    public class TurtleState
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DirX { get; set; }
        public double DirY { get; set; }

        public TurtleState()
        {
            DirY = 1;
        }
    }
}
