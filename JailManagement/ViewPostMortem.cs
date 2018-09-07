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
    public partial class ViewPostMortem : Form
    {
        public ViewPostMortem()
        {
            InitializeComponent();
        }

        private void ViewPostMortem_Load(object sender, EventArgs e)
        {
            

        }

        private void ViewPostMortem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
