namespace TimeBank.Presentacion
{
    partial class XMLUserForm
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
            this.panelWallet = new System.Windows.Forms.Panel();
            this.dgvWallet = new System.Windows.Forms.DataGridView();
            this.idWallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcliente = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallet)).BeginInit();
            this.panelcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWallet
            // 
            this.panelWallet.Controls.Add(this.dgvWallet);
            this.panelWallet.Location = new System.Drawing.Point(520, 12);
            this.panelWallet.Name = "panelWallet";
            this.panelWallet.Size = new System.Drawing.Size(237, 252);
            this.panelWallet.TabIndex = 0;
            // 
            // dgvWallet
            // 
            this.dgvWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWallet,
            this.Balance,
            this.fecha});
            this.dgvWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWallet.Location = new System.Drawing.Point(0, 0);
            this.dgvWallet.Name = "dgvWallet";
            this.dgvWallet.Size = new System.Drawing.Size(237, 252);
            this.dgvWallet.TabIndex = 0;
            // 
            // idWallet
            // 
            this.idWallet.DataPropertyName = "idWallet";
            this.idWallet.HeaderText = "idW";
            this.idWallet.Name = "idWallet";
            this.idWallet.ReadOnly = true;
            this.idWallet.Width = 30;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            // 
            // panelcliente
            // 
            this.panelcliente.Controls.Add(this.dgvClientes);
            this.panelcliente.Location = new System.Drawing.Point(12, 12);
            this.panelcliente.Name = "panelcliente";
            this.panelcliente.Size = new System.Drawing.Size(492, 252);
            this.panelcliente.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Nombre,
            this.Apellidos,
            this.Esadmin});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(492, 252);
            this.dgvClientes.TabIndex = 0;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "idClient";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Esadmin
            // 
            this.Esadmin.DataPropertyName = "Esadmin";
            this.Esadmin.HeaderText = "Admin";
            this.Esadmin.Name = "Esadmin";
            this.Esadmin.Width = 70;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.dgvUsuarios);
            this.panelUsuario.Location = new System.Drawing.Point(285, 285);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(472, 252);
            this.panelUsuario.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.Email,
            this.Contraseña,
            this.fecha_alta});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(472, 252);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // idUser
            // 
            this.idUser.DataPropertyName = "idUser";
            this.idUser.HeaderText = "idUser";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
            this.idUser.Width = 50;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Width = 120;
            // 
            // fecha_alta
            // 
            this.fecha_alta.DataPropertyName = "fecha_alta";
            this.fecha_alta.HeaderText = "fecha_Alta";
            this.fecha_alta.Name = "fecha_alta";
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(23, 297);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(92, 29);
            this.btnReadXML.TabIndex = 3;
            this.btnReadXML.Text = "ReadData";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(23, 342);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "EditData";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // XMLUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelcliente);
            this.Controls.Add(this.panelWallet);
            this.Name = "XMLUserForm";
            this.Text = "XMLUserForm";
            this.panelWallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallet)).EndInit();
            this.panelcliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWallet;
        private System.Windows.Forms.Panel panelcliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esadmin;
        private System.Windows.Forms.DataGridView dgvWallet;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alta;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}