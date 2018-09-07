namespace JailManagement
{
    partial class ViewPostMortem
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
            this.PostMortemGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PostMortemSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PostMortemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PostMortemGridView
            // 
            this.PostMortemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostMortemGridView.Location = new System.Drawing.Point(104, 126);
            this.PostMortemGridView.Name = "PostMortemGridView";
            this.PostMortemGridView.Size = new System.Drawing.Size(778, 325);
            this.PostMortemGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "View PostMortem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PostMortemSearchBox
            // 
            this.PostMortemSearchBox.Location = new System.Drawing.Point(104, 98);
            this.PostMortemSearchBox.Multiline = true;
            this.PostMortemSearchBox.Name = "PostMortemSearchBox";
            this.PostMortemSearchBox.Size = new System.Drawing.Size(228, 18);
            this.PostMortemSearchBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Search";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(50, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ViewPostMortem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PostMortemSearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostMortemGridView);
            this.Controls.Add(this.label1);
            this.Name = "ViewPostMortem";
            this.Text = "ViewPostMortem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewPostMortem_FormClosing);
            this.Load += new System.EventHandler(this.ViewPostMortem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostMortemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PostMortemGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostMortemSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}