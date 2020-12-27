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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userQuery = from u in context.Usuarios
                            where u.Email == email
                            select u;
            
            Usuarios user = userQuery.First();
            
            if (user.Contraseña == password) {
                Session session = new Session(user);
            }
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
    }
}
