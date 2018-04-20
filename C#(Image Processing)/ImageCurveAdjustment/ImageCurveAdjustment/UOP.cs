using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageCurveAdjustment
{
    public partial class UOP : UserControl
    {
        private List<Point> curvePoints = new List<Point>();
        private Boolean mouseEnter = false;
        private int pointNumber;
        private int pointNumberToRemove;
        private ColorMap[] remapTable = new ColorMap[256];
        private Methods method = Methods.Adjustment;
        private int countOfDots = 16; // 16 recomended.

        private enum Methods
        {
            Adjustment,
            Gamma,
            Contrast,
            Brightness
        }

        public ColorMap[] getRemapTable()
        {
            return remapTable;
        }

        public void clearTable()
        {
            curvePoints.Clear();
            initializePoints();
            this.Refresh();
            label.Text = "" + 0;
        }

        private void refreshRemapTable()
        {
            int Sx = 0, Sy = 0, C, oldColor, newColor;
            for (int j = 0; j < curvePoints.Count; ++j)
            {
                C = curvePoints[j].X - Sx;

                if (C != 0 && C != curvePoints.Count - 1)
                    for (int i = 0; i <= C; ++i)
                    {
                        oldColor = (int)Math.Round((Sx + (i * (curvePoints[j].X - Sx) / (float)C)), MidpointRounding.AwayFromZero);
                        newColor = 255 - (int)Math.Round((Sy + (i * (curvePoints[j].Y - Sy) / (float)C)), MidpointRounding.AwayFromZero);

                        remapTable[oldColor] = new ColorMap();
                        remapTable[oldColor].OldColor = Color.FromArgb(oldColor, oldColor, oldColor);
                        remapTable[oldColor].NewColor = Color.FromArgb(newColor, newColor, newColor);
                    }

                Sx = curvePoints[j].X;
                Sy = curvePoints[j].Y;
            }
        }

        public UOP()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true); // Remove annoying flickering.

            initializePoints();

            InitializeComponent();
        }

        private void UOP_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Drawing quality.

            switch (method)
            {
                case Methods.Adjustment:
                    drawCurve(e);
                    drawSquares(e);
                    refreshRemapTable();
                    break;
                case Methods.Brightness:
                    break;
                case Methods.Contrast:
                    break;
                case Methods.Gamma:
                    break;
                default:
                    break;
            }
        }

        private void drawSquares(PaintEventArgs e) // Draw rectangles to screen.
        {
            List<Rectangle> rectsPoints = new List<Rectangle>();
            foreach (Point curvePoint in curvePoints.Where((a, b) => curvePoints.Count - 1 != b && b != 0 )) // Argument a is the item itself, while argument b is the index of the item.
            {
                rectsPoints.Add(new Rectangle(curvePoint.X - 2, curvePoint.Y - 2, 4, 4));
            }
            if(rectsPoints.Count > 0) e.Graphics.DrawRectangles(new Pen(Color.Black, 1), rectsPoints.ToArray()); 
        }

        private void drawCurve(PaintEventArgs e)
        {
            e.Graphics.DrawLines(new Pen(Color.Black, 1), curvePoints.ToArray()); // Draw lines between original points to screen.
        }
    
        private void initializePoints() // Create points that define curve.
        {
            curvePoints.Add(new Point(0, 255));
            curvePoints.Add(new Point(255, 0));
        }

        private int changeTableCheck(Point newPointPosition) // Check if mouse down on existing point.
        {
            for (int i = 1; i < curvePoints.Count - 1; ++i)
                if (curvePoints[i].X + 2 >= newPointPosition.X && curvePoints[i].X - 2 <= newPointPosition.X && curvePoints[i].Y + 2 >= newPointPosition.Y && curvePoints[i].Y - 2 <= newPointPosition.Y)
                    return i;
            return -1;
        }

        private int changeTableAdd(Point newPointPosition) // Add new point to existing curve.
        {
            if (curvePoints.Count < countOfDots + 2)
            {
                for (int i = 1; i < curvePoints.Count; ++i)
                    if (curvePoints[i].X > newPointPosition.X)
                    {
                        curvePoints.Insert(i, newPointPosition);
                        this.Refresh();
                        return i;
                    }
            }
            return -1;
        }

        private void changeTableFilled(Point newPointPosition) // Change existing point position on curve.
        {
            if (pointNumber == 1) // If selected point is 2d after left corner.
            {
                if (newPointPosition.X >= 0 && newPointPosition.X < curvePoints[pointNumber + 1].X || newPointPosition.X == 255 && curvePoints.Count == 3)
                {
                    curvePoints[pointNumber] = newPointPosition;
                }
                else if (newPointPosition.X >= curvePoints[pointNumber + 1].X)
                {
                    curvePoints[pointNumber] = curvePoints[pointNumber + 1];
                }
            }
            else if (pointNumber == curvePoints.Count - 2) // If selected point is 2d before right corner.
            {
                if (newPointPosition.X > curvePoints[pointNumber - 1].X && newPointPosition.X <= 255 || newPointPosition.X == 0 && curvePoints.Count == 3)
                {
                    curvePoints[pointNumber] = newPointPosition;
                }
                else if (newPointPosition.X <= curvePoints[pointNumber - 1].X)
                {
                    curvePoints[pointNumber] = curvePoints[pointNumber - 1];
                }
            }
            else if (pointNumber > 1 && pointNumber < curvePoints.Count - 1) // If selected point placed between corner points
            {
                if (newPointPosition.X > curvePoints[pointNumber - 1].X && newPointPosition.X < curvePoints[pointNumber + 1].X)
                {
                    curvePoints[pointNumber] = newPointPosition;
                }
                else if (newPointPosition.X <= curvePoints[pointNumber - 1].X)
                {
                    curvePoints[pointNumber] = curvePoints[pointNumber - 1];
                }
                else if (newPointPosition.X >= curvePoints[pointNumber + 1].X)
                {
                    curvePoints[pointNumber] = curvePoints[pointNumber + 1];
                }
            }
            this.Refresh();
        }

        private void UOP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseEnter = true;
                if ((pointNumber = changeTableCheck(this.PointToClient(Cursor.Position))) < 0)
                    pointNumber = changeTableAdd(this.PointToClient(Cursor.Position));
            }
            else if (e.Button == MouseButtons.Right && ((pointNumberToRemove = changeTableCheck(this.PointToClient(Cursor.Position))) > 0))
            {
                curvePoints.RemoveAt(pointNumberToRemove);
                this.Refresh();
                mouseEnter = false;
            }
        }

        private void UOP_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseEnter && pointNumber > 0 && this.PointToClient(Cursor.Position).X <= 255 && this.PointToClient(Cursor.Position).X >= 0 && this.PointToClient(Cursor.Position).Y <= 255 && this.PointToClient(Cursor.Position).Y >= 0)
            {
                changeTableFilled(this.PointToClient(Cursor.Position));
            } 
            else if (mouseEnter && pointNumber > 0)
            {
                if(this.PointToClient(Cursor.Position).Y <= 255 && this.PointToClient(Cursor.Position).Y >= 0)
                {
                    if (this.PointToClient(Cursor.Position).X > 255) changeTableFilled(new Point(255, this.PointToClient(Cursor.Position).Y));
                    if (this.PointToClient(Cursor.Position).X < 0) changeTableFilled(new Point(0, this.PointToClient(Cursor.Position).Y));
                }
                if(this.PointToClient(Cursor.Position).X <= 255 && this.PointToClient(Cursor.Position).X >= 0)
                {
                    if (this.PointToClient(Cursor.Position).Y > 255) changeTableFilled(new Point(this.PointToClient(Cursor.Position).X, 255));
                    if (this.PointToClient(Cursor.Position).Y < 0) changeTableFilled(new Point(this.PointToClient(Cursor.Position).X, 0));
                }
                if (this.PointToClient(Cursor.Position).X > 255 && this.PointToClient(Cursor.Position).Y > 255) changeTableFilled(new Point(255, 255));
                if (this.PointToClient(Cursor.Position).X < 0 && this.PointToClient(Cursor.Position).Y < 0) changeTableFilled(new Point(0, 0));
                if (this.PointToClient(Cursor.Position).X < 0 && this.PointToClient(Cursor.Position).Y > 255) changeTableFilled(new Point(0, 255));
                if (this.PointToClient(Cursor.Position).X > 255 && this.PointToClient(Cursor.Position).Y < 0) changeTableFilled(new Point(255, 0));
            }

            mousePosition.Text = "" + this.PointToClient(Cursor.Position);
        }

        private void UOP_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEnter = false;

            if(curvePoints.GroupBy(n => n).Any(c => c.Count() > 1)) curvePoints.RemoveAt(pointNumber); // Find duplicates in list and reduce last added.

            label.Text = ((curvePoints.Count - 2) != countOfDots ? "" : "Max: ") + (curvePoints.Count - 2);
        }
    }
}

