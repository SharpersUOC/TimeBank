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

namespace TimeBank.Presentacion.DemandasPresentacion
{
    public partial class DemandasPage : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();

        public DemandasPage()
        {
            InitializeComponent();
            populateTable();
        }

        private void populateTable()
        {
            var ofertasQuery = from demanda in context.Demandas
                               select new
                               {
                                   id = demanda.idDemanda,
                                   Titulo = demanda.Titulo,
                                   Categoria = demanda.Categorias.NombreCat,
                                   Publicado = demanda.fecha_dem,
                                   Usuario = demanda.Usuarios.Email,
                               };

            this.demandasGridView.DataSource = ofertasQuery.ToList();

            var buttonColumn = new DataGridViewButtonColumn();

            {
                buttonColumn.Text = "Ver";
                buttonColumn.UseColumnTextForButtonValue = true;
            }

            this.demandasGridView.Columns.Add(buttonColumn);

            demandasGridView.CellClick += new DataGridViewCellEventHandler(demandasDataView_CellClick);
        }

        private void demandasDataView_CellClick(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[1].Value);
            // Presentacion.DemandasPresentacion.DemandaPage demandaPage = new Presentacion.DemandasPresentacion.DemandaPage(id);
            // demandaPage.Show();
        }
    }
}