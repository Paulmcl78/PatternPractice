using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Commands
{
    abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
