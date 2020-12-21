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
    public partial class FormDemanda : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();
        int id = 0;
        String title = "";
        String description = "";
        int categoria = 0;

        public FormDemanda()
        {
            InitializeComponent();

            loadCategorias();
        }

        public FormDemanda(Demandas demanda) {
            InitializeComponent();

            loadCategorias();
        }

        private void populateFields()
        {
            this.titleField.Text = title;
            this.descriptionField.Text = description;
        }

        private void loadCategorias()
        {
            var categorias = from c in context.Categorias
                             select c;

            foreach (Categorias categoria in categorias)
            {
                categoriaField.Items.Add(categoria);
            }

            categoriaField.DisplayMember = "NombreCat";
        }

        private Ofertas createDemanda()
        {
            Ofertas oferta = new Ofertas()
            {
                Titulo = this.title,
                Descripcion = this.description,
                fecha_ofer = DateTime.Now,
                idCategoria = this.categoria,
                idUser = 1 // TODO Add current user
            };

            return oferta;
        }

        public void saveDemanda()
        {

            context.Ofertas.Add(createDemanda());

            try
            {
                context.SaveChanges();

                MessageBox.Show("Oferta creada con éxito.");
                this.Close();
            }
            catch (Exception e)
            {
                Console.Error.Write(e);
                MessageBox.Show("Ups! Algo ha salido mal.");
            }

        }

        private void updateDemanda()
        {
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

        private void saveDemandaBtn_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.updateDemanda();
            }
            else
            {
                this.saveDemanda();
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
            this.descriptionField.Text = "";
            this.categoriaField.SelectedItem = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descriptionField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.description = textBox.Text;
        }
    }
}