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
    public partial class InventoryinfoForm : Form
    {
        public InventoryinfoForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Register_inventory().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new InventorySearchingForm().Show();
        }
    }
}
