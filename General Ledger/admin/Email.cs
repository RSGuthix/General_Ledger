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
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Email has Been sent";
            string caption = "Email sent";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK) 
            {
                //Emails people (not really)
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
