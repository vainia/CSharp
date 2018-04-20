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
    public partial class PersonEdit : Form
    {
        manageMain MainForm;
        PersonUC PersonNew;

        PersonUC PersonGot;

        int mode;

        public PersonEdit(manageMain mainWindow, PersonUC RecievePerson = null, int m = 0, string ReceiveName="Wpisz imie", string ReceiveSurname="Wpisz nazwisko")
        {
            InitializeComponent();

            this.personUCedit.GetPersonSurame().Enabled = true;
            this.personUCedit.GetPersonName().Enabled = true;

            MainForm = mainWindow;

            PersonGot = RecievePerson;

            mode = m;

            this.personUCedit.SetPerson(ReceiveName, ReceiveSurname);
        }

        private void EditDeclineBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAcceptBtn_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                PersonNew = new UserControlTest.PersonUC(MainForm);
                PersonNew.Dock = System.Windows.Forms.DockStyle.Top;
                PersonNew.Location = new System.Drawing.Point(0, 0);
                PersonNew.Name = "Person" + CountControls(MainForm.getMainPanel()) + 1;
                PersonNew.Size = new System.Drawing.Size(606, 177);
                PersonNew.TabIndex = 0;

                PersonNew.SetPerson(this.personUCedit.GetPersonName().Text, this.personUCedit.GetPersonSurame().Text);

                PersonNew.SetImage(this.personUCedit.GetImage());

                PersonNew.GetPersonSurame().Enabled = false;
                PersonNew.GetPersonName().Enabled = false;

                MainForm.getMainPanel().Controls.Add(PersonNew);
            }
            else
            {
                PersonGot.SetPerson(this.personUCedit.GetPersonName().Text, this.personUCedit.GetPersonSurame().Text);

                PersonGot.SetImage(this.personUCedit.GetImage());
            }

            this.Close();
        }

        private int CountControls(Control top)
        {
            int cnt = 1;
            foreach (Control c in top.Controls)
                cnt += CountControls(c);
            return cnt;
        }
    }
}
