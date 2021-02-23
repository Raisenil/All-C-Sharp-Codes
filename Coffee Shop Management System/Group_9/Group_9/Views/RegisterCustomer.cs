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
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            var customer = new
            {
                Customer_name = NameBox.Text,
                Customer_Username = UsernameBox.Text,
                Password = PasswordBox.Text,
                Shop_id = 1,
                Phone_no= tbPhoneno.Text
            };
            var r = CustomerController.AddCustomer(customer);
            if (r)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("User not Added");
            }
        }
    }
}
