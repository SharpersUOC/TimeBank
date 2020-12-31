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
    
    
    public partial class FormTransferencia : Form
    {

        //Atributos de la clase

        


        //Hacemos que el constructor del formulario admita como parámetro el id de la oferta
        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormSelectOferta formSelectOferta = new FormSelectOferta();
            formSelectOferta.ShowDialog();
            setOferInformation(formSelectOferta.SelectedOferta);
        }


        public void setOferInformation(Ofertas mioferta) {

            Usuarios miusuario;
            Clientes micliente;


            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                miusuario = db.Usuarios.Where(x => x.IdUser == mioferta.idUser).FirstOrDefault();
                micliente = db.Clientes.Where(x => x.idUser == miusuario.IdUser).FirstOrDefault();
                txtNombreApellidos.Text = micliente.Nombre + " " + micliente.Apellidos;
                txtEmail.Text = miusuario.Email;
                txtTitulo.Text = mioferta.Titulo;
                txtDescripcion.Text = mioferta.Descripcion;
                txtTiempo.Text = Math.Truncate(mioferta.Tiempo).ToString() + ":" + ((mioferta.Tiempo - Math.Truncate(mioferta.Tiempo))*60).ToString();
                
            }

        } // End setOferInformation




    } //End class FormTransferencia
}
