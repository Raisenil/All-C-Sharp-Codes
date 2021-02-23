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
    public partial class OrderinfoForm : Form
    {
        public OrderinfoForm()
        {
            InitializeComponent();
            gridOrders.DataSource = OrderController.GetAllOrder();
        }

        private void OrderinfoForm_Load(object sender, EventArgs e)
        {

        }

        private void tbSearchName_Click(object sender, EventArgs e)
        {
            dynamic order = OrderController.GetAllUsername(textBox1.Text);
            if (order != null)
            {
                gridOrders.DataSource = OrderController.GetAllUsername(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Can not find order");
            }
        }

        private void btSearchitem_Click(object sender, EventArgs e)
        {
            dynamic order = OrderController.GetAllItem(tbSearch.Text);
            if (order != null)
            {
                gridOrders.DataSource = OrderController.GetAllItem(tbSearch.Text);
            }
            else
            {
                 MessageBox.Show("Can not find order");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            gridOrders.DataSource = OrderController.GetAllOrder();
        }
    }
}
