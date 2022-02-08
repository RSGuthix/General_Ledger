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

namespace General_Ledger
{
    public partial class ModifyUsers : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd;
        public ModifyUsers()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("User information has been Updated", "Update Successful", MessageBoxButtons.OK);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetUser();
        }

        private DataTable GetUser()
        {
            DataTable dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM UserAccount", conn);
                
            conn.Open();

             SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            conn.Close();

            return dt;
        }

        private void ModifyUsers_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generalLedgerDataSet.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter.Fill(this.generalLedgerDataSet.UserAccount);

        }
    }
}
