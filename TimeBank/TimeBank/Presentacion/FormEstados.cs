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
    public partial class FormEstados : Form
    {
        //Atributo de la clase

        Estado estado = new Estado();
        public FormEstados()
        {
            InitializeComponent();
        }

        private void FormEstados_Load(object sender, EventArgs e)
        {
            RefrescarEstados();
            clearForm();
        }

        /* Método que me permite refrescar datos cada vez que inserto o borro registros */

        public void RefrescarEstados() {

            dgvEstados.AutoGenerateColumns = false; //Evitar que se incluyan columnas de las clases relacionadas
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())

            {
                var lstEstados = from d in db.Estado
                                  select d;
                dgvEstados.DataSource = lstEstados.ToList();
            }

        } // End Refrescar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearForm();
        }


        private void clearForm() {
            txtEstado.Text = "";
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            estado.NombreEstado = txtEstado.Text.Trim(); // Trim elimina espacios en blanco antes y despues de texto
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {
                db.Estado.Add(estado);
                db.SaveChanges();
            }
            clearForm();
            RefrescarEstados();
            MessageBox.Show("Registro insertado correctamente");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            estado.NombreEstado = txtEstado.Text.Trim();
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                db.Entry(estado).State = EntityState.Modified;
                db.SaveChanges();
            }
            clearForm();
            RefrescarEstados();
            MessageBox.Show("Registro actualizado correctamente");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Habilitar el borrado cuando se acepte cuadro de dialogo Yes/No
            if (MessageBox.Show("¿Estas seguro de borrar este registro?", "OPERACION CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                    var entrada = db.Entry(estado);

                    // si la variable está en estado detached hay que pasarla a attached

                    if (entrada.State == EntityState.Detached) db.Estado.Attach(estado);

                    // Eliminamos el registro

                    db.Estado.Remove(estado);
                    db.SaveChanges();
                    RefrescarEstados();
                    clearForm();
                    MessageBox.Show("El registro se borró de forma correcta");
                }
            }
        }

        private void dgvEstados_DoubleClick(object sender, EventArgs e)
        {
            //asegurarnos que el doble click se enfoca solo en las filas


            if (dgvEstados.CurrentRow.Index != -1) {

                estado.idEstado = Convert.ToInt32(dgvEstados.CurrentRow.Cells["IDEstado"].Value);
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                    estado = db.Estado.Where(x => x.idEstado == estado.idEstado).FirstOrDefault();
                    txtEstado.Text = estado.NombreEstado;
                }
                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;

            }
        }



    }//End class FormEstados

}
