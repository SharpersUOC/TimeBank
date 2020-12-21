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
        int id = 0;
        String title = "";
        String description = "";
        double horas = 0;
        double minutos = 0;
        int categoria = 0;

        public FormOferta()
        {
            InitializeComponent();

            loadCategorias();
        }

        public FormOferta(Ofertas oferta) {
            InitializeComponent();

            loadCategorias();

            TimeSpan time = TimeSpan.FromSeconds(oferta.Tiempo);

            id = oferta.idOferta;
            title = oferta.Titulo;
            description = oferta.Descripcion;
            horas = time.Hours;
            minutos = time.Minutes;

            populateFields();
        }

        private void populateFields() {
            this.titleField.Text = title;
            this.decriptionField.Text = description;
            this.horasField.Value = Convert.ToDecimal(horas);
            this.minutosField.Value = Convert.ToDecimal(minutos);
        }

        private void loadCategorias() {
            var categorias = from c in context.Categorias
                             select c;

            foreach (Categorias categoria in categorias)
            {
                categoriaField.Items.Add(categoria);
            }

            categoriaField.DisplayMember = "NombreCat";
        }

        private Ofertas createOferta() {
            TimeSpan time = TimeSpan.Parse(horas + ":" + minutos);

            Ofertas oferta = new Ofertas()
            {
                Titulo = this.title,
                Descripcion = this.description,
                Tiempo = time.TotalSeconds,
                fecha_ofer = DateTime.Now,
                idCategoria = this.categoria,
                idUser = 1 // TODO Add current user
            };

            return oferta;
        }

        public void saveOferta() {

            context.Ofertas.Add(createOferta());
            
            try
            {
                context.SaveChanges();

                MessageBox.Show("Oferta creada con éxito.");
                this.Close();
            }
            catch (Exception e) {
                Console.Error.Write(e);
                MessageBox.Show("Ups! Algo ha salido mal.");
            }
            
        }

        private void updateOferta() {
            Ofertas oferta = context.Ofertas.Find(id);

            oferta.Titulo = title;
            oferta.Descripcion = description;

            try
            {
                context.SaveChanges();

                MessageBox.Show("Oferta actualizada con éxito.");
                this.Close();
            }
            catch (Exception e)
            {
                Console.Error.Write(e);
                MessageBox.Show("Ups! Algo ha salido mal.");
            }
        }

        private void saveOfertaBtn_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.updateOferta();
            }
            else
            {
                this.saveOferta();
            }
        }

        private void titleField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; 
            this.title = textBox.Text;
        }

        private void categoriaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox categoriaField = sender as ComboBox;

            Categorias categoriaSelected = categoriaField.SelectedItem as Categorias;

            this.categoria = categoriaSelected.idCat;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.titleField.Text = "";
            this.decriptionField.Text = "";
            this.horasField.Value = 0;
            this.minutosField.Value = 0;
            this.categoriaField.SelectedItem = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horasField_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this.horas = Convert.ToDouble(numericUpDown.Value);
        }

        private void minutosField_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this.minutos = Convert.ToDouble(numericUpDown.Value);
        }

        private void decriptionField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.description = textBox.Text;
        }
    }
} 