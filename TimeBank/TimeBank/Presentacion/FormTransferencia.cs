using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeBank.Modelos;
using TimeBank.Servicios;

namespace TimeBank.Presentacion
{
    
    
    public partial class FormTransferencia : Form
    {

        //Atributos de la clase

        Transferencia transferencia=new Transferencia();
        DateTime selectedTime;
        FormSelectOferta formSelectOferta = new FormSelectOferta();
        Session currentsession;

        //Hacemos que el constructor del formulario admita como parámetro el id de la oferta
        public FormTransferencia()
        {
            InitializeComponent();
            currentsession = Session.GetCurrentSession();
            btnTransferir.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            formSelectOferta.ShowDialog();
            setOferInformation(formSelectOferta.SelectedOferta);
        }


        public void setOferInformation(Ofertas mioferta) {

            Usuarios miusuario;
            Clientes micliente;


            using (BancoDeTiempoEntities db = new BancoDeTiempoEntities()) {

                if (mioferta.Titulo == null)
                {

                    String mensaje = "No puedes transferir tiempo: Revisa si contactaste la oferta";
                    String titulo = "Operación no permitida";
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnTransferir.Enabled = true;
                    miusuario = db.Usuarios.Where(x => x.IdUser == mioferta.idUser).FirstOrDefault();
                    micliente = db.Clientes.Where(x => x.idUser == miusuario.IdUser).FirstOrDefault();
                    txtNombreApellidos.Text = micliente.Nombre + " " + micliente.Apellidos;
                    txtEmail.Text = miusuario.Email;
                    txtTitulo.Text = mioferta.Titulo;
                    txtDescripcion.Text = mioferta.Descripcion;
                    txtTiempo.Text = Math.Truncate(mioferta.Tiempo).ToString() + ":" + ((mioferta.Tiempo - Math.Truncate(mioferta.Tiempo)) * 60).ToString();
                }
                
            }

        } // End setOferInformation



        //Método para realizar las transferencias y actualizar registros de la base de datos

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Clientes clienteDemandante, clienteOfertante;
            Wallet MonederoDemandante,monederoOfertante;
            Orden miorden;

            transferencia.fecha = selectedTime;
            transferencia.comentarios = txtComentarios.Text.ToString();
            transferencia.idUser = currentsession.getCurrentUser().IdUser;

                using (BancoDeTiempoEntities db = new BancoDeTiempoEntities())
                {

                    //seleccionar el cliente asociado a idUser del demandante y ofertante

                    clienteDemandante = db.Clientes.Where(x => x.idUser == transferencia.idUser).FirstOrDefault();
                    clienteOfertante = db.Clientes.Where(x => x.idUser == formSelectOferta.SelectedOferta.idUser).FirstOrDefault();

                    //seleccionar el Wallet asociado a idcliente del demandante y ofertante
                    MonederoDemandante = db.Wallet.Where(x => x.idCliente == clienteDemandante.idCliente).FirstOrDefault();
                    monederoOfertante = db.Wallet.Where(x => x.idCliente == clienteOfertante.idCliente).FirstOrDefault();

                    //obtener la orden asociada a la oferta seleccionada

                    miorden = db.Orden.Where(x => x.idOferta == formSelectOferta.SelectedOferta.idOferta).FirstOrDefault();

                    // insertar registro en tabla Transferencias

                    db.Transferencia.Add(transferencia);

                    //actualizar wallet de ofertante y demandante

                    monederoOfertante.Balance += formSelectOferta.SelectedOferta.Tiempo;
                    MonederoDemandante.Balance -= formSelectOferta.SelectedOferta.Tiempo;

                    //actualizar valores en base de datos

                    db.Entry(monederoOfertante).State = EntityState.Modified;
                    db.Entry(MonederoDemandante).State = EntityState.Modified;

                    //actualizar registro orden que oasa a cerrada

                    miorden.idEstado = 3;

                    db.Entry(miorden).State = EntityState.Modified;
                    db.SaveChanges();

                }//End Using

            MessageBox.Show("La transferencia se realizó CORRECTAMENTE");

        }//btnTransferir_Click

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedTime = dateTimePicker1.Value;
            while (DateTime.Compare(selectedTime, formSelectOferta.SelectedOferta.fecha_ofer) < 0) {
                String mensaje = "La fecha seleccionada debe ser posterior a la publicación de la OFERTA.";
                String titulo = "Operación no permitida";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedTime = DateTime.Today.Date;
            }
        }



    } //End class FormTransferencia
}
