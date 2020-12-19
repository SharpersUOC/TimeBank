using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            Presentacion.FormEstados formEstados = new Presentacion.FormEstados();
            formEstados.ShowDialog();
            formEstados.RefrescarEstados();
        }

        private void btnXMLUsers_Click(object sender, EventArgs e)
        {
            Presentacion.XMLUserForm formXMLUser = new Presentacion.XMLUserForm();
            formXMLUser.ShowDialog();

        }
    }
}
