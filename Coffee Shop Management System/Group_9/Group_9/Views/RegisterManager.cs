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
    public partial class RegisterManager : Form
    {
        public RegisterManager()
        {
            InitializeComponent();
        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            var employee = new
            {
                Employee_name = NameBox.Text,
                Employee_Username = UsernameBox.Text,
                Password = PasswordBox.Text,
                Designation="Manager",
                Salary=SalaryBox.Text,
                Shop_id = 1,
                Bonus = "0"
            };
            var r = EmployeeController.AddEmployee(employee);
            if (r)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("User not Added");
            }
        }

        private void SalaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
