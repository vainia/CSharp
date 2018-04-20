using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Command
    {
        public string Execute(global::CommandStrategy.Sportsman s)
        {
            return s.name + ": " + execute(s);
        }
        public abstract string execute(global::CommandStrategy.Sportsman s);
    }
    class JumpCommand: Command
    {
        public override string execute(global::CommandStrategy.Sportsman s)
        {
            return s.executeJump();
        }
    }
    class RunCommand : Command
    {
        public override string execute(global::CommandStrategy.Sportsman s)
        {
            return s.executeRun();
        }
    }
    class SwimCommand : Command
    {
        public override string execute(global::CommandStrategy.Sportsman s)
        {
            return s.executeSwim();
        }
    }
    class Training : Command
    {
        public Command[] training { get; private set; }
        public Training(Command[] list)
        {
            this.training = list;
        }
        public override string execute(global::CommandStrategy.Sportsman s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Command cmd in training) sb.Append(cmd.execute(s)).Append(Environment.NewLine);
            return sb.ToString().Trim().Replace(Environment.NewLine," + ");
        }
    }
}
