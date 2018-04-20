namespace BindingTest
{
    partial class BindingMain
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
            this.nameBoxLeft = new System.Windows.Forms.TextBox();
            this.surnameBoxLeft = new System.Windows.Forms.TextBox();
            this.nameBoxRight = new System.Windows.Forms.TextBox();
            this.surnameBoxRight = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameBoxLeft
            // 
            this.nameBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBoxLeft.Location = new System.Drawing.Point(12, 486);
            this.nameBoxLeft.Name = "nameBoxLeft";
            this.nameBoxLeft.Size = new System.Drawing.Size(207, 20);
            this.nameBoxLeft.TabIndex = 0;
            // 
            // surnameBoxLeft
            // 
            this.surnameBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.surnameBoxLeft.Location = new System.Drawing.Point(12, 513);
            this.surnameBoxLeft.Name = "surnameBoxLeft";
            this.surnameBoxLeft.Size = new System.Drawing.Size(207, 20);
            this.surnameBoxLeft.TabIndex = 1;
            // 
            // nameBoxRight
            // 
            this.nameBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBoxRight.Location = new System.Drawing.Point(225, 486);
            this.nameBoxRight.Name = "nameBoxRight";
            this.nameBoxRight.Size = new System.Drawing.Size(223, 20);
            this.nameBoxRight.TabIndex = 0;
            // 
            // surnameBoxRight
            // 
            this.surnameBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBoxRight.Location = new System.Drawing.Point(225, 513);
            this.surnameBoxRight.Name = "surnameBoxRight";
            this.surnameBoxRight.Size = new System.Drawing.Size(223, 20);
            this.surnameBoxRight.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(12, 374);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(436, 49);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(11, 429);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(436, 49);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(11, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(438, 355);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
            // 
            // BindingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 548);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.surnameBoxRight);
            this.Controls.Add(this.surnameBoxLeft);
            this.Controls.Add(this.nameBoxRight);
            this.Controls.Add(this.nameBoxLeft);
            this.Name = "BindingMain";
            this.Text = "BindingTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBoxLeft;
        private System.Windows.Forms.TextBox surnameBoxLeft;
        private System.Windows.Forms.TextBox nameBoxRight;
        private System.Windows.Forms.TextBox surnameBoxRight;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListBox listBox;
    }
}

