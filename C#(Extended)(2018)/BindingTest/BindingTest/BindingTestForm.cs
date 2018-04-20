using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingTest
{
    public partial class BindingMain : Form
    {
        private BindingList<Person> PersonList = new BindingList<Person>();

        public BindingMain()
        {
            InitializeComponent();
            listBox.DataSource = PersonList;
            PersonList.Add(new Person());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person(nameBoxLeft.Text, surnameBoxLeft.Text);
            PersonList.Add(p);
            listBox.SelectedItem = p;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Person person = (Person)listBox.SelectedItem;
            if (person != null)
            {
                PersonList.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Person person = (Person)listBox.SelectedItem;

            nameBoxLeft.DataBindings.Clear();
            nameBoxRight.DataBindings.Clear();
            surnameBoxLeft.DataBindings.Clear();
            surnameBoxRight.DataBindings.Clear();

            if (person != null)
            {
                nameBoxLeft.DataBindings.Add("Text", person, "PersonName", false, DataSourceUpdateMode.OnPropertyChanged);
                nameBoxRight.DataBindings.Add("Text", person, "PersonName", false, DataSourceUpdateMode.OnPropertyChanged);
                surnameBoxLeft.DataBindings.Add("Text", person, "PersonSurname", false, DataSourceUpdateMode.OnPropertyChanged);
                surnameBoxRight.DataBindings.Add("Text", person, "PersonSurname", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
    }
}