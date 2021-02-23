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
    public partial class StaffSearchingForm : Form
    {
        public StaffSearchingForm()
        {
            InitializeComponent();
            gridEmployees.DataSource = EmployeeController.GetAllStaff();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dynamic employee = EmployeeController.GetStaff(tbSearch.Text);
            if (employee != null)
            {
                tbName.Text = employee.Employee_name;
                tbUsername.Text = employee.Employee_Username;
                tbSalary.Text = employee.Salary;
                tbBonus.Text = employee.Bonus;
            }
            else
            {
                tbName.Text = "";
                tbUsername.Text = "";
                tbSalary.Text = "";
                tbBonus.Text = "";
                MessageBox.Show("Can not find user");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var employee = new
            {
                Employee_name = tbName.Text,
                Employee_Username = tbUsername.Text,
                Salary = tbSalary.Text,
                Bonus = tbBonus.Text,
            };
            var r = EmployeeController.UpdateStaff(employee);
            if (r)
            {
                MessageBox.Show("Success on Update");
                gridEmployees.DataSource = EmployeeController.GetAllStaff();
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void salary_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBonus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
