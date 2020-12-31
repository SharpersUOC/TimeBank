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

                miusuario = db.Usuarios.Where(x => x.IdUser == mioferta.idUser).FirstOrDefault();
                micliente = db.Clientes.Where(x => x.idUser == miusuario.IdUser).FirstOrDefault();
                txtNombreApellidos.Text = micliente.Nombre + " " + micliente.Apellidos;
                txtEmail.Text = miusuario.Email;
                txtTitulo.Text = mioferta.Titulo;
                txtDescripcion.Text = mioferta.Descripcion;
                txtTiempo.Text = Math.Truncate(mioferta.Tiempo).ToString() + ":" + ((mioferta.Tiempo - Math.Truncate(mioferta.Tiempo))*60).ToString();
                
            }

        } // End setOferInformation

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Clientes clienteDemandante, clienteOfertante;
            Wallet MonederoDemandante,monederoOfertante;
            Orden miorden;
            Usuarios miusuario;


            transferencia.fecha = selectedTime;
            transferencia.comentarios = txtComentarios.Text.ToString();
            transferencia.idUser = currentsession.getCurrentUser().IdUser;

            if (transferencia.idUser == formSelectOferta.SelectedOferta.idUser)
            {
                String mensaje = "No puedes transferirte TIEMPO A TI MISMO.";
                String titulo = "Operación no permitida";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

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

                    //obtener usuario que contacto el servicio

                    miusuario = db.Usuarios.Where(x => x.IdUser == miorden.idUser).FirstOrDefault();

                    //Cuando el usuario que intenta transferir no es el que generó la orden al contactar o la orden no se encuentra en estado En__proceso

                    if ((miusuario.IdUser != currentsession.getCurrentUser().IdUser))
                    {

                        String mensaje1 = "Esta Oferta YA HA SIDO CONTACTADA.";
                        String titulo1 = "Operación no permitida";
                        MessageBox.Show(mensaje1, titulo1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (miorden.idEstado == 1)
                        {

                            String mensaje1 = "Debes CONTACTAR ANTES DE TRANSFERIR.";
                            String titulo1 = "Operación no permitida";
                            MessageBox.Show(mensaje1, titulo1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (miorden.idEstado == 3)
                        {
                            String mensaje = "El servicio está ya está CERRADO.";
                            String titulo = "Operación no permitida";
                            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

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


                        }//End Else
                    }//End Else

                }//End Using
            }//End Else



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedTime = dateTimePicker1.Value;
            while (DateTime.Compare(selectedTime, formSelectOferta.SelectedOferta.fecha_ofer) < 0) {
                String mensaje = "La fecha seleccionada debe ser posterior a la publicación de la OFERTA.";
                String titulo = "Operación no permitida";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedTime = dateTimePicker1.Value;
            }
        }




        //Método para registrar transferencias en la base de datos





    } //End class FormTransferencia
}
