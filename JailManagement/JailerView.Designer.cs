namespace JailManagement
{
    partial class JailerView
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
            this.button3 = new System.Windows.Forms.Button();
            this.Jailer_Log_Out = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jailer View";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(159, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Prisoner";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit Prisoner";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(570, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "View Prisoner";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Jailer_Log_Out
            // 
            this.Jailer_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Jailer_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jailer_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Jailer_Log_Out.Location = new System.Drawing.Point(770, 34);
            this.Jailer_Log_Out.Name = "Jailer_Log_Out";
            this.Jailer_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Jailer_Log_Out.TabIndex = 9;
            this.Jailer_Log_Out.Text = "Log Out";
            this.Jailer_Log_Out.UseVisualStyleBackColor = false;
            this.Jailer_Log_Out.Click += new System.EventHandler(this.Jailer_Log_Out_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SeaShell;
            this.button4.Location = new System.Drawing.Point(65, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 46);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // JailerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(964, 574);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Jailer_Log_Out);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "JailerView";
            this.Text = "JailerView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JailerView_FormClosing);
            this.Load += new System.EventHandler(this.JailerView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Jailer_Log_Out;
        private System.Windows.Forms.Button button4;
    }
}