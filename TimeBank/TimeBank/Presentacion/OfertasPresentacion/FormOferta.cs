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
        int horas = 0;
        int minutos = 0;
        double tiempo = 3600;
        int categoria = 0;

        public FormOferta()
        {
            InitializeComponent();

            var categorias = from c in context.Categorias
                             select c;

            foreach (Categorias categoria in categorias) {
                categoriaField.Items.Add(categoria);
            }

            categoriaField.DisplayMember = "NombreCat";
        }

        public void saveOferta() {
            TimeSpan time = TimeSpan.Parse(horas + ":" + minutos);

            Ofertas oferta = new Ofertas() {
                Titulo = this.title,
                Descripcion = this.description,
                Tiempo = time.TotalSeconds,
                fecha_ofer = DateTime.Now,
                idCategoria = this.categoria,
                idUser = 1 // TODO Add current user
            };

            context.Ofertas.Add(oferta);
            
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

        private void horasField_TextChanged(object sender, EventArgs e)
        {
;
            Console.WriteLine("hello world");
            // this.time = textBox.Text;
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
            this.horasField.Text = "";
            this.categoriaField.SelectedItem = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horasField_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this.tiempo = Convert.ToDouble(numericUpDown.Value);
        }

        private void minutosField_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            this.tiempo = Convert.ToDouble(numericUpDown.Value);
        }
    }
} 