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
    public partial class FormWallet : Form
    {

        private BancoDeTiempoEntities db;
        private Usuarios usuario;
        private Clientes cliente;
        private Wallet cartera;

        public FormWallet(Usuarios usuario)
        {
            InitializeComponent();
            this.db = new BancoDeTiempoEntities();

            this.usuario = db.Usuarios.Find(usuario.IdUser);
            cliente = db.Clientes.Find(usuario.Clientes.First().idCliente);
            var carteraQuery = from c in db.Wallet
                               where c.idCliente == cliente.idCliente
                               select c;

            cartera = carteraQuery.First();

        }

        private void FormWallet_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            dgvofertas.AutoGenerateColumns = false;     //Evitar que se incluyan las columnas de las clases relacionadas
            dgvdemandas.AutoGenerateColumns = false;

            this.label1.Text = "Balance de tu cuenta: " + this.cartera.Balance;
            {
                var lstOfertas = (from o in db.Ofertas
                                  where o.idUser == usuario.IdUser
                                  select new
                                  {
                                      Titulo = o.Titulo,
                                      Descripción = o.Descripcion,
                                      Tiempo = o.Tiempo,
                                      Fecha = o.fecha_ofer,
                                      Categoría = o.idCategoria
                                  }
                    ).ToList();

                lstOfertas.ToList();
                dgvofertas.DataSource = lstOfertas.ToList();
            }
        }
    }
}
