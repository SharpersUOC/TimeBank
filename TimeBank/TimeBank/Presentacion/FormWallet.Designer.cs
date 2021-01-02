namespace TimeBank.Presentacion
{
    partial class FormWallet
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
            this.dgvofertas = new System.Windows.Forms.DataGridView();
            this.dgvdemandas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvofertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdemandas)).BeginInit();

            this.SuspendLayout();
            // 
            // dataGridView1
            // 

            this.dgvofertas.AllowUserToDeleteRows = false;
            this.dgvofertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvofertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Descripcion,
            this.Tiempo,
            this.Fecha,
            this.Categoria});
            this.dgvofertas.Location = new System.Drawing.Point(12, 12);
            this.dgvofertas.Name = "dgvofertas";
            this.dgvofertas.Size = new System.Drawing.Size(362, 354);
            this.dgvofertas.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dgvdemandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdemandas.Location = new System.Drawing.Point(426, 12);
            this.dgvdemandas.Name = "dgvdemandas";
            this.dgvdemandas.Size = new System.Drawing.Size(362, 354);
            this.dgvdemandas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance de tu cuenta:";
            // 
            // FormWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdemandas);
            this.Controls.Add(this.dgvofertas);
            this.Name = "FormWallet";
            this.Text = "Wallet";
            this.Load += new System.EventHandler(this.FormWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvofertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdemandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvofertas;
        private System.Windows.Forms.DataGridView dgvdemandas;

        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;

        private System.Windows.Forms.Label label1;
    }
}