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
                var lstUsuarios = from d in db.Usuarios
                                  select d;
                dgvUsuarios.DataSource = lstUsuarios.ToList();
            }

        } // End Refrescar

        #endregion


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm() {

            txtEmail.Text = txtContraseña.Text = "";
            btnBorrar.Enabled = false; // no se podrá borrar después de haber activado esta función
            btnActualizar.Enabled = false; // no se podrá actualizar despues de haber activado esta función
            //usuario.IdUser = 0;  Esto no lo tengo claro
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtEmail.Text.Trim();             // Con la función Trim eliminamos los espacios en blanco antes y después del contenido
            usuario.Contraseña = txtContraseña.Text.Trim();
            usuario.fecha_alta = DateTime.Now.ToLocalTime();
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
            ClearForm();
            Refrescar();
            MessageBox.Show("Registro insertado correctamente");
        }

       

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            //asegurarnos que el doble click se enfoca solo en las filas

            if (dgvUsuarios.CurrentRow.Index != -1)
            {

                usuario.IdUser = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUser"].Value); //entre corchetes se da el nombre de la propiedad Name

                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
                {

                    usuario = db.Usuarios.Where(x => x.IdUser == usuario.IdUser).FirstOrDefault();
                    txtEmail.Text = usuario.Email;
                    txtContraseña.Text = usuario.Contraseña;
                }

                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtEmail.Text.Trim();             // Con la función Trim eliminamos los espacios en blanco antes y después del contenido
            usuario.Contraseña = txtContraseña.Text.Trim();
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
            {
                db.Entry(usuario).State =EntityState.Modified;
                db.SaveChanges();
            }
            ClearForm();
            Refrescar();
            MessageBox.Show("Registro actualizado correctamente");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Habilitar el borrado cuando se acepte cuadro de dialogo Yes/No
            if (MessageBox.Show("¿Estas seguro de borrar este registro", "OPERACION CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                    var entrada = db.Entry(usuario);
                    // si la variable está en estado detached hay que pasarla a attached
                    if (entrada.State == EntityState.Detached)
                        db.Usuarios.Attach(usuario);
                    //Ahora podemos eliminar el registro de la base de datos
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                    Refrescar();
                    ClearForm();
                    MessageBox.Show("El registro se borró de forma correcta");

                }
            }
        }
    } // End class
}
