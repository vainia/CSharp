using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class manageMain : Form
    {
        public manageMain()
        {
            InitializeComponent();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            PersonEdit editWindow = new PersonEdit(this);
            editWindow.Show();
        }
    }
}
