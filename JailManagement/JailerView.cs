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
    public partial class JailerView : Form
    {
        public JailerView()
        {
            InitializeComponent();
        }

        private void Jailer_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void JailerView_Load(object sender, EventArgs e)
        {

        }

        private void JailerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
