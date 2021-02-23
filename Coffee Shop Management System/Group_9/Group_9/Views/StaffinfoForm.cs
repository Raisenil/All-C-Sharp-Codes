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
    public partial class StaffinfoForm : Form
    {
        public StaffinfoForm()
        {
            InitializeComponent();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            new RegisterStaff().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new StaffSearchingForm().Show();
        }
    }
}
