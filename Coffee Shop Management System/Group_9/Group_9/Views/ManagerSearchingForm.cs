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
    public partial class ManagerSearchingForm : Form
    {
        public ManagerSearchingForm()
        {
            InitializeComponent();
            gridEmployees.DataSource = EmployeeController.GetAllManager();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dynamic employee = EmployeeController.GetManager(tbSearch.Text);
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
                Salary=tbSalary.Text,
                Bonus=tbBonus.Text,
            };
            var r = EmployeeController.UpdateManager(employee);
            if (r)
            {
                MessageBox.Show("Success on Update");
                gridEmployees.DataSource = EmployeeController.GetAllManager();
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbBonus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = EmployeeController.DeleteManager(tbUsername.Text);
            if (r)
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Success on Update");
                gridEmployees.DataSource = EmployeeController.GetAllManager();

            }
            else
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Can not Delete");
            }
        }

        private void gridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
