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
using System.IO;

namespace JailManagement
{
    public partial class 
        CriminalInformation_Id : Form
    {
        public CriminalInformation_Id()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UserUploadpic_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg"; 
            dialog.Multiselect = false; 
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                String path = dialog.FileName; 
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) 
                {
                    textBox1.Text = path;
                    
                    
                }
                pictureBox1.BackgroundImage = Image.FromFile(path);
            }

           

        
        }

        private void CriminalInformation_Id_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewComplain nc =new NewComplain();
            nc.Show();
        }

        private void CriminalInfoAdd_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO Criminal (Criminal_id,National_id,Date_of_Birth,Gender,Address,Job,Nationality,Detention_Status,Detention_Date) VALUES (@Criminal_id,@National_id,@Date_of_Birth,@Gender,@Address,@Job,@Nationality,@Detention_Status,@Detention_Date)";

            SqlCommand cmd = new SqlCommand(sql, myConnection);
           


            cmd.Parameters.AddWithValue("@Criminal_id", Criminal_id.Text);
            cmd.Parameters.AddWithValue("@National_id", CriminalInfoId.Text);
            cmd.Parameters.AddWithValue("@Date_of_Birth", CriminalInfoDate.Value);

            cmd.Parameters.AddWithValue("@Address", CriminalInfoAddress.Text);
            cmd.Parameters.AddWithValue("@Job", CriminalInfoJob.Text);

            cmd.Parameters.AddWithValue("@Nationality", CriminalInfoNationality.Text);
            MessageBox.Show(dateTimePicker2.Value.ToString());
            if (CriminalDetentionYes.Checked)
            {
                cmd.Parameters.AddWithValue("@Detention_Status", CriminalDetentionYes.Text);
                cmd.Parameters.AddWithValue("@Detention_Date", dateTimePicker2.Value);
            }
            else{

                cmd.Parameters.AddWithValue("@Detention_Status", CriminalDetentionNo.Text);

                cmd.Parameters.AddWithValue("@Detention_Date", DateTime.Now);
                

            }
            
           

            string value = "";
            bool isChecked = CrimialInfomale.Checked;
            if (isChecked)
            {
                value = CrimialInfomale.Text;
            }
            else
            {
                value = CriminalInfoFemale.Text;
            }

            cmd.Parameters.AddWithValue("@Gender", value);

            myConnection.Open();
            int i = cmd.ExecuteNonQuery();
            myConnection.Close();


            MessageBox.Show("Criminal Added Succesfully");

        }

        private void CriminalDetentionYes_CheckedChanged(object sender, EventArgs e)
        {
            if (CriminalDetentionYes.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Complain_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void CriminalInformation_Id_Load(object sender, EventArgs e)
        {

        }
    }
}
