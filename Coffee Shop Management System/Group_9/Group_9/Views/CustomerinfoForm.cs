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
    public partial class CustomerinfoForm : Form
    {
        public CustomerinfoForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterCustomer().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new CustomerSearchingForm().Show();
        }
    }
}
