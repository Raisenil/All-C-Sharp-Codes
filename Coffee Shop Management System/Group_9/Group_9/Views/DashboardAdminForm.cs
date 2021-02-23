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
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
        }

        private void Updatebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new AdmininfoForm().Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            new ManagerinfoForm().Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            new StaffinfoForm().Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new CustomerinfoForm().Show();
        }

        private void btnSeeorder_Click(object sender, EventArgs e)
        {
            new OrderinfoForm().Show();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            new InventoryinfoForm().Show();
        }
    }
}
