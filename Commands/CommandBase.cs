using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulmeSharp.Commands
{
    public abstract class CommandBase
    {
        public abstract void Execute(TurtleState state);

        public string CommandName { get; protected set; }

        public CommandBase (string commandName)
        {
            CommandName = commandName;
        }
    }
}
