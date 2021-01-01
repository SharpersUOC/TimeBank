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
using TimeBank.Servicios;

namespace TimeBank.Presentacion.DemandasPresentacion
{
    public partial class FormDemanda : Form
    {
        BancoDeTiempoEntities context = new BancoDeTiempoEntities();
        
        public DemandaPage parent = null;
        
        Demandas demanda = null;
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
            this.demanda = demanda;
            id = demanda.idDemanda;
            title = demanda.Titulo;
            description = demanda.Descripcion;
            categoria = demanda.idCategoria;

            populateFields(demanda);
        }

        private void populateFields(Demandas demanda)
        {
            this.titleField.Text = title;
            this.descriptionField.Text = description;
            this.categoriaField.SelectedIndex = this.categoriaField.FindString(demanda.Categorias.NombreCat);
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

        private Demandas createDemanda()
        {
            Session session = Session.GetCurrentSession();
            Demandas demanda = new Demandas()
            {
                Titulo = this.title,
                Descripcion = this.description,
                fecha_dem = DateTime.Now,
                idCategoria = this.categoria,
                idUser = session.getCurrentUser().IdUser,
            };

            return demanda;
        }

        public void saveDemanda()
        {

            context.Demandas.Add(createDemanda());

            try
            {
                context.SaveChanges();

                MessageBox.Show("Oferta creada con éxito.");
            }
            catch (Exception e)
            {
                Console.Error.Write(e);
                MessageBox.Show("Ups! Algo ha salido mal.");
            }

        }

        private void updateDemanda()
        {
            Demandas demanda = context.Demandas.Find(id);

            demanda.Titulo = title;
            demanda.Descripcion = description;
            demanda.idCategoria = categoria;

            try
            {
                context.SaveChanges();

                MessageBox.Show("Demanda actualizada con éxito.");
            }
            catch (Exception e)
            {
                Console.Error.Write(e);
                MessageBox.Show("Ups! Algo ha salido mal.");
            }
        }

        private void saveDemandaBtn_Click(object sender, EventArgs e)
        {
            if (this.title == "" || this.description == "" || this.categoria == 0)
            {
                MessageBox.Show("Debes de rellenar todos los campos");
                return;
            }

            if (id != 0)
            {
                this.updateDemanda();
            }
            else
            {
                this.saveDemanda();
            }

            refreshParent();
            this.Close();
        }

        private void refreshParent() {
            if (this.parent != null) {
                this.parent.populateData();
            }
        }

        private void titleField_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.title = textBox.Text.Trim();
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
            this.description = textBox.Text.Trim();
        }
    }
}