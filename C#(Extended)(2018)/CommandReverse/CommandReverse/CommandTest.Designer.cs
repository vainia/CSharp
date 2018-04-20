namespace CommandTest
{
    partial class CommandReverseTest
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
            this.Log = new System.Windows.Forms.TextBox();
            this.ListCmds = new System.Windows.Forms.ListBox();
            this.ListMacro = new System.Windows.Forms.ListBox();
            this.MacroName = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnAppend = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.sportmanName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 130);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(469, 123);
            this.Log.TabIndex = 0;
            // 
            // ListCmds
            // 
            this.ListCmds.FormattingEnabled = true;
            this.ListCmds.Location = new System.Drawing.Point(12, 12);
            this.ListCmds.Name = "ListCmds";
            this.ListCmds.Size = new System.Drawing.Size(120, 82);
            this.ListCmds.TabIndex = 3;
            // 
            // ListMacro
            // 
            this.ListMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListMacro.FormattingEnabled = true;
            this.ListMacro.Location = new System.Drawing.Point(365, 13);
            this.ListMacro.Name = "ListMacro";
            this.ListMacro.Size = new System.Drawing.Size(120, 82);
            this.ListMacro.TabIndex = 4;
            // 
            // MacroName
            // 
            this.MacroName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MacroName.Location = new System.Drawing.Point(385, 104);
            this.MacroName.Name = "MacroName";
            this.MacroName.Size = new System.Drawing.Size(100, 20);
            this.MacroName.TabIndex = 5;
            this.MacroName.TextChanged += new System.EventHandler(this.MacroName_TextChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(12, 101);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(89, 23);
            this.BtnExecute.TabIndex = 6;
            this.BtnExecute.Text = "Wykonaj";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(107, 101);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(272, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnAppend
            // 
            this.BtnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppend.Location = new System.Drawing.Point(138, 13);
            this.BtnAppend.Name = "BtnAppend";
            this.BtnAppend.Size = new System.Drawing.Size(221, 23);
            this.BtnAppend.TabIndex = 8;
            this.BtnAppend.Text = ">";
            this.BtnAppend.UseVisualStyleBackColor = true;
            this.BtnAppend.Click += new System.EventHandler(this.BtnAppend_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Location = new System.Drawing.Point(138, 68);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(221, 23);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "<";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // sportmanName
            // 
            this.sportmanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sportmanName.Location = new System.Drawing.Point(138, 42);
            this.sportmanName.Name = "sportmanName";
            this.sportmanName.Size = new System.Drawing.Size(220, 20);
            this.sportmanName.TabIndex = 10;
            this.sportmanName.Text = "sportmanName";
            // 
            // CommandReverseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 265);
            this.Controls.Add(this.sportmanName);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAppend);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.MacroName);
            this.Controls.Add(this.ListMacro);
            this.Controls.Add(this.ListCmds);
            this.Controls.Add(this.Log);
            this.MinimumSize = new System.Drawing.Size(312, 303);
            this.Name = "CommandReverseTest";
            this.Text = "Commander";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.ListBox ListCmds;
        private System.Windows.Forms.ListBox ListMacro;
        private System.Windows.Forms.TextBox MacroName;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnAppend;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TextBox sportmanName;
    }
}

