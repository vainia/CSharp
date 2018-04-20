using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorTest
{
    public partial class DecoratorTest : Form
    {
        private List<CheckBox> CheckBoxes = new List<CheckBox>();
        public DecoratorTest()
        {
            int i = 0;
            InitializeComponent();
            foreach (string kind in CarList.list()) ModelBox.Items.Add(kind);
            ModelBox.SelectedIndex = 0;
            foreach (string kind in ExtraList.list())
            {
                CheckBox cb = new CheckBox();
                CheckBoxes.Add(cb);
                cb.AutoSize = true;
                cb.Location = new System.Drawing.Point(3, 3 + i * 24);
                cb.Name = kind;
                cb.Size = new System.Drawing.Size(80, 17);
                cb.TabIndex = i++;
                cb.Text = kind;
                cb.UseVisualStyleBackColor = true;
                Panel.Controls.Add(cb);
            }
        }

        private Car addExtraInfo(Car inCar)
        {
            foreach (CheckBox cb in CheckBoxes) if (cb.Checked) inCar = ExtraList.make(cb.Text, inCar);
            return inCar;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car car = CarList.make((string)ModelBox.SelectedItem);
            car = addExtraInfo(car);
            InfoBox.AppendText(car.info() + ": " + car.price() + Environment.NewLine);
        }
    }
}
