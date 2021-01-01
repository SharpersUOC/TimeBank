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
    public partial class DemandaPage : Form
    {
        BancoDeTiempoEntities context = null;
        Demandas demanda = null;
        public Form parent = null;
        int id = 0;

        public DemandaPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void populateData() {
            context = new BancoDeTiempoEntities();
            this.demanda = context.Demandas.Find(id);

            titleField.Text = demanda.Titulo;
            descriptionField.Text = demanda.Descripcion;
            categoriaField.Text = demanda.Categorias.NombreCat;
            publicadoField.Text = demanda.fecha_dem.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            context.Demandas.Remove(this.demanda);
            context.SaveChanges();
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Presentacion.DemandasPresentacion.FormDemanda formDemanda = new Presentacion.DemandasPresentacion.FormDemanda(demanda);
            formDemanda.parent = this;
            formDemanda.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (parent != null) {
                parent.Refresh();
            }
        }

        override public void Refresh() {
            base.Refresh();
            populateData();
        }
        private void DemandaPage_Load(object sender, EventArgs e)
        {
            populateData();

            if (TimeBank.Servicios.Session.GetCurrentSession().getCurrentUser().IdUser != this.demanda.idUser)
            {
                this.updateBtn.Visible = false;
                this.deleteBtn.Visible = false;
            }
        }
    }
}