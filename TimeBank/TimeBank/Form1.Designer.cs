namespace TimeBank
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnOfertas = new System.Windows.Forms.Button();
            this.btnDemandas = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnOfertaForm = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnDemandaForm = new System.Windows.Forms.Button();
            this.btnXMLUsers = new System.Windows.Forms.Button();
            this.grpXML = new System.Windows.Forms.GroupBox();
            this.btnWallet = new System.Windows.Forms.Button();
            this.grpXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(34, 34);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(89, 23);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(34, 76);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(89, 23);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(34, 116);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(89, 23);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnOfertas
            // 
            this.btnOfertas.Location = new System.Drawing.Point(176, 34);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(85, 23);
            this.btnOfertas.TabIndex = 3;
            this.btnOfertas.Text = "Ofertas";
            this.btnOfertas.UseVisualStyleBackColor = true;
            this.btnOfertas.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // btnDemandas
            // 
            this.btnDemandas.Location = new System.Drawing.Point(176, 76);
            this.btnDemandas.Name = "btnDemandas";
            this.btnDemandas.Size = new System.Drawing.Size(85, 23);
            this.btnDemandas.TabIndex = 4;
            this.btnDemandas.Text = "Demandas";
            this.btnDemandas.UseVisualStyleBackColor = true;
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(176, 116);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(85, 23);
            this.btnTransferencia.TabIndex = 5;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            // 
            // btnOfertaForm
            // 
            this.btnOfertaForm.Location = new System.Drawing.Point(34, 209);
            this.btnOfertaForm.Name = "btnOfertaForm";
            this.btnOfertaForm.Size = new System.Drawing.Size(75, 23);
            this.btnOfertaForm.TabIndex = 7;
            this.btnOfertaForm.Text = "Crear oferta";
            this.btnOfertaForm.UseVisualStyleBackColor = true;
            this.btnOfertaForm.Click += new System.EventHandler(this.btnOfertaForm_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Location = new System.Drawing.Point(34, 159);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(89, 23);
            this.btnOrdenes.TabIndex = 8;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnDemandaForm
            // 
            this.btnDemandaForm.Location = new System.Drawing.Point(161, 209);
            this.btnDemandaForm.Name = "btnDemandaForm";
            this.btnDemandaForm.Size = new System.Drawing.Size(100, 23);
            this.btnDemandaForm.TabIndex = 9;
            this.btnDemandaForm.Text = "Crear demanda";
            this.btnDemandaForm.UseVisualStyleBackColor = true;
            this.btnDemandaForm.Click += new System.EventHandler(this.btnDemandaForm_Click);
            // 
            // btnXMLUsers
            // 
            this.btnXMLUsers.Location = new System.Drawing.Point(34, 27);
            this.btnXMLUsers.Name = "btnXMLUsers";
            this.btnXMLUsers.Size = new System.Drawing.Size(75, 23);
            this.btnXMLUsers.TabIndex = 0;
            this.btnXMLUsers.Text = "Usuarios";
            this.btnXMLUsers.UseVisualStyleBackColor = true;
            this.btnXMLUsers.Click += new System.EventHandler(this.btnXMLUsers_Click);
            // 
            // grpXML
            // 
            this.grpXML.Controls.Add(this.btnXMLUsers);
            this.grpXML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpXML.Location = new System.Drawing.Point(0, 280);
            this.grpXML.Name = "grpXML";
            this.grpXML.Padding = new System.Windows.Forms.Padding(10);
            this.grpXML.Size = new System.Drawing.Size(327, 170);
            this.grpXML.TabIndex = 6;
            this.grpXML.TabStop = false;
            this.grpXML.Text = "XML";
            // 
            // btnWallet
            // 
            this.btnWallet.Location = new System.Drawing.Point(176, 159);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(85, 23);
            this.btnWallet.TabIndex = 10;
            this.btnWallet.Text = "Wallet";
            this.btnWallet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.btnWallet);
            this.Controls.Add(this.grpXML);
            this.Controls.Add(this.btnDemandaForm);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnOfertaForm);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnDemandas);
            this.Controls.Add(this.btnOfertas);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "Form1";
            this.Text = "Panel Inico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpXML.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnOfertas;
        private System.Windows.Forms.Button btnDemandas;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnOfertaForm;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnDemandaForm;
        private System.Windows.Forms.Button btnXMLUsers;
        private System.Windows.Forms.GroupBox grpXML;
        private System.Windows.Forms.Button btnWallet;
    }
}

