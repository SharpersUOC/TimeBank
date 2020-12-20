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
    public partial class FormOferta : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();
        String title = "";
        String description = "";
        Double tiempo = 0;

        public FormOferta()
        {
            InitializeComponent();
        }

        public void saveOferta() {
            Ofertas oferta = new Ofertas() {
                Titulo = this.title,
                Descripcion = this.description,
                Tiempo = this.tiempo,
                fecha_ofer = DateTime.Now,
                idCategoria = 1,
                idUser = 1
            };

            context.Ofertas.Add(oferta);
            context.SaveChanges();
        }

        private void saveOfertaBtn_Click(object sender, EventArgs e)
        {
            this.saveOferta();
        }

        private void titleField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; 
            this.title = textBox.Text;
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.description = textBox.Text;
        }

        private void timeField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // this.time = textBox.Text;
        }
    }
}