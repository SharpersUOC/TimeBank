namespace TimeBank.Presentacion
{
    partial class FormSelectOferta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSelecOferta = new System.Windows.Forms.DataGridView();
            this.IdOfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecOferta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelecOferta
            // 
            this.dgvSelecOferta.AllowUserToDeleteRows = false;
            this.dgvSelecOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecOferta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOfer,
            this.Nombre,
            this.Apellidos,
            this.Titulo,
            this.Tiempo,
            this.Detalle});
            this.dgvSelecOferta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelecOferta.Location = new System.Drawing.Point(0, 0);
            this.dgvSelecOferta.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSelecOferta.MultiSelect = false;
            this.dgvSelecOferta.Name = "dgvSelecOferta";
            this.dgvSelecOferta.ReadOnly = true;
            this.dgvSelecOferta.Size = new System.Drawing.Size(778, 285);
            this.dgvSelecOferta.TabIndex = 0;
            this.dgvSelecOferta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelecOferta_CellContentClick);
            this.dgvSelecOferta.DoubleClick += new System.EventHandler(this.dgvSelecOferta_DoubleClick);
            // 
            // IdOfer
            // 
            this.IdOfer.DataPropertyName = "idOferta";
            this.IdOfer.HeaderText = "ID";
            this.IdOfer.Name = "IdOfer";
            this.IdOfer.ReadOnly = true;
            this.IdOfer.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.DataPropertyName = "Tiempo";
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            this.Tiempo.Width = 75;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Descripción";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Detalle";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // FormSelectOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 285);
            this.Controls.Add(this.dgvSelecOferta);
            this.Name = "FormSelectOferta";
            this.Text = "FormSelectOferta";
            this.Load += new System.EventHandler(this.FormSelectOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecOferta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelecOferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}