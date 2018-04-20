namespace UserControlTest
{
    partial class PersonEdit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditDeclineBtn = new System.Windows.Forms.Button();
            this.EditAcceptBtn = new System.Windows.Forms.Button();
            this.personUCedit = new UserControlTest.PersonUC(MainForm);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EditDeclineBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditAcceptBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EditDeclineBtn
            // 
            this.EditDeclineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditDeclineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditDeclineBtn.Location = new System.Drawing.Point(3, 3);
            this.EditDeclineBtn.Name = "EditDeclineBtn";
            this.EditDeclineBtn.Size = new System.Drawing.Size(174, 57);
            this.EditDeclineBtn.TabIndex = 0;
            this.EditDeclineBtn.Text = "Rezygnuj";
            this.EditDeclineBtn.UseVisualStyleBackColor = true;
            this.EditDeclineBtn.Click += new System.EventHandler(this.EditDeclineBtn_Click);
            // 
            // EditAcceptBtn
            // 
            this.EditAcceptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditAcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditAcceptBtn.Location = new System.Drawing.Point(183, 3);
            this.EditAcceptBtn.Name = "EditAcceptBtn";
            this.EditAcceptBtn.Size = new System.Drawing.Size(174, 57);
            this.EditAcceptBtn.TabIndex = 1;
            this.EditAcceptBtn.Text = "Akceptuj";
            this.EditAcceptBtn.UseVisualStyleBackColor = true;
            this.EditAcceptBtn.Click += new System.EventHandler(this.EditAcceptBtn_Click);
            // 
            // personUCedit
            // 
            this.personUCedit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personUCedit.Location = new System.Drawing.Point(12, 12);
            this.personUCedit.Name = "personUCedit";
            this.personUCedit.Size = new System.Drawing.Size(360, 78);
            this.personUCedit.TabIndex = 0;
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.personUCedit);
            this.MinimumSize = new System.Drawing.Size(400, 210);
            this.Name = "PersonEdit";
            this.Text = "PersonEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonUC personUCedit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EditDeclineBtn;
        private System.Windows.Forms.Button EditAcceptBtn;
    }
}