﻿namespace TimeBank.Presentacion
{
    partial class RegisterForm
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
            this.surnameField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBAdmin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(126, 174);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(203, 20);
            this.surnameField.TabIndex = 18;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(126, 142);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(147, 20);
            this.nameField.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // checkBAdmin
            // 
            this.checkBAdmin.AutoSize = true;
            this.checkBAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBAdmin.Location = new System.Drawing.Point(50, 313);
            this.checkBAdmin.Name = "checkBAdmin";
            this.checkBAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBAdmin.Size = new System.Drawing.Size(89, 17);
            this.checkBAdmin.TabIndex = 15;
            this.checkBAdmin.Text = "Administrador";
            this.checkBAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apelllidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(126, 222);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(185, 20);
            this.emailField.TabIndex = 12;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(126, 255);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(185, 20);
            this.passwordField.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(50, 373);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 19;
            this.registerBtn.Text = "Registrarse";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerBtn;
    }
}