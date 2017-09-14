namespace ChicagoKidsAndKites.Forms
{
    partial class Form1
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnRegaistation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(97, 136);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 23);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(97, 93);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            // 
            // btnRegaistation
            // 
            this.btnRegaistation.Location = new System.Drawing.Point(97, 197);
            this.btnRegaistation.Name = "btnRegaistation";
            this.btnRegaistation.Size = new System.Drawing.Size(100, 23);
            this.btnRegaistation.TabIndex = 5;
            this.btnRegaistation.Text = "Register";
            this.btnRegaistation.UseVisualStyleBackColor = true;
            this.btnRegaistation.Click += new System.EventHandler(this.BtnRegaistation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Or";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegaistation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnRegaistation;
        private System.Windows.Forms.Label label3;
    }
}

