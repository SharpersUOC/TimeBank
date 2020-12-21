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

            titleField.Text = oferta.Titulo;
            descriptionField.Text = oferta.Descripcion;
            // tiempoField.Text = oferta.Tiempo;
        }

        private void contratarBtn_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden() { 
                idUser = 1, // TODO: Add current user
                idOferta = this.oferta.idOferta,
                idEstado = 1
            };

            this.context.Orden.Add(orden);
            this.context.SaveChanges();
        }
    }
}