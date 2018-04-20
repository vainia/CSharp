namespace ImageCurveAdjustment
{
    partial class UOP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.mousePosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Enabled = false;
            this.label.Location = new System.Drawing.Point(13, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Dots Counter";
            // 
            // mousePosition
            // 
            this.mousePosition.AutoSize = true;
            this.mousePosition.BackColor = System.Drawing.Color.Transparent;
            this.mousePosition.Enabled = false;
            this.mousePosition.Location = new System.Drawing.Point(163, 228);
            this.mousePosition.Name = "mousePosition";
            this.mousePosition.Size = new System.Drawing.Size(79, 13);
            this.mousePosition.TabIndex = 1;
            this.mousePosition.Text = "Mouse Position";
            // 
            // UOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mousePosition);
            this.Controls.Add(this.label);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UOP";
            this.Size = new System.Drawing.Size(255, 255);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UOP_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UOP_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UOP_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UOP_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label mousePosition;
    }
}
