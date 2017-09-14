using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LogicLayer;

namespace ChicagoKidsAndKites.Forms
{
    public partial class Registration : Form
    {
        private Logic logic = new Logic();
        private readonly List<string> _AgeGroups = new List<string>
        { "1-3", "4-5", "6-9", "10-11", "12-15","16-17", "College", "Adult", "Professional" };
        public Registration()
        {
            InitializeComponent();
            cboAge.DataSource = _AgeGroups;
        }

        #region main
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string ageGroupSelected = cboAge.SelectedValue.ToString();

            var outPutString = logic.IsVaild(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, ageGroupSelected, txtUserName.Text, txtPassword.Text);

            if (outPutString.Contains("waver") || outPutString.Contains("parent"))
            {
                MessageBox.Show(outPutString);

                if (outPutString.Contains("waver"))
                {
                    pnlWaver.Visible = true;
                    lbloutPut.Text = "This is a legal signing document, YOU MAY GET HURT WE ARE NOT RESPONSIBLE FOR THEIR SAFETY. /nPlease put your full Name in the text box below";
                }
                else
                {
                    pnlParent.Visible = true;
                }
                txtFirstName.BackColor = Color.White;
                txtLastName.BackColor = Color.White;
                txtPhoneNumber.BackColor = Color.White;
                txtPassword.BackColor = Color.White;
                txtUserName.BackColor = Color.White;
            }
            else
            {
                txtFirstName.BackColor = outPutString.Contains("first") ? Color.Red : Color.White;

                txtLastName.BackColor = outPutString.Contains("last") ? Color.Red : Color.White;

                txtPhoneNumber.BackColor = outPutString.Contains("number") ? Color.Red : Color.White;

                txtUserName.BackColor = outPutString.Contains("user") ? Color.Red : Color.White;

                txtPassword.BackColor = outPutString.Contains("pass") ? Color.Red : Color.White;

                MessageBox.Show(outPutString, "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CboAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboAge.SelectedIndex;
            if (index < 7)
            {
                lblPrice.Text = "Price for winner in this age group is a plaque!! ";
            }
            if (index >= 6 && index <= 7)
            {
                lblPrice.Text = "Price for winner in this age group is a plaque and $100!! ";
            }
            if (index == 8)
            {
                lblPrice.Text = "Price for winner in this age group is $1000!! ";
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            var t = Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (var textbox in t)
            {
                textbox.ResetText();

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }
        #endregion


        #region signature
        private void BtnDecline_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=  MessageBox.Show("If you do not agree to the terms, you are unable to be apart of this event. /nAre you sure you want to delcine", 
                                                        "Sorry", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Sorry for the invconvince, this program will now close./nHave a great day!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please click the agree to terms button");
            }
        }

        private void BtnAgree_Click(object sender, EventArgs e)
        {
            string ageGroupSelected = cboAge.SelectedText;
            var outPut = logic.IsVaild(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                ageGroupSelected, txtUserName.Text, 
                txtPassword.Text,txtSignature.Text, txtParetFirstName.Text,txtPartentLastName.Text,
                txtParentphoneNumber.Text);

            if (outPut.Contains("Successfull"))
            {
                MessageBox.Show("You are registered", "Successfull");
                pnlWaver.Visible = false;
            }
            else
                MessageBox.Show("something went wrong please call 555-555-5555");
            
        }

        #endregion

        #region Parent
        private void BtnParentBackToLogin_Click(object sender, EventArgs e)
        {
            BtnBack_Click(sender, e);
        }

        private void BtnPartentRegister_Click(object sender, EventArgs e)
        {
            string outPutString = "";
            outPutString = logic.IsVaild(txtParetFirstName.Text, txtPartentLastName.Text, txtParentphoneNumber.Text);

            if (outPutString.Contains("waver"))
            {
                MessageBox.Show(outPutString);

                if (outPutString.Contains("waver"))
                {
                    pnlWaver.Visible = true;
                    lbloutPut.Text = "This is a legal signing document, YOUR KIDS MAY GET HURT WE ARE NOT RESPONSIBLE FOR THEIR SAFETY. /nPlease put your full Name in the text box below";
                }
            }
            else
            {
                if (outPutString.Contains("first"))
                {
                    txtParetFirstName.BackColor = Color.Red;
                }
                else txtParetFirstName.BackColor = Color.White;
                if (outPutString.Contains("last"))
                {
                    txtPartentLastName.BackColor = Color.Red;
                }
                else txtPartentLastName.BackColor = Color.White;
                if (outPutString.Contains("number"))
                {
                    txtParentphoneNumber.BackColor = Color.Red;
                }
                else txtParentphoneNumber.BackColor = Color.White;
            }

        }

        #endregion


    }
}
