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
    public partial class Complain : Form
    {
       

        public Complain()
        {
            InitializeComponent();

            JailManagementDataContext dc = new JailManagementDataContext();
            Array names = dc.Complains.Select(c => c.Full_Name).Distinct().ToArray();

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();

            foreach (string c in names)
            {

                autoCompleteData.Add(c);
            }


            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = autoCompleteData;
            
            
        }
       

        private void ComplainListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Complain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddnewComplainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewComplain nc = new NewComplain();
            nc.Show();
        }

        private void Complain_Load(object sender, EventArgs e)
        {

            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");
            myConnection.Open();
            SqlCommand objcmd = new SqlCommand("SELECT * FROM Complain", myConnection);

            SqlDataAdapter adp = new SqlDataAdapter(objcmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            ComplainListGridView.DataSource = dt;
           
           
            
        }
        private void Complain_view(object sender, EventArgs e)
        {
           

            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");
            myConnection.Open();
            SqlCommand objcmd = new SqlCommand("SELECT * FROM Complain", myConnection);

            SqlDataAdapter adp = new SqlDataAdapter(objcmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            ComplainListGridView.DataSource = dt;

          

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedrowindex = ComplainListGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = ComplainListGridView.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["Complain_id"].Value);

            

            this.Hide();
            Update_Complain uc = new Update_Complain(a);
            uc.Show();
             

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = ComplainListGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = ComplainListGridView.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["Complain_id"].Value);


            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "Delete From Complain Where   Complain_id = @Complain_id ";

            SqlCommand cmd = new SqlCommand(sql, myConnection);

            cmd.Parameters.AddWithValue("@Complain_id", a);
            
            myConnection.Open();
            int i = cmd.ExecuteNonQuery();
            myConnection.Close();
            
            MessageBox.Show("Complain Deleted");
            this.Hide();
            Complain fr = new Complain();
            fr.Show();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceView fr = new PoliceView();
            fr.Show();
           
        }

        private void ComplainSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string Sql = @"select * from Complain where Full_Name= '"+textBox1.Text+"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataAdapter dbad = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            dbad.Fill(dt);
            ComplainListGridView.DataSource = dt;                                 
        }

        private void Complain_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }


    }
}
