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

    public partial class NewComplain : Form
    {
        

        public NewComplain()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NewComplain_Load(object sender, EventArgs e)
        {
        }

        private void ComplainRegisterButton_Click(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO Complain (Complain_id,Full_Name,National_id,Date_of_Birth,Gender,Address,Nationality,Complain_Against,Complain_Date,Details) VALUES (@Complain_id,@Full_Name,@National_id,@Date_of_Birth,@Gender,@Address,@Nationality,@Complain_Against,@Complain_Date,@Details)";

            SqlCommand cmd = new SqlCommand(sql, myConnection);

            cmd.Parameters.AddWithValue("@Complain_id", Complain_Id.Text);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name.Text);
            cmd.Parameters.AddWithValue("@National_id", National_Id.Text);

            cmd.Parameters.AddWithValue("@Address", ComplainAddress.Text);
            cmd.Parameters.AddWithValue("@Nationality", Complain_Nationality.Text);
            cmd.Parameters.AddWithValue("@Complain_Against", Complain_Against.Text);

            cmd.Parameters.AddWithValue("@Complain_Date", Complain_Date.Value);

            cmd.Parameters.AddWithValue("@Date_of_Birth", Complain_reDate.Value);

            string value = "";
            bool isChecked = ComplainmG.Checked;
            if (isChecked)
            {
                value = ComplainmG.Text;
            }
            else
            {
                value = ComplainMf.Text;
            }

            cmd.Parameters.AddWithValue("@Gender", value);



            cmd.Parameters.AddWithValue("@Details", ComplainDetails.Text);
            myConnection.Open();
            int i = cmd.ExecuteNonQuery();
            myConnection.Close();

           DialogResult result= MessageBox.Show("Complain Addded..Want to add a criminal?",
           "The Question",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

           if (result== DialogResult.Yes)
           {
               this.Hide();
               CriminalInformation_Id c = new CriminalInformation_Id();
               c.Show();

           }
           else 
           {
               this.Hide();
               Complain c = new Complain();
               c.Show();
           }

            

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewComplain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complain c = new Complain();
            c.Show();
        }

        private void Complain_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }
    }
}
