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

namespace TimeBank.Presentacion
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}