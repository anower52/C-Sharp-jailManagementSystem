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
    public partial class PoliceView : Form
    {
        public PoliceView()
        {
            InitializeComponent();
        }

        private void PoliceView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PoliceComplaiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complain c = new Complain();
            c.Show();
            
        }

        private void PoliceCriminalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCriminal vc = new UpdateCriminal();
            vc.Show();
        }

        private void PolicePostMortemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPostMortem vm = new ViewPostMortem();
            vm.Show();
        }

        private void PoliceWantedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WantedView wv = new WantedView();
            wv.Show();
        }

        private void Police_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
            
    }
}
