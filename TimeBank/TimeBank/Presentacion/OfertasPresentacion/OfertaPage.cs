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
    public partial class OfertaPage : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();
        Ofertas oferta = null;
        public OfertaPage(int id)
        {
            InitializeComponent();
            this.oferta = context.Ofertas.Find(id);
            TimeSpan time = TimeSpan.FromSeconds(oferta.Tiempo);

            titleField.Text = oferta.Titulo;
            descriptionField.Text = oferta.Descripcion;
            categoriaField.Text = oferta.Categorias.NombreCat;
            tiempoField.Text = time.ToString(@"hh\:mm");
            publicadoField.Text = oferta.fecha_ofer.ToString();
        }

        private void contratarBtn_Click(object sender, EventArgs e)
        {
            var ordenQuery = from o in context.Orden
                             where o.idOferta == this.oferta.idOferta
                             select o;

            Orden orden = ordenQuery.FirstOrDefault();

            orden.idUser = TimeBank.Servicios.Session.GetCurrentSession().getCurrentUser().IdUser;
            orden.idEstado = 2;

            this.context.SaveChanges();
            MessageBox.Show("¡Se acaba de enviar la solicitud de la oferta!");
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            context.Ofertas.Remove(this.oferta);
            context.SaveChanges();
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Presentacion.OfertasPresentacion.FormOferta ordenesPage = new Presentacion.OfertasPresentacion.FormOferta(oferta);
            ordenesPage.Show();
            this.Refresh();
        }
    }
}