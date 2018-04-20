using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class MandelbrotShow : Form
    {
        private double Lf=-2.0, Tp=1.0, Zoom=0.75;

        bool MouseInBox = false;
        public MandelbrotShow()
        {
            InitializeComponent();
            EdLf.Text = Lf.ToString("F18");
            EdTp.Text = Tp.ToString("F18");
            EdZoom.Text = Zoom.ToString("F18");
        }
        private static void SetColor(Label lb,bool ok)
        {
            if (ok) lb.ForeColor = SystemColors.ControlText;
            else lb.ForeColor = Color.Red;
        }
        private double MulZoom(double Mul)
        {
            return 3 / (Box.Width * Mul);
        }
        private bool IsOk()
        {
            return
                (LbLf.ForeColor == SystemColors.ControlText) &&
                (LbTp.ForeColor == SystemColors.ControlText) &&
                (LbZoom.ForeColor == SystemColors.ControlText)
            ;
        }
        private void RecalcBitmap()
        {
            if (!IsOk()) return;
            int w = Box.Width, h = Box.Height;
            Bitmap bmp = new Bitmap(w, h);
            Color[,] arr = new Color[h, w];
            double mul = MulZoom(Zoom);
            for (uint y = 0; y < h; ++y)
            {
                double Pi = Tp - y * mul;
                for (uint x = 0; x < w; ++x)
                {
                    double Pr = Lf + x * mul;
                    arr[y, x] = MandelbroatColors.Colors.Theme[MandelbroatCalc.Calc.MandelbroatCalc(Pi, Pr)];
                }
            }
            Box.Tag = MandelbroatArray.Array.ArrToBmp(arr);
            Box.Invalidate();
        }
        private void EdX_TextChanged(object sender, EventArgs e)
        {
            SetColor(LbLf, double.TryParse(EdLf.Text, out Lf));
            RecalcBitmap();
        }

        private void MandelbrotShow_Resize(object sender, EventArgs e)
        {
            RecalcBitmap();
        }

        private void Box_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage((Bitmap)Box.Tag, 0, 0);
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            MouseInBox = true;
            int sy = Box.Height >> 1, sx = Box.Width >> 1;
            double mul = MulZoom(Zoom);
            double Pi = Tp - e.Y * mul;
            double Pr = Lf + e.X * mul;
            if (e.Button == MouseButtons.Left) Zoom *= 2;
            else if (e.Button == MouseButtons.Right) Zoom /= 2;
            else return;
            mul = MulZoom(Zoom);
            EdZoom.Text = string.Format("{0:F4}", Zoom);
            EdTp.Text = string.Format("{0:F14}", Pi + sy * mul);
            EdLf.Text = string.Format("{0:F14}", Pr - sx * mul);
        }

        private void Box_MouseUp(object sender, MouseEventArgs e)
        {
            MouseInBox = false;
        }

        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseInBox)
            {
                double.TryParse(EdTp.Text, out Tp);
                double.TryParse(EdLf.Text, out Lf);
                EdLf.Text = (Lf + ((Box.PointToClient(Cursor.Position).X - (Box.Width / 2)) / 10000)).ToString("F18");
                EdTp.Text = (Tp + ((Box.PointToClient(Cursor.Position).Y - (Box.Height / 2)) / 10000)).ToString("F18");
            }
        }

        private void EdY_TextChanged(object sender, EventArgs e)
        {
            SetColor(LbTp, double.TryParse(EdTp.Text, out Tp));
            RecalcBitmap();
        }

        private void EdScale_TextChanged(object sender, EventArgs e)
        {
            SetColor(LbZoom, double.TryParse(EdZoom.Text, out Zoom));
            RecalcBitmap();
        }
    }
}
