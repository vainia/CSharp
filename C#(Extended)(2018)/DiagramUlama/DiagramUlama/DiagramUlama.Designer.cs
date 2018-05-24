namespace DiagramUlama
{
    partial class DiagramUlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getNum = new System.Windows.Forms.TextBox();
            this.errMsg = new System.Windows.Forms.Label();
            this.diagramUlamaBox = new System.Windows.Forms.PictureBox();
            this.imgHandler = new System.Windows.Forms.Panel();
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.diagramUlamaBox)).BeginInit();
            this.imgHandler.SuspendLayout();
            this.SuspendLayout();
            // 
            // getNum
            // 
            this.getNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getNum.Location = new System.Drawing.Point(643, 438);
            this.getNum.Name = "getNum";
            this.getNum.Size = new System.Drawing.Size(91, 20);
            this.getNum.TabIndex = 2;
            this.getNum.Text = "36";
            this.getNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getNum.TextChanged += new System.EventHandler(this.getNum_TextChanged);
            // 
            // errMsg
            // 
            this.errMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errMsg.AutoSize = true;
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(640, 422);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(94, 13);
            this.errMsg.TabIndex = 4;
            this.errMsg.Text = "Type valid number";
            this.errMsg.Visible = false;
            // 
            // diagramUlamaBox
            // 
            this.diagramUlamaBox.Location = new System.Drawing.Point(0, 0);
            this.diagramUlamaBox.Name = "diagramUlamaBox";
            this.diagramUlamaBox.Size = new System.Drawing.Size(724, 407);
            this.diagramUlamaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.diagramUlamaBox.TabIndex = 5;
            this.diagramUlamaBox.TabStop = false;
            // 
            // imgHandler
            // 
            this.imgHandler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgHandler.AutoScroll = true;
            this.imgHandler.Controls.Add(this.diagramUlamaBox);
            this.imgHandler.Location = new System.Drawing.Point(10, 12);
            this.imgHandler.Name = "imgHandler";
            this.imgHandler.Size = new System.Drawing.Size(724, 407);
            this.imgHandler.TabIndex = 6;
            // 
            // scrollBar
            // 
            this.scrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBar.Location = new System.Drawing.Point(9, 438);
            this.scrollBar.Maximum = 10000;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(631, 17);
            this.scrollBar.TabIndex = 7;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // DiagramUlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 470);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.imgHandler);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.getNum);
            this.Name = "DiagramUlama";
            this.Text = "Diagram Ulama";
            ((System.ComponentModel.ISupportInitialize)(this.diagramUlamaBox)).EndInit();
            this.imgHandler.ResumeLayout(false);
            this.imgHandler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox getNum;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.PictureBox diagramUlamaBox;
        private System.Windows.Forms.Panel imgHandler;
        private System.Windows.Forms.HScrollBar scrollBar;
    }
}

