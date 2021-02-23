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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit(object sender, EventArgs e)
        {
            User u = new User();
            u.Fname = FName.Text;
            u.Lname = LName.Text;
            u.Month = cmonth.SelectedItem.ToString();
            u.Day = cday.SelectedItem.ToString();
            u.Year = cyear.SelectedItem.ToString();
            u.Gender = cgender.SelectedItem.ToString();
            u.Email = Email.Text;
            u.Pass = Password.Text;
            u.Security = SecurityQuestion.SelectedItem.ToString();
            u.Securityans = SecurityAnswer.Text;
            u.Address = Address.Text;
            u.City = City.Text;
            u.State = State.SelectedItem.ToString();
            u.Phone = Phone.Text;

            new Form3(u).Show();
        }

        private void cmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
