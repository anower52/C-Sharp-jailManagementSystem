namespace JailManagement
{
    partial class PoliceView
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
            this.PoliceComplaiButton = new System.Windows.Forms.Button();
            this.PoliceCriminalButton = new System.Windows.Forms.Button();
            this.PoliceWantedButton = new System.Windows.Forms.Button();
            this.Police_Log_Out = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Police View";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoliceComplaiButton
            // 
            this.PoliceComplaiButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PoliceComplaiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoliceComplaiButton.Location = new System.Drawing.Point(148, 222);
            this.PoliceComplaiButton.Name = "PoliceComplaiButton";
            this.PoliceComplaiButton.Size = new System.Drawing.Size(177, 53);
            this.PoliceComplaiButton.TabIndex = 7;
            this.PoliceComplaiButton.Text = "Complain";
            this.PoliceComplaiButton.UseVisualStyleBackColor = false;
            this.PoliceComplaiButton.Click += new System.EventHandler(this.PoliceComplaiButton_Click);
            // 
            // PoliceCriminalButton
            // 
            this.PoliceCriminalButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PoliceCriminalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoliceCriminalButton.Location = new System.Drawing.Point(390, 222);
            this.PoliceCriminalButton.Name = "PoliceCriminalButton";
            this.PoliceCriminalButton.Size = new System.Drawing.Size(171, 53);
            this.PoliceCriminalButton.TabIndex = 7;
            this.PoliceCriminalButton.Text = "Criminal";
            this.PoliceCriminalButton.UseVisualStyleBackColor = false;
            this.PoliceCriminalButton.Click += new System.EventHandler(this.PoliceCriminalButton_Click);
            // 
            // PoliceWantedButton
            // 
            this.PoliceWantedButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PoliceWantedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoliceWantedButton.Location = new System.Drawing.Point(617, 222);
            this.PoliceWantedButton.Name = "PoliceWantedButton";
            this.PoliceWantedButton.Size = new System.Drawing.Size(172, 53);
            this.PoliceWantedButton.TabIndex = 7;
            this.PoliceWantedButton.Text = "Wanted Criminal";
            this.PoliceWantedButton.UseVisualStyleBackColor = false;
            this.PoliceWantedButton.Click += new System.EventHandler(this.PoliceWantedButton_Click);
            // 
            // Police_Log_Out
            // 
            this.Police_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Police_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Police_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Police_Log_Out.Location = new System.Drawing.Point(819, 46);
            this.Police_Log_Out.Name = "Police_Log_Out";
            this.Police_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Police_Log_Out.TabIndex = 8;
            this.Police_Log_Out.Text = "Log Out";
            this.Police_Log_Out.UseVisualStyleBackColor = false;
            this.Police_Log_Out.Click += new System.EventHandler(this.Police_Log_Out_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(47, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PoliceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Police_Log_Out);
            this.Controls.Add(this.PoliceWantedButton);
            this.Controls.Add(this.PoliceCriminalButton);
            this.Controls.Add(this.PoliceComplaiButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PoliceView";
            this.Text = "PoliceView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoliceView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PoliceComplaiButton;
        private System.Windows.Forms.Button PoliceCriminalButton;
        private System.Windows.Forms.Button PoliceWantedButton;
        private System.Windows.Forms.Button Police_Log_Out;
        private System.Windows.Forms.Button button2;
    }
}