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
using TimeBank.Modelos; // Me traigo la clase donde estan el modelo de la base de datos EntityDataModel

namespace TimeBank.Presentacion
{
    public partial class FormCategorias : Form
    {
        //Atrinbutos de la clase

        Categorias categoria = new Categorias();


        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            RefrescarCategorias();
            clearForm();
        }


        /* Método que me permite refrescar datos cada vez que inserto o borro registros en tabla Categorías*/

        public void RefrescarCategorias() {

            dgvCategorias.AutoGenerateColumns = false; // para evitar que se incluyan todas las columnas de clases relacionadas si las hubiera

            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                var lstCategorias = from d in db.Categorias
                                    select d;
                dgvCategorias.DataSource = lstCategorias.ToList();
            }

        }//End RefrescarCategorias



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearForm();
        }


        public void clearForm() {

            txtCategoria.Text = "";
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Eliminar con función trim espacios en blanco antes y después del contenido

            categoria.NombreCat = txtCategoria.Text.Trim();
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
            clearForm();
            RefrescarCategorias();
            MessageBox.Show("Registro insertado correctamente");
        }



        


        private void btnActualizar_Click(object sender, EventArgs e)


        {
            categoria.NombreCat = txtCategoria.Text.Trim();
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
            {

                db.Entry(categoria).State = EntityState.Modified;
                    db.SaveChanges();
            }
            clearForm();
            RefrescarCategorias();
            MessageBox.Show("Registro actualizado correctamente");

        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Habilitar el borrado cuando se acepte cuadro de dialogo Yes/No

            if (MessageBox.Show("¿Estas seguro de borrar este registro?", "OPERACION CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                    var entrada = db.Entry(categoria);

                    // si la variable está en estado detached hay que pasarla a attached

                    if (entrada.State == EntityState.Detached)
                        db.Categorias.Attach(categoria);

                    //Ahora podemos eliminar el registro de la base de datos

                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                    RefrescarCategorias();
                    clearForm();
                    MessageBox.Show("El registro se borró de forma correcta");

                }

            }

        }

        private void dgvCategorias_DoubleClick(object sender, EventArgs e)
        {
            //Asegurarnos que el foco del doble click está en las filas

            if (dgvCategorias.CurrentRow.Index != -1)
            {
                categoria.idCat = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["IDCat"].Value); // entre corchetes se pone el Name de la propiedad que dimos a esta columna
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                    categoria = db.Categorias.Where(x => x.idCat == categoria.idCat).FirstOrDefault();
                    txtCategoria.Text = categoria.NombreCat;
                }
                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }
    }// End class FormCategorias
}
