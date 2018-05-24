using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramUlama
{
    public partial class DiagramUlama : Form
    {
        public DiagramUlama()
        {
            InitializeComponent();
        }

        private Boolean[] makePrimeTable()
        {
            int num, arrSize;
            if (Int32.TryParse(getNum.Text, out num) && num != 0)
            {
                errMsg.Visible = false;

                arrSize = (int)Math.Pow(Math.Ceiling(Math.Sqrt((double)num)), 2) + 1;
                Boolean[] primeArr = new Boolean[arrSize];
                primeArr[0] = true;
                primeArr[1] = true;

                for (int i = 2; i < arrSize; ++i) if (!primeArr[i]) for(int j = i+i; j < arrSize; j += i) primeArr[j] = true;
                return primeArr;
            }
            else errMsg.Visible = true;
            return null;
        }

        private float midOf(float big, float small)
        {
            return (float)(0.5 * (big - small));
        }

        private Bitmap draw(Boolean[] primeArr)
        {
            Graphics g = Graphics.FromImage(new Bitmap(1,1));
            Font fnt = new Font("Arial", 10);
            SizeF sz = new SizeF(0, 0), tmp;

            for (int num = (int)Math.Pow(10, (double)(primeArr.Count().ToString().Length - 1)) * primeArr.Count() > 9 ? Int32.Parse(primeArr.Count().ToString()[0] + "") : 1; num < primeArr.Count(); ++num) if ((tmp = g.MeasureString(num + "", fnt)).Width > sz.Width) sz = tmp;

            double sqr = Math.Sqrt(2);
            int w = (int)Math.Ceiling(sqr * (sz.Width + 4));
            int h = (int)Math.Ceiling(sqr * (sz.Height + 4));
            int marg = 6;
            int arrSizeWH = (int)Math.Sqrt((double)(primeArr.Count())-1);
            Bitmap bmp = new Bitmap(arrSizeWH * (w + marg) + marg, arrSizeWH * (h + marg) + marg);
            g = Graphics.FromImage(bmp);
            //g.Clear(Color.FromArgb(255, 240, 240));
            Brush back = new SolidBrush(Color.Yellow);
            Brush backNotPrim = new SolidBrush(Color.Gray);
            Brush fore = new SolidBrush(Color.Red);
            Pen border = new Pen(Color.Blue, 2);
            Pen line = new Pen(Color.Green, 3);
            float x, y;
            int pos = arrSizeWH - 1, dir = 1;
            int[] tmpGrid = new int[(int)Math.Pow(arrSizeWH, 2)];

            for (int i = primeArr.Count()-1; i > 0; i--)
            {
                x = pos / arrSizeWH * (marg + w) + marg;
                y = pos % arrSizeWH * (marg + h) + marg;
                if(primeArr[i]) g.FillEllipse(backNotPrim, x, y, w, h);
                else g.FillEllipse(back, x, y, w, h);
                g.DrawEllipse(border, x, y, w, h);
                g.DrawString(i + "", fnt, fore, midOf(w, sz.Width) + x, midOf(h, sz.Height) + y);
        
                //g.DrawLine(line, X, Y, X + w * px, Y + h * py);

                tmpGrid[pos] = i;
                if (pos == 0 || pos == arrSizeWH - 1 || pos == arrSizeWH * (arrSizeWH - 1) || pos == Math.Pow(arrSizeWH, 2) - 1 || tmpGrid[pos + dir] != 0) dir = dir == -1 ? -arrSizeWH : dir == -arrSizeWH ? 1 : dir == 1 ? arrSizeWH : -1;
                pos += dir;
            }
            return bmp;
        }

        private void getNum_TextChanged(object sender, EventArgs e)
        {
            if (makePrimeTable() != null) diagramUlamaBox.Image = draw(makePrimeTable());
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (makePrimeTable() != null) diagramUlamaBox.Image = draw(makePrimeTable());
            getNum.Text = scrollBar.Value + "";
        }
    }
}
