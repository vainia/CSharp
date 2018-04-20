namespace harmCalc
{
    partial class harmCalc
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
            this.edCount = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnDie = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edCount
            // 
            this.edCount.Location = new System.Drawing.Point(13, 14);
            this.edCount.Name = "edCount";
            this.edCount.Size = new System.Drawing.Size(100, 20);
            this.edCount.TabIndex = 0;
            this.edCount.Text = "10000000";
            this.edCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(119, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 37);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(39, 13);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Wyniki";
            // 
            // btnDie
            // 
            this.btnDie.Location = new System.Drawing.Point(281, 12);
            this.btnDie.Name = "btnDie";
            this.btnDie.Size = new System.Drawing.Size(75, 23);
            this.btnDie.TabIndex = 3;
            this.btnDie.Text = "Exit";
            this.btnDie.UseVisualStyleBackColor = true;
            this.btnDie.Click += new System.EventHandler(this.btnDie_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(200, 12);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // harmCalc
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 316);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDie);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.edCount);
            this.Name = "harmCalc";
            this.Text = "Calculator Sum of Harmonic Sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edCount;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnDie;
        private System.Windows.Forms.Button btnClean;
    }
}

