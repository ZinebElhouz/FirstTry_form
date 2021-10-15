
namespace FirstTry
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.UserDetails = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.UserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(25, 106);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(42, 20);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(25, 46);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(60, 20);
            this.Prenom.TabIndex = 1;
            this.Prenom.Text = "Prenom";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(25, 172);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(25, 243);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(28, 20);
            this.Tel.TabIndex = 3;
            this.Tel.Text = "Tel";
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(119, 43);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(219, 27);
            this.textPrenom.TabIndex = 4;
            this.textPrenom.TextChanged += new System.EventHandler(this.textPrenom_TextChanged);
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(119, 240);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(219, 27);
            this.textTel.TabIndex = 5;
            this.textTel.TextChanged += new System.EventHandler(this.textTel_TextChanged);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(119, 103);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(219, 27);
            this.textNom.TabIndex = 6;
            this.textNom.TextChanged += new System.EventHandler(this.textNom_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(119, 169);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(219, 27);
            this.textEmail.TabIndex = 7;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // UserDetails
            // 
            this.UserDetails.Controls.Add(this.textNom);
            this.UserDetails.Controls.Add(this.textTel);
            this.UserDetails.Controls.Add(this.textEmail);
            this.UserDetails.Controls.Add(this.Tel);
            this.UserDetails.Controls.Add(this.Prenom);
            this.UserDetails.Controls.Add(this.textPrenom);
            this.UserDetails.Controls.Add(this.Nom);
            this.UserDetails.Controls.Add(this.Email);
            this.UserDetails.Location = new System.Drawing.Point(27, 12);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(424, 313);
            this.UserDetails.TabIndex = 8;
            this.UserDetails.TabStop = false;
            this.UserDetails.Text = "User Details";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(503, 71);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(84, 24);
            this.Male.TabIndex = 8;
            this.Male.TabStop = true;
            this.Male.Text = "Homme";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(503, 118);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(79, 24);
            this.Female.TabIndex = 9;
            this.Female.TabStop = true;
            this.Female.Text = "Femme";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Submit.Location = new System.Drawing.Point(533, 221);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(143, 41);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.UserDetails);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.UserDetails.ResumeLayout(false);
            this.UserDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.GroupBox UserDetails;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Button Submit;
    }
}

