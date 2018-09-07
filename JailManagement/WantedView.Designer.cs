namespace JailManagement
{
    partial class WantedView
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
            this.WantedGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Complain_Log_Out = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WantedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WantedGridView
            // 
            this.WantedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WantedGridView.Location = new System.Drawing.Point(168, 149);
            this.WantedGridView.Name = "WantedGridView";
            this.WantedGridView.Size = new System.Drawing.Size(730, 317);
            this.WantedGridView.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "View Wanted List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(49, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 49;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Complain_Log_Out
            // 
            this.Complain_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Complain_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complain_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Complain_Log_Out.Location = new System.Drawing.Point(745, 26);
            this.Complain_Log_Out.Name = "Complain_Log_Out";
            this.Complain_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Complain_Log_Out.TabIndex = 65;
            this.Complain_Log_Out.Text = "Log Out";
            this.Complain_Log_Out.UseVisualStyleBackColor = false;
            this.Complain_Log_Out.Click += new System.EventHandler(this.Complain_Log_Out_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(171, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 71;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(347, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 28);
            this.button4.TabIndex = 70;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // WantedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 574);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Complain_Log_Out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WantedGridView);
            this.Controls.Add(this.label1);
            this.Name = "WantedView";
            this.Text = "ViewWanted";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WantedView_FormClosing);
            this.Load += new System.EventHandler(this.WantedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WantedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WantedGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Complain_Log_Out;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}