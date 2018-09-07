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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JailManagementDataContext dc = new JailManagementDataContext();
            String userid = textBox1.Text;
            String password = textBox2.Text;

            Employee emp = dc.Employees.SingleOrDefault(x => x.Password == password & x.User_Id == userid);

            if (emp == null)
            {
                MessageBox.Show("Invalid UserName or Password");
            }
            else
            {
                if(emp.Designation == "Police")
                {
                     this.Hide();
                     PoliceView a = new PoliceView();
                     a.Show();
                }

                else if(emp.Designation == "Jailer")
                {
                     this.Hide();
                     JailerView a = new JailerView();
                     a.Show();
                }
                else if (emp.Designation == "Doctor")
                {
                    this.Hide();
                    DctorView a = new DctorView();
                    a.Show();
                }
                else if (emp.Designation == "Admin")
                {
                    this.Hide();
                    Admin a = new Admin();
                    a.Show();
                }


                    
                    
               
               
            }
            

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
