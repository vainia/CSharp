using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandTest
{
    public partial class CommandReverseTest : Form
    {
        private Dictionary<string, Command.Command> strategy = new Dictionary<string, Command.Command>();
        public CommandReverseTest()
        {
            InitializeComponent();
            strategy.Add("Jump", new Command.JumpCommand());
            strategy.Add("Run",new Command.RunCommand());
            strategy.Add("Swim",new Command.SwimCommand());
            RebuildAvailable();
        }
        private bool Exists(string name)
        {
            return strategy.ContainsKey(name);
        }
        private Command.Command FindName(string name)
        {
            return strategy[name];
        }
        private void RebuildAvailable()
        {
            ListCmds.Items.Clear();
            foreach(string str in strategy.Keys) ListCmds.Items.Add(str);
            ListCmds.SelectedIndex = 0;
        }
        private void AppendLog(string text)
        {
            Log.AppendText(text + Environment.NewLine);
        }
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string name = (string)ListCmds.SelectedItem;
            Command.Command comand = FindName(name);
            CommandStrategy.Run run = new CommandStrategy.ObstacleRun();
            CommandStrategy.Swim swim = new CommandStrategy.Crawlik();
            CommandStrategy.Jump jump = new CommandStrategy.HighJump();
            string nameSpMan = sportmanName.Text.Trim();
            CommandStrategy.Sportsman man = new CommandStrategy.Sportsman(nameSpMan, run, swim, jump);
            AppendLog(comand.Execute(man));
        }
        private void BtnAppend_Click(object sender, EventArgs e)
        {
            string name = (string)ListCmds.SelectedItem;
            ListMacro.Items.Add(name);
            ListCmds.Focus();
            btnAddVis();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int index = ListMacro.SelectedIndex;
            string name = (string)ListMacro.SelectedItem;
            ListMacro.Items.Remove(name);
            if (index >= ListMacro.Items.Count) index = ListMacro.Items.Count - 1;
            ListMacro.SelectedIndex = index;
            ListMacro.Focus();
            btnAddVis();
        }
        private void btnAddVis()
        {
            string name = MacroName.Text.Trim();
            string sportsmanNm = sportmanName.Text.Trim();
            BtnAdd.Enabled = name.Length > 0 && !Exists(name) && ListMacro.Items.Count > 0;
        }
        private void MacroName_TextChanged(object sender, EventArgs e)
        {
            btnAddVis();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = MacroName.Text.Trim();
            List<Command.Command> lst = new List<Command.Command>();
            foreach(string str in ListMacro.Items) lst.Add(FindName(str));
            Command.Command cmd = new Command.Training(lst.ToArray());
            strategy.Add(name,cmd);
            RebuildAvailable();
            ListCmds.SelectedItem = name;
            ListCmds.Focus();
            btnAddVis();
        }
    }
}
