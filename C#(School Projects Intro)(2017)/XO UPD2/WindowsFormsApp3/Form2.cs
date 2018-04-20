using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class gameXO : Form
    {
        Label upperConsole;
        mainWindow main;
        Stopwatch watch = new Stopwatch();
        string gamer;
        Image playerX, playerO, player;
        public int toWinCount, haveWinCount = 1, moves, countW, countH, btnSize, usedToCheck = 0;
        bool win = false, ifDraw = false, line = false, horLine = false, slash = false, backSlash = false;
        Button[,] btTab;
        int changed;
        public int sizedH, sizedW;
        Label plus = new Label(), minus = new Label();
        
        public gameXO(mainWindow obj, int cW, int cH)
        {
            watch.Start();

            this.Icon = obj.newIcon;
            this.Text = "TIC TAC TOE";
            this.BackColor = Color.Beige;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            main = obj;
            sizedH = countW = cW;
            sizedW = countH = cH;
            btnSize = 100;

            this.Size = this.MinimumSize = new Size(countW * btnSize + 18, countH * btnSize + 90);

            InitializeComponent();

            FormClosing += gameClosing;

            ResizeBegin += sizeChangingBegin;

            ResizeEnd += sizeChangingEnd;

            Resize += sizeChanged;

            boardIni(countW, countH, btnSize);

            playerO = new Bitmap(btnSize, btnSize);
            Pen blackPen = new Pen(Color.Black, btnSize / 3);
            Graphics g = Graphics.FromImage(playerO);
            g.DrawRectangle(blackPen, 0, 0, btnSize, btnSize);

            playerX = new Bitmap(btnSize, btnSize);
            Graphics x = Graphics.FromImage(playerX);
            x.DrawLine(blackPen, -1, -1, btnSize, btnSize);
            x.DrawLine(blackPen, 0, btnSize, btnSize, 0);

            plus.BackColor = Color.Transparent;
            plus.BorderStyle = BorderStyle.None;
            plus.TextAlign = ContentAlignment.MiddleCenter;
            plus.Text = "+";
            plus.Font = new Font("Arial", btnSize / 6, FontStyle.Bold);
            plus.Location = new Point(2, 2);
            plus.Size = new Size(26, 49);
            plus.Click += plusClick;
            this.Controls.Add(plus);

            minus.BackColor = plus.BackColor;
            minus.BorderStyle = plus.BorderStyle;
            minus.TextAlign = plus.TextAlign;
            minus.Font = plus.Font;
            minus.Size = plus.Size;
            minus.Text = "-";
            minus.Location = new Point(countW * btnSize - 26, 2);
            minus.Click += minusClick;
            this.Controls.Add(minus);

            upperConsole = new Label();
            upperConsole.Location = new Point(1, 1);
            upperConsole.Name = "upperConsole";
            upperConsole.Text = "NEW GAME";
            upperConsole.BorderStyle = BorderStyle.FixedSingle;
            upperConsole.Enabled = false;
            upperConsole.Size = new Size(countW * btnSize, 52);
            upperConsole.Font = new Font("Arial", btnSize / 6);
            upperConsole.TextAlign = ContentAlignment.BottomCenter; 
            upperConsole.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(upperConsole);
        }

        private void plusClick(object sender, EventArgs s)
        {
            if (btnSize < 100)
            {
                btnSize += 10;
                rebord();
            }
        }

        private void minusClick(object sender, EventArgs s)
        {
            if (btnSize > 50)
            {
                btnSize -= 10;
                rebord();
            }
        }

        private void rebord()
        {
            int busize = 6;
            nullBoard(countW, countH);
            boardIni(countW, countH, btnSize);
            this.Size = this.MinimumSize = new Size(countW * btnSize + 18, countH * btnSize + 90);
            upperConsole.Size = new Size(countW * btnSize, 52);
            if (countW > 3)
            {
                busize = 4;
            }
            upperConsole.Font = new Font("Arial", btnSize / busize);
            minus.Location = new Point(countW * btnSize - 26, 2);
        }

        private void sizeChanged(object sender, EventArgs s)
        {
            changed++;
        }

        private void sizeChangingBegin(object sender, EventArgs s)
        {
            if (moves != 0)
            {
                this.MinimumSize = this.MaximumSize = this.Size;
            }
            else
            {
                this.MinimumSize = new Size(sizedW * btnSize + 18, sizedH * btnSize + 90);
                this.MaximumSize = new Size(0, 0);
            }
        }

        private void sizeChangingEnd(object sender, EventArgs e)
        {
            if (moves == 0 & changed > 1)
            {
                changed = -1;
                if (this.Height == this.MinimumSize.Height)
                {
                    nullBoard(countW, countH);
                    countH = sizedH;
                    boardIni(countW, countH, btnSize);
                }
                if (this.Width == this.MinimumSize.Width)
                {
                    nullBoard(countW, countH);
                    countW = sizedW;
                    boardIni(countW, countH, btnSize);
                    upperConsole.Font = new Font("Arial", btnSize / 6);
                }
                if (this.Height != this.MinimumSize.Height || this.Width != this.MinimumSize.Width)
                {
                    for (int i = btnSize; i <= btnSize * 30; i += btnSize)
                    {
                        if (this.Size.Height > this.MinimumSize.Height + i - btnSize & this.Size.Height <= this.MinimumSize.Height + i)
                        {
                            nullBoard(countW, countH);
                            countH = sizedH + i / btnSize;
                            boardIni(countW, countH, btnSize);
                        }
                    }
                    for (int i = btnSize; i <= btnSize * 30; i += btnSize)
                    {
                        if (this.Size.Width > this.MinimumSize.Width + i - btnSize & this.Size.Width <= this.MinimumSize.Width + i)
                        {
                            nullBoard(countW, countH);
                            countW = sizedW + i / btnSize;
                            boardIni(countW, countH, btnSize);
                            upperConsole.Font = new Font("Arial", (btnSize / 5) + i / (2 * btnSize));
                        }
                    }
                }
                this.Size = new Size(countW * btnSize + 18, countH * btnSize + 90);
                upperConsole.Size = new Size(countW * btnSize, 52);
                minus.Location = new Point(countW * btnSize - 26, 2);
            }
        }

        private void nullBoard(int bW, int bH)
        {
            for (int i = 0; i < bW; ++i)
            {
                for (int j = 0; j < bH; ++j)
                {
                    this.Controls.Remove(btTab[i, j]);
                }
            }
            btTab = null;
        }

        private void boardIni(int bW, int bH, int bSz)
        {
            File.Delete(@"C:\Windows\Temp\gameStats.txt");
            string[] gameStat = new string[1] { bW.ToString() + ";" + bH.ToString() + ";" + bSz.ToString() };
            File.AppendAllLines(@"C:\Windows\Temp\gameStats.txt", gameStat);

            int[] pozLocal;
            if (Math.Min(bH, bW) > 5)
            {
                toWinCount = 5;
            }
            else if (Math.Min(bH, bW) <= 5)
            {
                toWinCount = Math.Min(bH, bW);
            }
            
            btTab = new Button[bW, bH];
            
            for (int i = 0; i < bW; ++i)
            {
                for (int j = 0; j < bH; ++j)
                {
                    btTab[i, j] = new Button();
                    btTab[i, j].Size = new Size(bSz, bSz);
                    btTab[i, j].Location = new Point(3/2 + i * bSz, 51 + j * bSz);
                    btTab[i, j].BackColor = Color.Transparent;
                    btTab[i, j].FlatStyle = FlatStyle.Flat;
                    btTab[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    btTab[i, j].Click += buttonClick;
                    btTab[i, j].Tag = new int[2];
                    pozLocal = (int[])btTab[i, j].Tag;
                    pozLocal[0] = i;
                    pozLocal[1] = j;
                    this.Controls.Add(btTab[i, j]);
                }
            }
        }

        private void buttonClick(object button, EventArgs e)
        {
            int[] pozLocal;
            pozLocal = (int[])((Control)button).Tag;

            if (win == false & ifDraw == false)
            {
                if (moves % 2 == 0)
                {
                    if ((((Control)button).BackgroundImage) == null)
                    {
                        upperConsole.ResetText();
                        upperConsole.Text = "O MOVED";
                        (((Control)button).BackgroundImage) = playerO;

                        string[] stat0 = new string[1] { "0;" + pozLocal[0] + ";" + pozLocal[1] };
                        File.AppendAllLines(@"C:\Windows\Temp\gameStats.txt", stat0);

                        moves++;
                    }
                }
                else
                {
                    if ((((Control)button).BackgroundImage) == null)
                    {
                        upperConsole.ResetText();
                        upperConsole.Text = "X MOVED";
                        (((Control)button).BackgroundImage) = playerX;

                        string[] stat1 = new string[1] { "1;" + pozLocal[0] + ";" + pozLocal[1] };
                        File.AppendAllLines(@"C:\Windows\Temp\gameStats.txt", stat1);

                        moves++;
                    }
                }
                checkStatus(button);
            }
            else
            {
                if ((((Control)button).BackgroundImage) == playerX)
                {
                    Close();
                }
                else if ((((Control)button).BackgroundImage) == playerO)
                {
                    restartIt();
                }
                else
                {
                    upperConsole.ResetText();
                    upperConsole.Text = "TO START OVER CLICK O";
                }
            }
        }

        private void checkStatus(object button)
        {
            if (moves != 0)
            {
                minus.Visible = false;
                plus.Visible = false;
            }

            int[] pozLocal;

            pozLocal = (int[])((Control)button).Tag;
            Point p = new Point(pozLocal[0], pozLocal[1]);

            if (countH * countW == moves)
            {
                draw();
            }
            {

                if ((((Control)button).BackgroundImage) == playerX)
                {
                    player = playerX;
                }
                else
                {
                    player = playerO;
                }
            }
            checkThat(p);
        }

        private void checkThat(Point a)
        {
            checkLine(a);
            checkHorizontLine(a);
            checkSlash(a);
            checkBackSlash(a);
            if (haveWinCount >= toWinCount)
            {
                checkLine(a);
                checkHorizontLine(a);
                checkSlash(a);
                checkBackSlash(a);
                ifWin();
            }
            else
            {
                haveWinCount = 1;
            }
        }

        private void checkLine(Point a)
        {
            bool lp = false, lm = false;
            if ((haveWinCount != toWinCount & line == false) || (haveWinCount >= toWinCount & line == true))
            {
                for (int i = 1; i <= toWinCount; i++)
                {
                    if (a.X + i < countW & !lp)
                    {
                        if (btTab[a.X + i, a.Y].BackgroundImage == player)
                        {
                            checkWinAndColor(a, i, 0, 0);
                        }
                        else
                        {
                            lp = true;
                        }
                    }
                    if (a.X - i >= 0 & !lm)
                    {
                        if (btTab[a.X - i, a.Y].BackgroundImage == player)
                        {
                            checkWinAndColor(a, -i, 0, 0);
                        }
                        else
                        {
                            lm = true;
                        }
                    }
                }
                
            }
            if (haveWinCount != toWinCount)
            {
                haveWinCount = 1;
            }
            else if (haveWinCount >= toWinCount & usedToCheck < 1)
            {
                ++usedToCheck;
                line = true;
            }
        }

        private void checkHorizontLine(Point a)
        {
            bool hlp = false, hlm = false;
            if ((haveWinCount != toWinCount & horLine == false) || (haveWinCount >= toWinCount & horLine == true))
            {
                for (int i = 1; i <= toWinCount; i++)
                {
                    if (a.Y + i < countH & !hlp)
                    {
                        if (btTab[a.X, a.Y + i].BackgroundImage == player)
                        {
                            checkWinAndColor(a, i, 1, 0);
                        }
                        else
                        {
                            hlp = true;
                        }
                    }
                    if (a.Y - i >= 0 & !hlm)
                    {
                        if (btTab[a.X, a.Y - i].BackgroundImage == player)
                        {
                            checkWinAndColor(a, -i, 1, 0);
                        }
                        else
                        {
                            hlm = true;
                        }
                    }
                }
            }
            if (haveWinCount != toWinCount)
            {
                haveWinCount = 1;
            }
            else if (haveWinCount >= toWinCount & usedToCheck < 1)
            {
                ++usedToCheck;
                horLine = true;
            }
        }
        
        private void checkSlash(Point a)
        {
            bool sp = false, sm = false;
            if ((haveWinCount != toWinCount & slash == false) || (haveWinCount >= toWinCount & slash == true))
            {
                for (int i = 1; i <= toWinCount; i++)
                {
                    if (a.X - i >= 0 && a.Y + i < countH & !sp)
                    {
                        if (btTab[a.X - i, a.Y + i].BackgroundImage == player)
                        {
                            checkWinAndColor(a, -i, 2, i);
                        }
                        else
                        {
                            sp = true;
                        }
                    }
                    if (a.X + i < countW && a.Y - i >= 0 & !sm)
                    {
                        if (btTab[a.X + i, a.Y - i].BackgroundImage == player)
                        {
                            checkWinAndColor(a, i, 2, -i);
                        }
                        else
                        {
                            sm = true;
                        }
                    }
                }
            }
            if (haveWinCount != toWinCount)
            {
                haveWinCount = 1;
            }
            else if (haveWinCount >= toWinCount & usedToCheck < 1)
            {
                ++usedToCheck;
                slash = true;
            }
        }

        private void checkBackSlash(Point a)
        {
            bool bsp = false, bsm = false;
            if ((haveWinCount != toWinCount & backSlash == false) || (haveWinCount >= toWinCount & backSlash == true))
            {
                for (int i = 1; i <= toWinCount; i++)
                {
                    if (a.Y + i < countH && a.X + i < countW & !bsp)
                    {
                        if (btTab[a.X + i, a.Y + i].BackgroundImage == player)
                        {
                            checkWinAndColor(a, i, 2, i);
                        }
                        else
                        {
                            bsp = true;
                        }
                    }
                    if (a.Y - i >= 0 && a.X - i >= 0 & !bsm)
                    {
                        if (btTab[a.X - i, a.Y - i].BackgroundImage == player)
                        {
                            checkWinAndColor(a, -i, 2, -i);
                        }
                        else
                        {
                            bsm = true;
                        }
                    }
                }
            }
            if (haveWinCount != toWinCount)
            {
                haveWinCount = 1;
            }
            else if (haveWinCount >= toWinCount & usedToCheck < 1)
            {
                ++usedToCheck;
                backSlash = true;
            }
        }

        private void checkWinAndColor(Point a, int x, int i, int y)
        {
            if (haveWinCount != toWinCount)
            {
                haveWinCount++;
            }
            else if (haveWinCount >= toWinCount)
            {
                colorIt(a, x, i, y);
            }
        }

        private void colorIt(Point a, int x, int i, int y)
        {
            if (i == 0)
            {
                btTab[a.X + x, a.Y].BackColor = Color.SaddleBrown;
            }
            else if (i == 1)
            {
                btTab[a.X, a.Y + x].BackColor = Color.SaddleBrown;
            }
            else if (i == 2)
            {
                btTab[a.X + x, a.Y + y].BackColor = Color.SaddleBrown;
            }
            btTab[a.X, a.Y].BackColor = Color.SaddleBrown;
        }

        private void ifWin()
        {
            watch.Stop();
            if (player == playerX)
            {
                gamer = "X";
            }
            else
            {
                gamer = "O";
            }
            upperConsole.ResetText();
            upperConsole.Text = gamer + " WON ";
            win = true;
            log();
            File.Delete(@"C:\Windows\Temp\gameStats.txt");
        }

        private void log()
        {
            TimeSpan ts = watch.Elapsed;
            string[] gameTime = new string[1];
            gameTime[0] = String.Format("{3} WON PER {0:00}M {1:00}S {2:00}MS", ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10, gamer);
            File.AppendAllLines(@"C:\Windows\Temp\log.txt", gameTime);
        }

        private void draw()
        {
            ifDraw = true;
            upperConsole.ResetText();
            upperConsole.Text = "DRAW";
            File.Delete(@"C:\Windows\Temp\gameStats.txt");
        }

        private void restartIt()
        {
            for (int i = 0; i < countW; ++i)
            {
                for (int j = 0; j < countH; ++j)
                {
                    btTab[i, j].BackgroundImage = null;
                    btTab[i, j].BackColor = Color.Transparent;
                }
            }
            minus.Visible = true;
            plus.Visible = true;
            watch.Start();
            upperConsole.ResetText();
            upperConsole.Text = "THE GAME WAS RESTARTED";
            haveWinCount = 1;
            moves = 0; usedToCheck = 0;
            win = false; ifDraw = false; line = false; horLine = false; slash = false; backSlash = false;
            string[] gameStat = new string[1] { countW.ToString() + ";" + countH.ToString() + ";" + btnSize.ToString() };
            File.AppendAllLines(@"C:\Windows\Temp\gameStats.txt", gameStat);
        }

        private void gameClosing(object sender, CancelEventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
} 

//AT THE NEXT UPD3 MUST BE ADDED

//table into the table
//change count of wins to finish
//checkpoints with table state saves
//change color of GUI elements
//write log to selected path
//usernames (DEFAULTUSER)
//info button

//MessageBox.Show(String.Format("moves: {0}", moves), "TRACKINFO", MessageBoxButtons.OK);