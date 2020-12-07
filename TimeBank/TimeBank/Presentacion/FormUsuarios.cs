using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeBank.Modelos; // Me traigo la clase donde estan el modelo de la base de datos EntityDataModel

namespace TimeBank.Presentacion
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Refrescar();
        }


        #region HELPER



        /* Método que me permite refrescar datos cada vez que inserto o borro registros */

        public void Refrescar() {

            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())

            {
                var lstUsuarios = from d in db.Usuarios
                                  select d;
                dgvUsuarios.DataSource = lstUsuarios.ToList();
            }

        } // End Refrescar

        #endregion

       
    }
}
