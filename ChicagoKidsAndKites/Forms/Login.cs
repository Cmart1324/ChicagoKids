using System;
using System.Windows.Forms;
using LogicLayer;

namespace ChicagoKidsAndKites.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegaistation_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            Hide();

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            Registration reg = new Registration();

           if(logic.IsVaildLogin(txtUserName.Text, txtPass.Text))
            {
                reg.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login unsuccessfull. Please try to use different user name and password");
            }

        }
    }
}
