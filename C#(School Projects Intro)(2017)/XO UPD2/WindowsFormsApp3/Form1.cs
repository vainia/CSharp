using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class mainWindow : Form
    {
        public TextBox err;
        public ComboBox putInW;
        public ComboBox putInH;
        public Icon newIcon;

        Button leftClk;
        Button rightClk;
        Button resume;

        public mainWindow()
        {
            MyIni();
        }

        private void MyIni()
        {
            Bitmap ico;
            ico = new Bitmap(5, 5);
            Pen blackPen = new Pen(Color.Black, 5 / 3);
            Graphics g = Graphics.FromImage(ico);
            g.DrawRectangle(blackPen, 0, 0, 5, 5);
            IntPtr Hicon = ico.GetHicon();
            newIcon = Icon.FromHandle(Hicon);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = newIcon;
            this.Text = "TIC TAC TOE 2017";
            this.BackColor = Color.Beige;
            this.Size = new Size(300, 142);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            rightClk = new Button();
            this.Controls.Add(rightClk);
            rightClk.Location = new Point(this.Size.Width - rightClk.Size.Width - 20, this.Size.Height - rightClk.Size.Height - 42);
            rightClk.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Bottom);
            rightClk.BackColor = Color.Transparent;
            rightClk.Text = "Start";
            rightClk.FlatStyle = FlatStyle.Flat;
            rightClk.Click += MyOpen;

            leftClk = new Button();
            this.Controls.Add(leftClk);
            leftClk.Location = new Point(rightClk.Location.X - rightClk.Size.Width - 5, rightClk.Location.Y);
            leftClk.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Bottom);
            leftClk.BackColor = Color.Transparent;
            leftClk.Text = "Exit";
            leftClk.FlatStyle = FlatStyle.Flat;
            leftClk.Click += MyClose;

            resume = new Button();
            this.Controls.Add(resume);
            resume.Location = new Point(leftClk.Location.X - leftClk.Size.Width - 5, rightClk.Location.Y);
            resume.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Bottom);
            resume.BackColor = Color.Transparent;
            resume.Text = "Continue";
            resume.FlatStyle = FlatStyle.Flat;
            resume.Click += MyResume;

            putInW = new ComboBox();
            this.Controls.Add(putInW);
            putInW.Location = new Point(2, 1);
            putInW.Name = "putInH";
            putInW.Size = new Size(this.Size.Width - 20, 75);
            putInW.FlatStyle = FlatStyle.Flat;
            putInW.ForeColor = Color.Beige;
            putInW.BackColor = Color.Black;
            putInW.DropDownHeight = this.Size.Height - 3 * putInW.Size.Height + 5;
            putInW.Text = "SELECT THE COUNT OF HORIZONTAL BLOCKS";

            putInH = new ComboBox();
            this.Controls.Add(putInH);
            putInH.Location = new Point(2, putInW.Size.Height + 5);
            putInH.Name = "putInW";
            putInH.Size = new Size(putInW.Size.Width, putInW.Size.Height);
            putInH.FlatStyle = FlatStyle.Flat;
            putInH.ForeColor = Color.Beige;
            putInH.BackColor = Color.Black;
            putInH.DropDownHeight = this.Size.Height - 3 * putInH.Location.Y - 5;
            putInH.Text = "SELECT THE COUNT OF VERTICAL BLOCKS";
            
            for (int i = 3; i <= 20; ++i)
            {
                putInW.Items.Add(i);
                putInH.Items.Add(i);
            }
        }

        private void MyOpen(object s, EventArgs e)
        {
            int cntW, cntH;
            if (!Int32.TryParse(putInW.Text, out cntW)) cntW = 3;
            if (!Int32.TryParse(putInH.Text, out cntH)) cntH = 3;
            int enter = Math.Abs(cntW - cntH);
            if (enter <= 5)
            {
                gameXO gameWin = new gameXO(this, cntW, cntH);
                gameWin.Show();
                this.Hide();
            }
            else
            {
                err = new TextBox();
                this.Controls.Add(err);
                err.Location = new Point(2, putInH.Height + putInW.Height + 10);
                err.Multiline = false;
                err.Name = "err";
                err.BorderStyle = BorderStyle.FixedSingle;
                err.ReadOnly = true;
                err.ScrollBars = ScrollBars.None;
                err.Size = new Size(this.Size.Width - 20, 75);
                err.AppendText("Count difference of numbers must be less than 5");
                putInH.SelectedIndex = 0;
                putInW.SelectedIndex = 0;
            }
        }

        private void MyClose(object s, EventArgs e)
        {
            Close();
        }
    
        private void MyResume(object s, EventArgs e)
        {
            string[] gameInfo = File.ReadAllLines(@"C:\Windows\Temp\gameStats.txt");



            MessageBox.Show(String.Format("{0}", gameInfo[1]), "TRACKINFO", MessageBoxButtons.OK);
        }
    }
}
