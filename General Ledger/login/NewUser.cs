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
using System.Text.RegularExpressions;

namespace General_Ledger
{
    public partial class NewUser : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd;
        public SqlCommand cmd2;
        public String accountType;
        public NewUser()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!";
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool ValidatePassword(String password)
        {
            bool isLetter = char.IsLetter(password[0]);
            if (string.IsNullOrEmpty(password))
                throw new Exception("Password is empty");

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,40}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one lower case letter.");
                return false;
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one upper case letter.");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(password))
            {
                MessageBox.Show("Password should not be lesser than 8 or greater than 40 characters.");
                return false;
            }
            else if (!hasNumber.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one numeric value.");
                return false;
            }

            else if (!hasSymbols.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one special case character.");
                return false;
            }
            else if (isLetter == false) {
                MessageBox.Show("First character must be a lettter");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var dateString = DateTime.Now.ToString("yyyy-MM-dd");
                string fName = boxFirstName.Text;
                string lName = boxLastName.Text;
                string birthday = "2000-01-01";
                string city = boxAddressCity.Text;
                string address = boxAddressStreet.Text;
                string state = boxAddressState.Text;
                string zip = zipcodeBox.Text;
                string email = boxEmail.Text;
                string username = boxUsername.Text;
                string password = boxPassword1.Text;
                string reTypePassword = boxPassword2.Text;
                if (ValidatePassword(password) == true)
                {
                    if (password == reTypePassword)
                    {
                        this.Close();
                        Login login = new Login();
                        login.Show();
                        conn.Open();
                        cmd = new SqlCommand("Insert into UserAccount Values('" + username + "','" + password + "','" + accountType + "','" + fName + "','" + lName + "','" + email + "','" + address + "','" + city + "','" + state + "','" + zip + "','" + birthday + "','2022-01-01','Blue')", conn);
                        cmd2 = new SqlCommand("Insert into UserPasswords Values ('" + password + "','" + dateString + "','" + username + "')",conn);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                conn.Close();
            }
    }

        private void boxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxPassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioAccountant_CheckedChanged(object sender, EventArgs e)
        {
            if(radioAccountant.Checked)
                accountType = radioAccountant.Text;
        }

        private void radioManager_CheckedChanged(object sender, EventArgs e)
        {
            if(radioManager.Checked)
                accountType = radioManager.Text;

        }

        private void radioAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            if(radioAdministrator.Checked)
                accountType = radioAdministrator.Text;
        }
    }
}
