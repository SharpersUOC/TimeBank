using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeBank.Servicios;
using TimeBank.Modelos;

namespace TimeBank.Presentacion
{
    public partial class LoginForm : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();
        String email = "";
        String password = "";
        Action onLogin = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void setOnLogin(Action action) {
            this.onLogin = action;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userQuery = from u in context.Usuarios
                            where u.Email == email
                            select u;
            
            Usuarios user = userQuery.FirstOrDefault<Usuarios>();

            if (user == null) {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }
            
            if (user.Contraseña == password) {
                Session session = Session.GetCurrentSession();
                session.setUser(user);
                this.onLogin();
                this.Close();
                return;
            }

            MessageBox.Show("Contraseña erronea.");
        }

        private void emailField_TextChanged(object sender, EventArgs e)
        {
            TextBox emailField = sender as TextBox;
            this.email = emailField.Text;
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            TextBox passwordField = sender as TextBox;
            this.password = passwordField.Text;
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presentacion.RegisterForm registerForm = new Presentacion.RegisterForm();
            registerForm.Show();
            this.Close();
        }
    }
}
