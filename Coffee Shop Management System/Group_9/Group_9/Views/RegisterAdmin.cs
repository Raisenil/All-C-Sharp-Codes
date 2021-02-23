using Group_9.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_9.Views
{
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            var admin = new
            {
                Name = NameBox.Text,
                Username = UsernameBox.Text,
                Password = PasswordBox.Text,
                Shop_id = 1
            };
            var r= AdminController.AddAdmin(admin);
            if (r)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("User not Added");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
