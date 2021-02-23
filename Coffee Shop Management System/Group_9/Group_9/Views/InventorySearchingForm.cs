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
    public partial class InventorySearchingForm : Form
    {
        public InventorySearchingForm()
        {
            InitializeComponent();
            gridInventory.DataSource = InventoryController.GetAllInventory();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var inventory = new
            {
                Price = tbPrice.Text,
                Item_Name = tbSearch.Text,
            };
            var r = InventoryController.UpdateInventory(inventory);
            if (r)
            {
                MessageBox.Show("Success on Update");
                gridInventory.DataSource = InventoryController.GetAllInventory();
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dynamic inventory = InventoryController.GetInventory(tbSearch.Text);
            if (inventory != null)
            {
                tbPrice.Text = inventory.Price;
            }
            else
            {
                tbPrice.Text = "";
                MessageBox.Show("Can not find user");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = InventoryController.DeleteInventory(tbSearch.Text);
            if (r)
            {
                tbPrice.Text = "";
                MessageBox.Show("Success on Update");
                gridInventory.DataSource = InventoryController.GetAllInventory();

            }
            else
            {
                tbPrice.Text = "";
                MessageBox.Show("Can not Delete");
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
