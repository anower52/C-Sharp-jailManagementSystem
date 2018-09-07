namespace JailManagement
{
    partial class DeleteAccount
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
            this.Admin_Log_Out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAccountPass = new System.Windows.Forms.TextBox();
            this.DeleteAccountId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_Log_Out
            // 
            this.Admin_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Admin_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Admin_Log_Out.Location = new System.Drawing.Point(777, 30);
            this.Admin_Log_Out.Name = "Admin_Log_Out";
            this.Admin_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Admin_Log_Out.TabIndex = 10;
            this.Admin_Log_Out.Text = "Log Out";
            this.Admin_Log_Out.UseVisualStyleBackColor = false;
            this.Admin_Log_Out.Click += new System.EventHandler(this.Admin_Log_Out_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Delete Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteAccountPass
            // 
            this.DeleteAccountPass.Location = new System.Drawing.Point(376, 284);
            this.DeleteAccountPass.Multiline = true;
            this.DeleteAccountPass.Name = "DeleteAccountPass";
            this.DeleteAccountPass.Size = new System.Drawing.Size(200, 23);
            this.DeleteAccountPass.TabIndex = 15;
            // 
            // DeleteAccountId
            // 
            this.DeleteAccountId.Location = new System.Drawing.Point(376, 233);
            this.DeleteAccountId.Multiline = true;
            this.DeleteAccountId.Name = "DeleteAccountId";
            this.DeleteAccountId.Size = new System.Drawing.Size(200, 25);
            this.DeleteAccountId.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Admin Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "User ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(43, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteAccountPass);
            this.Controls.Add(this.DeleteAccountId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin_Log_Out);
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteAccount_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin_Log_Out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteAccountPass;
        private System.Windows.Forms.TextBox DeleteAccountId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}