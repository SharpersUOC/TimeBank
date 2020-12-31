using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeBank.Modelos;

namespace TimeBank.Presentacion
{
    public partial class FormSelectOferta : Form
    {

        //Atributos de la clase

        Usuarios usuario = new Usuarios();
        Clientes cliente = new Clientes();
        Ofertas selectedOferta=new Ofertas();

        public FormSelectOferta()
        {
            InitializeComponent();
        }

        private void FormSelectOferta_Load(object sender, EventArgs e)
        {
            Refrescar();
        }


        //Método para recargar los registros a mostrar en el datagridview

        private void Refrescar()
        {
            dgvSelecOferta.AutoGenerateColumns = false; // para que sólo muestre las columnas especificadas
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                var lstDatosOfertas = (from c in db.Clientes
                                       join u in db.Usuarios
                                       on c.idUser equals u.IdUser
                                       join o in db.Ofertas
                                       on u.IdUser equals o.idUser
                                       select new
                                       {
                                           idOferta = o.idOferta,
                                           Nombre = c.Nombre,
                                           Apellidos = c.Apellidos,
                                           Titulo = o.Titulo,
                                           Tiempo = o.Tiempo
                                       }

                                     ).ToList();

                dgvSelecOferta.DataSource = lstDatosOfertas.ToList();
            }
        }// End Refrescar

        //Método para mostrar el detalle de la oferta cuando cliquemos el boton de oferta
        private void dgvSelecOferta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvSelecOferta.CurrentRow.Cells["idOfer"].Value);
            Presentacion.OfertasPresentacion.OfertaPage ofertaPage = new Presentacion.OfertasPresentacion.OfertaPage(id);
            ofertaPage.Show();
        }


        //Propiedad que asigna como oferta seleccionada la obtenida al hacer doble click



        public Ofertas SelectedOferta {
            get { return selectedOferta; }
        }

        private void dgvSelecOferta_DoubleClick(object sender, EventArgs e)
        {

            //asegurarnos que el doble click se enfoca solo en las filas

            if (dgvSelecOferta.CurrentRow.Index != -1)
            {

                selectedOferta.idOferta = Convert.ToInt32(dgvSelecOferta.CurrentRow.Cells["idOfer"].Value);
                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
                {

                    selectedOferta = db.Ofertas.Where(x => x.idOferta == selectedOferta.idOferta).FirstOrDefault();

                }
            }
                
                this.Close(); //cerramos formulario
        } //



    }// End Class FormSelectOferta
}
