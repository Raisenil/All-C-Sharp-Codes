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
    public partial class AdmininfoForm : Form
    {
        public AdmininfoForm()
        {
            InitializeComponent();
            gridAdmins.DataSource = AdminController.GetAllAdmins();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dynamic admin=AdminController.GetAdmin(tbSearch.Text);
            if (admin != null)
            {
                tbName.Text = admin.Name;
                tbUsername.Text = admin.Username;
            }
            else
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Can not find user");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var admin = new
            {
                Name = tbName.Text,
                Username = tbUsername.Text,
            };
            var r = AdminController.UpdateAdmin(admin);
            if (r)
            {
                MessageBox.Show("Success on Update");
                gridAdmins.DataSource = AdminController.GetAllAdmins();
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = AdminController.DeleteAdmin(tbUsername.Text);
            if (r)
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Success on Update");
                gridAdmins.DataSource = AdminController.GetAllAdmins();

            }
            else
            {
                tbName.Text = "";
                tbUsername.Text = "";
                MessageBox.Show("Can not Delete");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void gridAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
