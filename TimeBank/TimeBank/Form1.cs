using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeBank.Servicios;

namespace TimeBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Presentacion.FormUsuarios formUsuarios = new Presentacion.FormUsuarios();

            formUsuarios.ShowDialog();

            formUsuarios.Refrescar();
        }


        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Presentacion.FormCategorias formCategorias = new Presentacion.FormCategorias();
            formCategorias.ShowDialog();
            formCategorias.RefrescarCategorias();
        }

        private void activatePage() {
            this.Enabled = true;
            if (TimeBank.Servicios.Session.GetCurrentSession().getCurrentUser().Clientes.First().Esadmin)
            {
                this.adminGroup.Visible = true;
                this.grpXML.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.adminGroup.Visible = false;
            this.grpXML.Visible = false;

            Session session = Session.GetCurrentSession();
            if (!session.hasUser()) {
                this.Enabled = false;
                Presentacion.LoginForm loginForm = new Presentacion.LoginForm();
                loginForm.Show();
                loginForm.setOnLogin(this.activatePage);
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            Presentacion.FormEstados formEstados = new Presentacion.FormEstados();
            formEstados.ShowDialog();
            formEstados.RefrescarEstados();
        }

        private void btnOfertaForm_Click(object sender, EventArgs e)
        {
            Presentacion.OfertasPresentacion.FormOferta formOferta = new Presentacion.OfertasPresentacion.FormOferta();
            formOferta.Show();
        }

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            Presentacion.OfertasPresentacion.OfertasPage ofertasPage = new Presentacion.OfertasPresentacion.OfertasPage();
            ofertasPage.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            Presentacion.OrdenesPresentacion.OrdenesPage ordenesPage = new Presentacion.OrdenesPresentacion.OrdenesPage();
            ordenesPage.Show();
        }

        private void btnDemandaForm_Click(object sender, EventArgs e)
        {
            Presentacion.DemandasPresentacion.FormDemanda FormDemanda = new Presentacion.DemandasPresentacion.FormDemanda();
            FormDemanda.Show();
        }

        private void btnXMLUsers_Click(object sender, EventArgs e)
        {
            Presentacion.XMLUserForm formXMLUser = new Presentacion.XMLUserForm();
            formXMLUser.ShowDialog();

        }

       private void btnWallet_Click(object sender, EventArgs e)
        {
            Presentacion.FormWallet formWallet = new Presentacion.FormWallet();
            formWallet.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Presentacion.RegisterForm registerForm = new Presentacion.RegisterForm(TimeBank.Servicios.Session.GetCurrentSession().getCurrentUser());
            registerForm.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Presentacion.FormTransferencia formTransferencia = new Presentacion.FormTransferencia();
            formTransferencia.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDemandas_Click(object sender, EventArgs e)
        {
            Presentacion.DemandasPresentacion.DemandasPage demandasPage = new Presentacion.DemandasPresentacion.DemandasPage();
            demandasPage.Show();
        }
    }
}
