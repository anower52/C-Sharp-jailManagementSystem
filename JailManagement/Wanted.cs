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
    public partial class Wanted : Form
    {
        public Wanted()
        {
            InitializeComponent();
        }

        private void Wanted_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
