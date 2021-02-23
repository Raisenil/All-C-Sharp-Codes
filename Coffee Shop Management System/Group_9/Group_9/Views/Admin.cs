using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_9.Controllers;

namespace Group_9.Views
{
    public partial class AdminLoginMenu : Form
    {
        public AdminLoginMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            var r = AdminController.AuthenticateAdmin(username, password);
            if (r != null)
            {
                new DashboardAdminForm().Show();
            }
            else
            {
                MessageBox.Show("User not valid");
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationBT_Click(object sender, EventArgs e)
        {
            new RegisterAdmin().Show();
        }
    }
}
