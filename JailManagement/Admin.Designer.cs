namespace JailManagement
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserResisterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Admin_Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserResisterButton
            // 
            this.UserResisterButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserResisterButton.Location = new System.Drawing.Point(305, 295);
            this.UserResisterButton.Name = "UserResisterButton";
            this.UserResisterButton.Size = new System.Drawing.Size(287, 58);
            this.UserResisterButton.TabIndex = 8;
            this.UserResisterButton.Text = "CreateAccount";
            this.UserResisterButton.UseVisualStyleBackColor = true;
            this.UserResisterButton.Click += new System.EventHandler(this.UserResisterButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Log_Out
            // 
            this.Admin_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Admin_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Admin_Log_Out.Location = new System.Drawing.Point(821, 27);
            this.Admin_Log_Out.Name = "Admin_Log_Out";
            this.Admin_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Admin_Log_Out.TabIndex = 9;
            this.Admin_Log_Out.Text = "Log Out";
            this.Admin_Log_Out.UseVisualStyleBackColor = false;
            this.Admin_Log_Out.Click += new System.EventHandler(this.Admin_Log_Out_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 574);
            this.Controls.Add(this.Admin_Log_Out);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserResisterButton);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserResisterButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Admin_Log_Out;
    }
}