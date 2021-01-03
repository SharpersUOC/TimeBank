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
using TimeBank.Servicios;

namespace TimeBank.Presentacion
{
    public partial class FormWallet : Form
    {

        private BancoDeTiempoEntities db;
        private Usuarios usuario,currentuser;
        private Clientes cliente;
        private Wallet cartera;
        private Session currentsession;


        public FormWallet()
        {
            InitializeComponent();
            currentsession = Servicios.Session.GetCurrentSession();
            currentuser = currentsession.getCurrentUser();
            this.db = new BancoDeTiempoEntities();

            this.usuario = db.Usuarios.Find(currentuser.IdUser);
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
            label1.Text += "  " + this.cartera.Balance;
            lblHoras.Text=(this.cartera.Balance/3600).ToString();
            lblMinutos.Text = ((this.cartera.Balance % 3600) / 60).ToString();
            using (BancoDeTiempoEntities mdb=new BancoDeTiempoEntities())
            {
                var lstOfertas = from d in mdb.ResumenActividad
                                 where d.oferUser == currentuser.IdUser
                                 select d;


                var lstDemandas = from d in mdb.ResumenActividad
                                  where d.ordenUser == currentuser.IdUser
                                  select d;


                try
                {
                    dgvofertas.DataSource = lstOfertas.ToList();
                    dgvdemandas.DataSource = lstDemandas.ToList();

                }catch(Exception e)
                {
                    dgvofertas.DataSource = null;
                    dgvdemandas.DataSource = null;
                }
            }
        }
    }
}
