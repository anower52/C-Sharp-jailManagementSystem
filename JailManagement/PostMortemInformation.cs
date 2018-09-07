using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JailManagement
{
    public partial class PostMortemInformation : Form
    {
        public PostMortemInformation()
        {
            InitializeComponent();
        }

        private void Complain_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void PostMortemInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
