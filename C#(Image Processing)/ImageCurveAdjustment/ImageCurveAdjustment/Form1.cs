using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCurveAdjustment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            img2 = new Bitmap(pictureBox1.Image);

            (typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)).SetValue(textBox1, true, null);
        }

        private Bitmap img2;

        private void PaintERS()
        {
            Bitmap img = new Bitmap(img2);
            using (Graphics g = Graphics.FromImage(img))
            {
                // Set the image attribute's color mappings
                
                ImageAttributes attr = new ImageAttributes();

                attr.SetRemapTable(uop1.getRemapTable());

                // Draw using the color map
                Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
                g.DrawImage(img, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)img;
        }

        private void uop1_MouseMove(object sender, MouseEventArgs e)
        {
            PaintERS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < uop1.getRemapTable().Count(); ++i)
                textBox1.AppendText("(" + uop1.getRemapTable()[i].OldColor.R + ":" + uop1.getRemapTable()[i].NewColor.R + ")");
        }

        private void uop1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < uop1.getRemapTable().Count(); ++i)
                textBox1.AppendText("(" + uop1.getRemapTable()[i].OldColor.R + ":" + uop1.getRemapTable()[i].NewColor.R + ")");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uop1.clearTable();
        }
    }
}
