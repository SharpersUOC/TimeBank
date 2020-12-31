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
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();
        Demandas demanda = null;

        public DemandaPage(int id)
        {
            InitializeComponent();

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
            formDemanda.Show();
            this.Refresh();
        }

        private void DemandaPage_Load(object sender, EventArgs e)
        {
            if (TimeBank.Servicios.Session.GetCurrentSession().getCurrentUser().IdUser != this.demanda.idUser)
            {
                this.updateBtn.Visible = false;
                this.deleteBtn.Visible = false;
            }
        }
    }
}