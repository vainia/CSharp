using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harmCalc
{
    delegate void DelegateAppendText(string value);
    public partial class harmCalc : Form
    {
        public harmCalc()
        {
            InitializeComponent();
        }

        private void appendText(string value)
        {
            lbResult.Text = lbResult.Text + Environment.NewLine + value;
            //btnCalc.Enabled = true;
        }

        private void invokeAppendText(string value)
        {
            Invoke(new DelegateAppendText(appendText), new object[] { value });
        }

        static private double harmonicSeq(uint n)
        {
            double res = 0;
            for (int i = 1; i <= n; ++i)
            {
                res += 1.0 / i;
            }
            return res;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;

            //btnCalc.Enabled = false;
            worker.RunWorkerAsync(edCount.Text);
            edCount.Focus();
            edCount.SelectAll();
        }

        private void btnDie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string text = (string)e.Argument;
            uint cnt = 0;

            if (UInt32.TryParse(text, out cnt))
            {
                invokeAppendText(text + ": " + harmCalc.harmonicSeq(cnt).ToString());
            }
            else invokeAppendText(text + ": ?");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbResult.Text = "Wyniki";
        }
    }
}
