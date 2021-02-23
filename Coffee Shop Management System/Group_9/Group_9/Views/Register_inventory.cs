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
    public partial class Register_inventory : Form
    {
        public Register_inventory()
        {
            InitializeComponent();
        }

        private void Register_inventory_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBt_Click(object sender, EventArgs e)
        {
            var inventory = new
            {
                Item_Name = NameBox.Text,
                Price = PriceBox.Text,
            };
            var r = InventoryController.AddInventory(inventory);
            if (r)
            {
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item not Added");
            }
        }
    }
}
