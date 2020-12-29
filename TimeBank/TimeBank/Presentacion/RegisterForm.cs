using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeBank.Modelos;

namespace TimeBank.Presentacion
{
    public partial class RegisterForm : Form
    {
        Usuarios usuario = new Usuarios();
        Clientes cliente = new Clientes();
        Wallet cartera = new Wallet();

        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(int id)
        {
            InitializeComponent();

            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
            {
                usuario = db.Usuarios.Find(id);
                cliente = db.Clientes.Find(usuario.Clientes.First().idCliente);
                var carteraQuery = from c in db.Wallet
                          where c.idCliente == cliente.idCliente
                          select c;

                cartera = carteraQuery.First();
            }
        }

        private void createUser() {
            usuario.Email = emailField.Text.Trim();             // Con la función Trim eliminamos los espacios en blanco antes y después del contenido
            usuario.Contraseña = passwordField.Text.Trim();
            usuario.fecha_alta = DateTime.Now.ToLocalTime();
            cliente.Nombre = nameField.Text.Trim();
            cliente.Apellidos = passwordField.Text.Trim();
            cliente.Esadmin = checkBAdmin.Checked;
            cartera.Balance = 0.0;
            cartera.fecha = usuario.fecha_alta;


            if (emailField.Text.Trim().Equals("") || passwordField.Text.Trim().Equals("") || nameField.Text.Trim().Equals("") || passwordField.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debes rellenar los campos de Email, contraseña, Nombre y Apellidos");
            }
            else
            {
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
                {
                    db.Usuarios.Add(usuario); //Añadimos el usuario a la base de datos
                    cliente.idUser = usuario.IdUser;
                    db.Clientes.Add(cliente); //Añadimos el cliente a la base de datos
                    cartera.idCliente = cliente.idCliente;
                    db.Wallet.Add(cartera); //Añadimos la cartera a la base de datos
                    db.SaveChanges();
                }

                MessageBox.Show("Registro actualizado correctamente");
            }
        }


        private void updateUser() {
            usuario.Email = emailField.Text.Trim();             // Con la función Trim eliminamos los espacios en blanco antes y después del contenido
            usuario.Contraseña = passwordField.Text.Trim();
            cliente.Nombre = nameField.Text.Trim();
            cliente.Apellidos = surnameField.Text.Trim();
            cliente.Esadmin = checkBAdmin.Checked;

            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show("Registro actualizado correctamente");
        }

        private void openLoginPage() {
            Presentacion.LoginForm loginForm = new Presentacion.LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try {
                if (usuario.IdUser == 0)
                {
                    createUser();
                }
                else
                {
                    updateUser();
                }

                openLoginPage();
            } catch(Exception error) {
                Console.Write(error);
            }
        }
    }
}
