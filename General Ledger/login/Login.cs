using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Ledger
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            this.Hide();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
        }
    }
}
