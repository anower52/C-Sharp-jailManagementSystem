using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JailManagement
{
    public partial class Update_Complain : Form
    {
      
        public Update_Complain(String a)
        {
            
            
            InitializeComponent();
            Complain_Id.Enabled = false;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string Sql = @"select * from Complain";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataAdapter dbad = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            dbad.Fill(dt);

            DataRow p = this.temp(a, dt);


            Complain_Id.Text = p["Complain_id"].ToString();
            Full_Name.Text = p["Full_Name"].ToString();
            National_Id.Text = p["National_id"].ToString();
            ComplainAddress.Text = p["Address"].ToString();
            Complain_Nationality.Text = p["Nationality"].ToString();
            Complain_Against.Text = p["Complain_Against"].ToString();
            ComplainDetails.Text = p["Details"].ToString();


            Complain_Date.Text = p["Creation_Date"].ToString();
            Complain_reDate.Text = p["Date_of_Birth"].ToString();
            if (p["Gender"].ToString()=="Male")
            {
                ComplainmG.Checked = true;
            }
            else{
                ComplainMf.Checked = true;
            }
            





         
        }


        public DataRow temp(string x, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["Complain_id"].ToString() == x)
                {
                    return row;
                }

            }
            return null;

        }

        private void Update_Complain_Load(object sender, EventArgs e)
        {
            
        }

        private void Update_Complain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ComplainRegisterButton_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "UPDATE Complain SET Full_Name = @Full_Name, National_id = @National_id,Date_of_Birth = @Date_of_Birth,Gender = @Gender,Address = @Address,Nationality = @Nationality,Complain_Against = @Complain_Against,Complain_Date = @Complain_Date,Details = @Details Where   Complain_id = @Complain_id ";
            
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
            MessageBox.Show("Complain Updated");
        }

        private void Complain_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complain cm = new Complain();
            cm.Show();
        }
    }
}
