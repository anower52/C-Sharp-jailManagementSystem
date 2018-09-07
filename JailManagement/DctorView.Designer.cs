namespace JailManagement
{
    partial class DctorView
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Doctor_Log_Out = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 115);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctors View";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Post Mortem";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(373, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit Post Mortem";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Doctor_Log_Out
            // 
            this.Doctor_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Doctor_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Doctor_Log_Out.Location = new System.Drawing.Point(818, 47);
            this.Doctor_Log_Out.Name = "Doctor_Log_Out";
            this.Doctor_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Doctor_Log_Out.TabIndex = 9;
            this.Doctor_Log_Out.Text = "Log Out";
            this.Doctor_Log_Out.UseVisualStyleBackColor = false;
            this.Doctor_Log_Out.Click += new System.EventHandler(this.Doctor_Log_Out_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SeaShell;
            this.button3.Location = new System.Drawing.Point(38, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 574);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Doctor_Log_Out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "DctorView";
            this.Text = "DctorView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DctorView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Doctor_Log_Out;
        private System.Windows.Forms.Button button3;
    }
}