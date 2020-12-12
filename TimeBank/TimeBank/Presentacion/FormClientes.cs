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

namespace TimeBank.Presentacion
{
    public partial class FormClientes : Form
    {
        //Atributos de la clase

        Clientes cliente = new Clientes();
        Usuarios usuarios = new Usuarios();
        Wallet cartera = new Wallet();


        public FormClientes()
        {
            InitializeComponent();
        }



        /* Método que me permite refrescar datos cada vez que inserto o borro registros */

        public void RefrescarClientes()
        {
            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
            {
                var lstClientes = from d in db.Clientes
                                  select d;
                dgvClientes.DataSource = lstClientes.ToList();

            }
        }




        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void clearForm() {

            txtApellidos.Text = txtApellidos.Text = "";
            checkBAdmin.Checked = false;
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;

        }

    }
}
