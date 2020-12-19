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
        List<Ofertas> ofertas = new List<Ofertas>();

        public OfertasPage()
        {
            InitializeComponent();
            loadOfertas();
        }

        private void loadOfertas() {
            System.Linq.IQueryable<TimeBank.Modelos.Ofertas> ofertasQuery = from oferta in context.Ofertas
                           select oferta;

            this.ofertas = ofertasQuery.ToList<Ofertas>();
        }

        private void populateTable() {
            ofertasDataGrid.DataSource = this.ofertas;
        }
    }
}