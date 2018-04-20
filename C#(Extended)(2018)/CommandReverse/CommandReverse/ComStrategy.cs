using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStrategy
{
    interface Commander
    {
        string execute();
    }
    interface Jump : Commander
    {
    }
    interface Swim : Commander
    {
    }
    interface Run : Commander
    {
    }
    class Marathon : Run
    {
        public string execute() { return "run marathon"; }
    }
    class Sprint : Run
    {
        public string execute() { return "run sprint"; }
    }
    class ObstacleRun : Run
    {
        public string execute() { return "run throw obstacles"; }
    }
    class LongJump : Jump
    {
        public string execute() { return "jump to long"; }
    }
    class HighJump : Jump
    {
        public string execute() { return "jump to high"; }
    }
    class Crawlik : Swim
    {
        public string execute() { return "swim crawlik style"; }
    }
    class Butterfly : Swim
    {
        public string execute() { return "swim butterfly style"; }
    }
    class Frog : Swim
    {
        public string execute() { return "swim frog style"; }
    }
    class Sportsman
    {
        public string name { get; private set; }
        private Run run;
        private Swim swim;
        private Jump jump;
        public Sportsman(string name,Run run, Swim swim, Jump jump)
        {
            this.name = name;
            this.run = run;
            this.swim = swim;
            this.jump = jump;
        }
        public string executeRun() { return run.execute(); }
        public string executeSwim() { return swim.execute(); }
        public string executeJump() { return jump.execute(); }
    }
}
