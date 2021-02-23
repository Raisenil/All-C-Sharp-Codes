using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Practice
{
    public partial class Form3 : Form
    {
        public Form3(User u)
        {
            InitializeComponent();
            string output = String.Format("First Name: {0}" +
                "\nLast Name: {1}" +
                "\nDate of Birth: {2} {3} {4}" +
                "\nGender : {5}" +
                "\nEmail : {6}" +
                "\nPassWord : {7}" +
                "\nSecurity Question : {8}" +
                "\nSecurity Ans : {9}" +
                "\nAddress : {10}" +
                "\nCity : {11}" +
                "\nstate : {12}" +
                "\nPhone : {13}", u.Fname, u.Lname, u.Day, u.Month, u.Year, u.Gender, u.Email, u.Pass, u.Security, u.Securityans, u.Address, u.City, u.State, u.Phone); ;
            ///MessageBox.Show(output);
            rtOutput.Text = output;
        }
    }
}
