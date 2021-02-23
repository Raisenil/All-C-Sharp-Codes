using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Error(object sender, EventArgs e)
        {
            MessageBox.Show("Error");
        }

        private void addUser(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Login(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string errMsg = "";
            bool hasError = false;

            if(User.Text.Equals(""))
            {
                errMsg += "Username Required";
                hasError = true;
            }
            else
            {
                username = User.Text;
            }

            if(Password.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
                hasError = true;
            }
            else
            {
                password = Password.Text;
            }

            if(!hasError)
            {
                if(username.Equals("MD.RAISUL ISLAM NILOY")&&password.Equals("19-39982-1"))
                {
                    MessageBox.Show("Logged in");
                    /*User u = new User();
                    u.Name = username;
                    u.Password = password;
                    new Form3(u).Show();*/
                }
                else
                {
                    MessageBox.Show("Invalid username or Password");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
    }
}
