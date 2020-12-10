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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
