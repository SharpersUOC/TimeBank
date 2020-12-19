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

        const String FILENAME = "C:\\Users\\Pablo.000\\source\\repos\\TimeBank\\TimeBank\\TimeBank\\XMLFiles\\XMLUsuarios.xml";
                

        public XMLUserForm()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvWallet.AutoGenerateColumns = false;
            


        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            ds.ReadXml(FILENAME);

            dgvClientes.DataSource = ds.Tables[1];
            dgvUsuarios.DataSource = ds.Tables[0];
            dgvWallet.DataSource = ds.Tables[2];

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            ds.WriteXml(FILENAME);

            MessageBox.Show("Los datos se modificaron em el archivo XML con éxito");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count>0)
            {
                dgvUsuarios.Rows.RemoveAt(dgvUsuarios.SelectedRows[0].Index);
                ds.WriteXml(FILENAME);

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
