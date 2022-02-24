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
    public partial class CreateNewPassword : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!");
        public SqlCommand cmd;
        public SqlCommand cmd2;
        public CreateNewPassword()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=sweappdomain.database.windows.net;Initial Catalog=GeneralLedger;Persist Security Info=True;User ID=Michael;Password=Rutherfoord!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CreateNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dateString = DateTime.Now.ToString("yyyy-MM-dd");
                string password = NewPassword.Text;
                string confirmPass = ConfirmPassword.Text;

                if (ValidatePassword(password) == true && confirmPass == password)
                {
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                    conn.Open();
                    cmd = new SqlCommand("UPDATE UserAccount SET CurrentPassword = '" + password + "' WHERE Username = '" + PasswordRecover.tempUserName + "'",conn);
                    cmd.ExecuteNonQuery();
                    //cmd2 = new SqlCommand("Insert into UserPasswords Values ('" + password + "','" + dateString + "','" + PasswordRecover.tempUserName + "')", conn);
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
            else if (isLetter == false)
            {
                MessageBox.Show("First character must be a lettter");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DebugLeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
