using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class PersonUC : UserControl
    {
        manageMain MainWindowUC;
        public PersonUC(manageMain MainWindow)
        {
            MainWindowUC = MainWindow;

            InitializeComponent();
        }

        public void SetPerson(string ReceiveName = "", string ReceiveSurname = "")
        {
            this.NameField.Text = ReceiveName;
            this.SurnameField.Text = ReceiveSurname;
        }

        public Image GetImage()
        {
            return userPic.Image;
        }

        public void SetImage(Image img)
        {
            userPic.Image = img;
        }

        public System.Windows.Forms.TextBox GetPersonName()
        {
            return NameField;
        }

        public System.Windows.Forms.TextBox GetPersonSurame()
        {
            return SurnameField;
        }

        private void userPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();
            openImageDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)| *.* ";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    userPic.Image = new Bitmap(openImageDialog.FileName);
                }
                catch
                {
                    DialogResult result = MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void InitialsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            PersonEdit editWindow = new PersonEdit(MainWindowUC, this, 1, this.NameField.Text, this.SurnameField.Text);
            editWindow.Show();
        }
    }
}
