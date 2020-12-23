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
using System.Xml;
using System.IO;
using System.Security.Permissions;

namespace TimeBank.Presentacion
{
    public partial class XMLUserForm : Form
    {
        //Atributos de la clase

        DataSet ds = new DataSet();
        String filename;

        //String relativepath = "XMLFiles/XMLUsuarios.xml";
        //String fullpath; //donde almacenamos la ruta absoluta

                

        public XMLUserForm()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvWallet.AutoGenerateColumns = false;
            //fullpath = Path.GetFullPath(relativepath);
            //MessageBox.Show(fullpath);

        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //String direct = @"\XMLFiles";
            //ofd.InitialDirectory = direct;
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK) {
                try {
                    filename = ofd.FileName;
                    ds.ReadXml(filename);

                    dgvClientes.DataSource = ds.Tables[1];
                    dgvUsuarios.DataSource = ds.Tables[0];
                    dgvWallet.DataSource = ds.Tables[2];
                }
                catch (Exception exc){

                    MessageBox.Show(exc.ToString());
                }

            }  

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            
            ds.WriteXml(filename);

            MessageBox.Show("Los datos se modificaron em el archivo XML con éxito");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count>0)
            {
                dgvUsuarios.Rows.RemoveAt(dgvUsuarios.SelectedRows[0].Index);
                ds.WriteXml(filename);

            }
            else if (dgvClientes.SelectedRows.Count > 0)
            {
                String mensaje = "No se permite eliminar registros de cliente. Se debe eliminar el registro completo del usuario";
                String titulo = "Operación no permitida";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dgvWallet.SelectedRows.Count > 0) {

                String mensaje = "No se permite eliminar registros de wallet. Se debe eliminar el registro completo del usuario";
                String titulo = "Operación no permitida";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }//End Class


}
