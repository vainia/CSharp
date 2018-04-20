namespace UserControlTest
{
    partial class PersonUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.InitialsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.InitialsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.userPic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InitialsPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userPic
            // 
            this.userPic.BackColor = System.Drawing.Color.Black;
            this.userPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPic.Image = global::UserControlTest.Properties.Resources.Koala;
            this.userPic.Location = new System.Drawing.Point(5, 5);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(137, 167);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            this.userPic.Click += new System.EventHandler(this.userPic_Click);
            // 
            // InitialsPanel
            // 
            this.InitialsPanel.ColumnCount = 1;
            this.InitialsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InitialsPanel.Controls.Add(this.NameField, 0, 0);
            this.InitialsPanel.Controls.Add(this.SurnameField, 0, 1);
            this.InitialsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InitialsPanel.Location = new System.Drawing.Point(150, 5);
            this.InitialsPanel.Name = "InitialsPanel";
            this.InitialsPanel.RowCount = 2;
            this.InitialsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InitialsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InitialsPanel.Size = new System.Drawing.Size(328, 167);
            this.InitialsPanel.TabIndex = 1;
            this.InitialsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InitialsPanel_MouseClick);
            // 
            // NameField
            // 
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameField.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameField.Location = new System.Drawing.Point(3, 3);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(322, 27);
            this.NameField.TabIndex = 2;
            this.NameField.Text = "Imie";
            this.NameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SurnameField
            // 
            this.SurnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SurnameField.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameField.Location = new System.Drawing.Point(3, 86);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(322, 27);
            this.SurnameField.TabIndex = 2;
            this.SurnameField.Text = "Nazwisko";
            this.SurnameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonUC";
            this.Size = new System.Drawing.Size(483, 177);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.InitialsPanel.ResumeLayout(false);
            this.InitialsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.TableLayoutPanel InitialsPanel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SurnameField;
    }
}
