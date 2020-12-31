using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using TimeBank.Modelos; // Me traigo la clase donde estan el modelo de la base de datos EntityDataModel

namespace TimeBank.Presentacion
{
    public partial class FormUsuarios : Form
    {
        //Atributo de la clase

        Usuarios usuario = new Usuarios();
        Clientes cliente = new Clientes();
        Wallet cartera = new Wallet();


        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Refrescar();
            ClearForm();
        }


        #region HELPER



        /* Método que me permite refrescar datos cada vez que inserto o borro registros */

        public void Refrescar() {

            dgvUsuarios.AutoGenerateColumns = false;     //Evitar que se incluyan las columnas de las clases relacionadas
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())

            {
                var lstUsuarios = (from u in db.Usuarios
                                   join c in db.Clientes
                                   on u.IdUser equals c.idUser
                                   join w in db.Wallet
                                   on c.idCliente equals w.idCliente
                                   select new

                                   {
                                       Nombre = c.Nombre,
                                       Apellidos = c.Apellidos,
                                       Esadmin = c.Esadmin,
                                       Email = u.Email,
                                       Contraseña = u.Contraseña,
                                       fecha_alta = u.fecha_alta,
                                       Balance = w.Balance,
                                       IdUser = u.IdUser,
                                       idCliente = c.idCliente,
                                       idWallet=w.idWallet
                                  }
                    ).ToList();

                dgvUsuarios.DataSource = lstUsuarios.ToList();
            }

        } // End Refrescar

        #endregion


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm() {

            txtEmail.Text = txtContraseña.Text = txtNombre.Text=txtApellidos.Text="";
            checkBAdmin.Checked = false;
            btnBorrar.Enabled = false; // no se podrá borrar después de haber activado esta función
            btnActualizar.Enabled = false; // no se podrá actualizar despues de haber activado esta función
            //usuario.IdUser = 0;  Esto no lo tengo claro
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtEmail.Text.Trim();             // Con la función Trim eliminamos los espacios en blanco antes y después del contenido
            usuario.Contraseña = txtContraseña.Text.Trim();
            usuario.fecha_alta = DateTime.Now.ToLocalTime();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellidos = txtApellidos.Text.Trim();
            cliente.Esadmin = checkBAdmin.Checked;
            cartera.Balance = 0.0;
            cartera.fecha = usuario.fecha_alta;


            if (txtEmail.Text.Trim().Equals("") || txtContraseña.Text.Trim().Equals("") || txtNombre.Text.Trim().Equals("") || txtApellidos.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debes rellenar los campos de Email, contraseña, Nombre y Apellidos");
            }
            else
            {
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
                {

                    db.Usuarios.Add(usuario); //Añadimos el usuario a la base de datos
                    //db.SaveChanges();
                    cliente.idUser = usuario.IdUser;
                    db.Clientes.Add(cliente); //Añadimos el cliente a la base de datos
                    //db.SaveChanges();
                    cartera.idCliente = cliente.idCliente;
                    db.Wallet.Add(cartera); //Añadimos la cartera a la base de datos
                    db.SaveChanges();

                }//End using
                ClearForm();
                Refrescar();
                MessageBox.Show("Registro USUARIO/CLIENTE/WALLET insertado correctamente");
            }//end else
           
        }//end btnInsertarClick

       

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            //asegurarnos que el doble click se enfoca solo en las filas

            if (dgvUsuarios.CurrentRow.Index != -1)
            {

                usuario.IdUser = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUser"].Value); //entre corchetes se da el nombre de la propiedad Name
                cliente.idCliente = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idClient"].Value);
                //cartera.idWallet = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idWallet"].Value);


                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
                {

                    usuario = db.Usuarios.Where(x => x.IdUser == usuario.IdUser).FirstOrDefault();
                    txtEmail.Text = usuario.Email;
                    txtContraseña.Text = usuario.Contraseña;
                    cliente = db.Clientes.Where(x => x.idCliente == cliente.idCliente).FirstOrDefault();
                    txtNombre.Text = cliente.Nombre;
                    txtApellidos.Text = cliente.Apellidos;
                    checkBAdmin.Checked = cliente.Esadmin;
                }

                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtEmail.Text.Trim();             // Con la función Trim eliminamos los espacios en blanco antes y después del contenido
            usuario.Contraseña = txtContraseña.Text.Trim();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellidos = txtApellidos.Text.Trim();
            cliente.Esadmin = checkBAdmin.Checked;
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
            {
                db.Entry(usuario).State =EntityState.Modified;
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();

            }
            ClearForm();
            Refrescar();
            MessageBox.Show("Registro actualizado correctamente");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Habilitar el borrado cuando se acepte cuadro de dialogo Yes/No
            if (MessageBox.Show("¿Estas seguro de borrar este registro?", "OPERACION CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                    var entrada = db.Entry(usuario);
                    // si la variable está en estado detached hay que pasarla a attached
                    if (entrada.State == EntityState.Detached)
                        db.Usuarios.Attach(usuario);
                    //Ahora podemos eliminar el registro de la base de datos
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                }
            }

            Refrescar();
            ClearForm();
            MessageBox.Show("El registro se borró en tablas USUARIOS/CLIENTES/ WALLET de forma correcta");
        }//End btnBorrar_Click


  


    } // End class
}
