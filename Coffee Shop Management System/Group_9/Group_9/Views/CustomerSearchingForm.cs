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
    public partial class CustomerSearchingForm : Form
    {
        public CustomerSearchingForm()
        {
            InitializeComponent();
            gridCustomers.DataSource = CustomerController.GetAllCustomers();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dynamic customer = CustomerController.GetCustomer(tbSearch.Text);
            if (customer != null)
            {
                tbName.Text = customer.Customer_name;
                tbUsername.Text = customer.Customer_Username;
                tbPhoneno.Text = customer.Phone_no;
            }
            else
            {
                tbName.Text = "";
                tbUsername.Text = "";
                tbPhoneno.Text = "";
                MessageBox.Show("Can not find user");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = CustomerController.DeleteCustomer(tbUsername.Text);
            if (r)
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Success on Update");
                gridCustomers.DataSource = CustomerController.GetAllCustomers();

            }
            else
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Can not Delete");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = new
            {
                Customer_name = tbName.Text,
                Customer_Username = tbUsername.Text,
                Phone_no = tbPhoneno.Text,
            };
            var r = CustomerController.UpdateCustomer(customer);
            if (r)
            {
                MessageBox.Show("Success on Update");
                gridCustomers.DataSource = CustomerController.GetAllCustomers();
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void tbPhoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
