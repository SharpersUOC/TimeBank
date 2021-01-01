namespace TimeBank.Presentacion
{
    partial class LoginForm
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
            this.emailField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(37, 126);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(188, 20);
            this.emailField.TabIndex = 0;
            this.emailField.TextChanged += new System.EventHandler(this.emailField_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(37, 214);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(37, 107);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(37, 159);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(37, 178);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(188, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(37, 287);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(130, 13);
            this.registerLink.TabIndex = 5;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "¿Aún no estas registrado?";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeBank.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(339, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.emailField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "TimeBank login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}