using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using TimeBank.Modelos;

namespace TimeBank.Presentacion.OrdenesPresentacion
{
    public partial class OrdenesPage : Form
    {
        DbContext context = new BancoDeTiempoEntities();
        public OrdenesPage()
        {
            InitializeComponent();
        }

        public List<Orden> getOrdenes() {
                var query =  from ordenes in new BancoDeTiempoEntities().Orden
                       select ordenes;

            return query.ToList();
        }

        private void OrdenesPage_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = getOrdenes();
        }
    }
}