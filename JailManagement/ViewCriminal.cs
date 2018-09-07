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
    public partial class UpdateCriminal : Form
    {
        public UpdateCriminal()
        {
            InitializeComponent();

            JailManagementDataContext dc = new JailManagementDataContext();
            Array id = dc.Criminals.Select(c => c.Criminal_id).Distinct().ToArray();

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();

            foreach (string c in id)
            {

                autoCompleteData.Add(c);
            }


            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = autoCompleteData;
            

        }

        private void ViewCriminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewCriminal_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");
            myConnection.Open();
            SqlCommand objcmd = new SqlCommand("SELECT * FROM Criminal", myConnection);

            SqlDataAdapter adp = new SqlDataAdapter(objcmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            CriminalGridView.DataSource = dt;
            
        }

        private void CriminalGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceView pv = new PoliceView();
            pv.Show();
        }

        private void Complain_Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 wv = new Form1();
            wv.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anowe\OneDrive\Documents\Visual Studio 2012\Projects\JailManagement\JailManagement\Employee.mdf;Integrated Security=True;Connect Timeout=30");

            string Sql = @"select * from Criminal where Criminal_id= '" + textBox1.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataAdapter dbad = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            dbad.Fill(dt);
            CriminalGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
