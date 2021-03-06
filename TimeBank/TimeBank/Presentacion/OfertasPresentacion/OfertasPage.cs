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

namespace TimeBank.Presentacion.OfertasPresentacion
{
    public partial class OfertasPage : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();

        public OfertasPage()
        {
            InitializeComponent();
            populateTable();

            var buttonColumn = new DataGridViewButtonColumn();

            {
                buttonColumn.Text = "Ver";
                buttonColumn.UseColumnTextForButtonValue = true;
            }

            this.ofertasDataGrid.Columns.Add(buttonColumn);

            ofertasDataGrid.CellClick += new DataGridViewCellEventHandler(ofertasDataGrid_CellClick);
        }

        private void populateTable() {
            var ofertasQuery = from oferta in context.Ofertas
                               select new
                               {
                                   id = oferta.idOferta,
                                   Titulo = oferta.Titulo,
                                   Tiempo = oferta.Tiempo,
                                   Categoria = oferta.Categorias.NombreCat,
                                   Publicado = oferta.fecha_ofer,
                                   Usuario = oferta.Usuarios.Email,
                               };

            this.ofertasDataGrid.DataSource = ofertasQuery.ToList();
        }

        public override void Refresh()
        {
            base.Refresh();

            this.populateTable();
        }

        private void ofertasDataGrid_CellClick(object sender, EventArgs e) {
            DataGridView dataGridView = sender as DataGridView;
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[1].Value);
            Presentacion.OfertasPresentacion.OfertaPage ofertaPage = new Presentacion.OfertasPresentacion.OfertaPage(id);
            ofertaPage.parent = this;
            ofertaPage.Show();
        }
    }
}