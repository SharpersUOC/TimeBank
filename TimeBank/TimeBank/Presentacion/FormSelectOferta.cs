using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TimeBank.Modelos;
using TimeBank.Servicios;


namespace TimeBank.Presentacion
{
    public partial class FormSelectOferta : Form
    {

        //Atributos de la clase

        Usuarios currentuser;
        Clientes cliente = new Clientes();
        Ofertas selectedOferta=new Ofertas();
        Session currentsession;



        public FormSelectOferta()
        {
            InitializeComponent();
            currentsession = Servicios.Session.GetCurrentSession();
            currentuser = currentsession.getCurrentUser();
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

                var lstDatosOfertas = from d in db.ResumenOfertas
                                      where (d.idUser!= currentuser.IdUser && d.ou == currentuser.IdUser && d.idEstado == 2)
                                      select d;

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
