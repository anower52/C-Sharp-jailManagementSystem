namespace JailManagement
{
    partial class Complain
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
            this.ComplainListGridView = new System.Windows.Forms.DataGridView();
            this.AddnewComplainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Complain_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComplainListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complain List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComplainListGridView
            // 
            this.ComplainListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComplainListGridView.Location = new System.Drawing.Point(99, 122);
            this.ComplainListGridView.Name = "ComplainListGridView";
            this.ComplainListGridView.Size = new System.Drawing.Size(815, 302);
            this.ComplainListGridView.TabIndex = 2;
            this.ComplainListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComplainListGridView_CellContentClick);
            // 
            // AddnewComplainButton
            // 
            this.AddnewComplainButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddnewComplainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddnewComplainButton.Location = new System.Drawing.Point(300, 482);
            this.AddnewComplainButton.Name = "AddnewComplainButton";
            this.AddnewComplainButton.Size = new System.Drawing.Size(180, 37);
            this.AddnewComplainButton.TabIndex = 7;
            this.AddnewComplainButton.Text = "Add New Complain";
            this.AddnewComplainButton.UseVisualStyleBackColor = false;
            this.AddnewComplainButton.Click += new System.EventHandler(this.AddnewComplainButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(523, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update Complain";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SeaShell;
            this.button3.Location = new System.Drawing.Point(46, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 46);
            this.button3.TabIndex = 51;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.Location = new System.Drawing.Point(767, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 37);
            this.button2.TabIndex = 52;
            this.button2.Text = "Delete Complain";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "ass",
            "sadfd",
            "adff",
            "afdfsf",
            "gf",
            "dff",
            "dfdfgfvc",
            "vcvc"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 28);
            this.textBox1.TabIndex = 53;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(307, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 28);
            this.button4.TabIndex = 54;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Complain_Log_Out
            // 
            this.Complain_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Complain_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complain_Log_Out.ForeColor = System.Drawing.Color.SeaShell;
            this.Complain_Log_Out.Location = new System.Drawing.Point(776, 14);
            this.Complain_Log_Out.Name = "Complain_Log_Out";
            this.Complain_Log_Out.Size = new System.Drawing.Size(95, 38);
            this.Complain_Log_Out.TabIndex = 65;
            this.Complain_Log_Out.Text = "Log Out";
            this.Complain_Log_Out.UseVisualStyleBackColor = false;
            this.Complain_Log_Out.Click += new System.EventHandler(this.Complain_Log_Out_Click);
            // 
            // Complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 574);
            this.Controls.Add(this.Complain_Log_Out);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddnewComplainButton);
            this.Controls.Add(this.ComplainListGridView);
            this.Controls.Add(this.label1);
            this.Name = "Complain";
            this.Text = "Complain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Complain_FormClosing);
            this.Load += new System.EventHandler(this.Complain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComplainListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ComplainListGridView;
        private System.Windows.Forms.Button AddnewComplainButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Complain_Log_Out;
    }
}