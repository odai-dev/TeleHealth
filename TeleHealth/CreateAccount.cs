using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleHealth
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            //Add Placholders to the TextBoxes
            UIHelpers.SetPlaceholder(txtFullName, "Full Name");
            UIHelpers.SetPlaceholder(txtEmail, "Email");
            UIHelpers.SetPlaceholder(txtPhoneNumber, "Phone Number");
            UIHelpers.SetPlaceholder(txtPassword, "Password", isPassword: true);
            UIHelpers.SetPlaceholder(txtConfirmPassword, "Confirm Password", isPassword: true);

            

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginFrom = new Form1();
            this.Close();
            loginFrom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginFrom  =  new Form1();
            this.Close();
            loginFrom.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
