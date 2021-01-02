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
            this.btnPerfil = new System.Windows.Forms.Button();
            this.adminGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(224, 30);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(89, 24);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(34, 30);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(89, 24);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(129, 30);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(89, 24);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnOfertas
            // 
            this.btnOfertas.Location = new System.Drawing.Point(161, 24);
            this.btnOfertas.Name = "btnOfertas";
            this.btnOfertas.Size = new System.Drawing.Size(85, 23);
            this.btnOfertas.TabIndex = 3;
            this.btnOfertas.Text = "Ofertas";
            this.btnOfertas.UseVisualStyleBackColor = true;
            this.btnOfertas.Click += new System.EventHandler(this.btnOfertas_Click);
            // 
            // btnDemandas
            // 
            this.btnDemandas.Location = new System.Drawing.Point(252, 24);
            this.btnDemandas.Name = "btnDemandas";
            this.btnDemandas.Size = new System.Drawing.Size(85, 23);
            this.btnDemandas.TabIndex = 4;
            this.btnDemandas.Text = "Demandas";
            this.btnDemandas.UseVisualStyleBackColor = true;
            this.btnDemandas.Click += new System.EventHandler(this.btnDemandas_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(343, 24);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(85, 23);
            this.btnTransferencia.TabIndex = 5;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnOfertaForm
            // 
            this.btnOfertaForm.Location = new System.Drawing.Point(625, 24);
            this.btnOfertaForm.Name = "btnOfertaForm";
            this.btnOfertaForm.Size = new System.Drawing.Size(75, 23);
            this.btnOfertaForm.TabIndex = 7;
            this.btnOfertaForm.Text = "Crear oferta";
            this.btnOfertaForm.UseVisualStyleBackColor = true;
            this.btnOfertaForm.Click += new System.EventHandler(this.btnOfertaForm_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Location = new System.Drawing.Point(434, 24);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(89, 23);
            this.btnOrdenes.TabIndex = 8;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnDemandaForm
            // 
            this.btnDemandaForm.Location = new System.Drawing.Point(715, 24);
            this.btnDemandaForm.Name = "btnDemandaForm";
            this.btnDemandaForm.Size = new System.Drawing.Size(100, 23);
            this.btnDemandaForm.TabIndex = 9;
            this.btnDemandaForm.Text = "Crear demanda";
            this.btnDemandaForm.UseVisualStyleBackColor = true;
            this.btnDemandaForm.Click += new System.EventHandler(this.btnDemandaForm_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(821, 24);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 11;
            this.btnPerfil.Text = "Ver perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // adminGroup
            // 
            this.adminGroup.Controls.Add(this.btnCategorias);
            this.adminGroup.Controls.Add(this.btnEstado);
            this.adminGroup.Controls.Add(this.btnUsuarios);
            this.adminGroup.Location = new System.Drawing.Point(12, 323);
            this.adminGroup.Name = "adminGroup";
            this.adminGroup.Size = new System.Drawing.Size(901, 75);
            this.adminGroup.TabIndex = 12;
            this.adminGroup.TabStop = false;
            this.adminGroup.Text = "Admininistracion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(283, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bienvenido a Banco de Tiempo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeBank.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(46, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminGroup);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnDemandaForm);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnOfertaForm);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnDemandas);
            this.Controls.Add(this.btnOfertas);
            this.Name = "Form1";
            this.Text = "Panel Inico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.adminGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.GroupBox adminGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

