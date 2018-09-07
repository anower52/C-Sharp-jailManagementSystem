using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JailManagement
{
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateUser_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void UserResisterButton_Click(object sender, EventArgs e)
        {
           /* SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO Employee (Full_Name,User_Id,Password,Date_of_Birth,Gender,Work_place,Address,Phone_number,Designation) VALUES (@Full_Name,@User_Id,@Password,@Date_of_Birth,@Gender,@Work_place,@Address,@Phone_number,@Designation)";

            SqlCommand cmd = new SqlCommand(sql, myConnection);

            cmd.Parameters.AddWithValue("@Full_Name", CreateAccountName.Text);
            cmd.Parameters.AddWithValue("@User_Id", CreateAccoutUserName.Text);
            cmd.Parameters.AddWithValue("@Password", CreateAccoutPassword.Text);

            cmd.Parameters.AddWithValue("@Date_of_Birth", CreateAccoutDateofBirth.Value);

            cmd.Parameters.AddWithValue("@Work_place", CreateAccountWorkPlace.Text);

            cmd.Parameters.AddWithValue("@Address", textBox1.Text);

            cmd.Parameters.AddWithValue("@Phone_number", CreateAccountPhone.Text);
            cmd.Parameters.AddWithValue("@Designation", CreateAccountDesig.Text);
            

            string value = "";
            bool isChecked = CreateAccountGMale.Checked;
            if (isChecked)
            {
                value = CreateAccountGMale.Text;
            }
            else
            {
                value = CreateAccountGFemale.Text;
            }

            cmd.Parameters.AddWithValue("@Gender", value);



            
            myConnection.Open();
            int i = cmd.ExecuteNonQuery();
            myConnection.Close();

            MessageBox.Show("Succesfully Account Created");
           */
        }
    }
}
