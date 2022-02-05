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
    public partial class PasswordRecover : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd = new SqlCommand();
        public PasswordRecover()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                bool boolean = true;
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT *FROM UserAccount";
                SqlDataReader dr = cmd.ExecuteReader();
                while(boolean)
                {
                    dr.Read();
                    if (textBoxUsername.Text.Equals(dr["Username"].ToString()) && textBoxEmail.Text.Equals(dr["Email"].ToString() /*&& richTextBoxSecAns.Text.Equals(dr["SecurityQuestionAnswer"].ToString()*/))
                    {
                        MessageBox.Show("Success");
                        boolean = false;
                    }
                   
                }
                if (boolean == false)
                {
                    this.Close();
                    CreateNewPassword createNewPassword = new CreateNewPassword();
                    createNewPassword.Show();
                    conn.Close();
                }
            } 
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void PasswordRecover_Load(object sender, EventArgs e)
        {

        }
    }
}
