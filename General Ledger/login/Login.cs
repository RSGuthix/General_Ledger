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
    public partial class Login : Form
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            PasswordRecover passwordRecover = new PasswordRecover();
            passwordRecover.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            newUser.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM UserAccount";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["Username"].ToString());
                if (textBoxUsername.Text.Equals(dr["Username"].ToString()) && textBoxPassword.Text.Equals(dr["CurrentPassword"].ToString()))
                    MessageBox.Show("success!");
            }

            conn.Close();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
