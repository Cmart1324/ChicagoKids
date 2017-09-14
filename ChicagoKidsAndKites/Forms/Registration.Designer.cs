namespace ChicagoKidsAndKites.Forms
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlWaver = new System.Windows.Forms.Panel();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.btnParentBackToLogin = new System.Windows.Forms.Button();
            this.btnPartentRegister = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParentphoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPartentLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParetFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.lbloutPut = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlWaver.SuspendLayout();
            this.pnlParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(196, 268);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(158, 54);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(119, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrice.Location = new System.Drawing.Point(79, 219);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(455, 33);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price for winnter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(119, 118);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // cboAge
            // 
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(119, 159);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(100, 21);
            this.cboAge.TabIndex = 8;
            this.cboAge.SelectedIndexChanged += new System.EventHandler(this.CboAge_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 40);
            this.txtUserName.MaxLength = 12;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 79);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(240, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 152);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login in information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 54);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear inforamtion";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(376, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 54);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back to login";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pnlWaver
            // 
            this.pnlWaver.Controls.Add(this.label7);
            this.pnlWaver.Controls.Add(this.txtSignature);
            this.pnlWaver.Controls.Add(this.btnDecline);
            this.pnlWaver.Controls.Add(this.btnAgree);
            this.pnlWaver.Controls.Add(this.lbloutPut);
            this.pnlWaver.Location = new System.Drawing.Point(12, 13);
            this.pnlWaver.Name = "pnlWaver";
            this.pnlWaver.Size = new System.Drawing.Size(592, 309);
            this.pnlWaver.TabIndex = 17;
            this.pnlWaver.Visible = false;
            // 
            // pnlParent
            // 
            this.pnlParent.Controls.Add(this.btnParentBackToLogin);
            this.pnlParent.Controls.Add(this.btnPartentRegister);
            this.pnlParent.Controls.Add(this.label9);
            this.pnlParent.Controls.Add(this.txtParentphoneNumber);
            this.pnlParent.Controls.Add(this.label10);
            this.pnlParent.Controls.Add(this.txtPartentLastName);
            this.pnlParent.Controls.Add(this.label11);
            this.pnlParent.Controls.Add(this.txtParetFirstName);
            this.pnlParent.Location = new System.Drawing.Point(50, 4);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(518, 318);
            this.pnlParent.TabIndex = 18;
            this.pnlParent.Visible = false;
            // 
            // btnParentBackToLogin
            // 
            this.btnParentBackToLogin.Location = new System.Drawing.Point(264, 196);
            this.btnParentBackToLogin.Name = "btnParentBackToLogin";
            this.btnParentBackToLogin.Size = new System.Drawing.Size(84, 38);
            this.btnParentBackToLogin.TabIndex = 29;
            this.btnParentBackToLogin.Text = "Back to login";
            this.btnParentBackToLogin.UseVisualStyleBackColor = true;
            this.btnParentBackToLogin.Click += new System.EventHandler(this.BtnParentBackToLogin_Click);
            // 
            // btnPartentRegister
            // 
            this.btnPartentRegister.Location = new System.Drawing.Point(140, 196);
            this.btnPartentRegister.Name = "btnPartentRegister";
            this.btnPartentRegister.Size = new System.Drawing.Size(89, 38);
            this.btnPartentRegister.TabIndex = 28;
            this.btnPartentRegister.Text = "Register";
            this.btnPartentRegister.UseVisualStyleBackColor = true;
            this.btnPartentRegister.Click += new System.EventHandler(this.BtnPartentRegister_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Phone Number";
            // 
            // txtParentphoneNumber
            // 
            this.txtParentphoneNumber.Location = new System.Drawing.Point(244, 107);
            this.txtParentphoneNumber.Name = "txtParentphoneNumber";
            this.txtParentphoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtParentphoneNumber.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Last Name";
            // 
            // txtPartentLastName
            // 
            this.txtPartentLastName.Location = new System.Drawing.Point(244, 71);
            this.txtPartentLastName.Name = "txtPartentLastName";
            this.txtPartentLastName.Size = new System.Drawing.Size(100, 20);
            this.txtPartentLastName.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "First Name";
            // 
            // txtParetFirstName
            // 
            this.txtParetFirstName.Location = new System.Drawing.Point(244, 35);
            this.txtParetFirstName.Name = "txtParetFirstName";
            this.txtParetFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtParetFirstName.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Signature";
            // 
            // txtSignature
            // 
            this.txtSignature.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignature.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSignature.Location = new System.Drawing.Point(252, 134);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(100, 21);
            this.txtSignature.TabIndex = 3;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(330, 255);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(137, 40);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.BtnDecline_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(106, 255);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(142, 40);
            this.btnAgree.TabIndex = 1;
            this.btnAgree.Text = "Agree to terms";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.BtnAgree_Click);
            // 
            // lbloutPut
            // 
            this.lbloutPut.Location = new System.Drawing.Point(52, 35);
            this.lbloutPut.Name = "lbloutPut";
            this.lbloutPut.Size = new System.Drawing.Size(463, 77);
            this.lbloutPut.TabIndex = 0;
            this.lbloutPut.Text = "OutPutLabel";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 343);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.pnlWaver);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlWaver.ResumeLayout(false);
            this.pnlWaver.PerformLayout();
            this.pnlParent.ResumeLayout(false);
            this.pnlParent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlWaver;
        private System.Windows.Forms.Label lbloutPut;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.Button btnParentBackToLogin;
        private System.Windows.Forms.Button btnPartentRegister;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParentphoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPartentLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParetFirstName;
    }
}