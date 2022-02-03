using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Ledger.admin
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Show();
        }

        private void ModifyUsers_Click(object sender, EventArgs e)
        {
            ModifyUsers modifyUsers = new ModifyUsers();
            modifyUsers.Show();
        }

        private void ExpiredPasswords_Click(object sender, EventArgs e)
        {
            ExpiredPasswords expiredPasswords = new ExpiredPasswords();
            expiredPasswords.Show();
        }
    }
}
