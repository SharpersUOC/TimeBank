namespace TimeBank.Presentacion.DemandasPresentacion
{
    partial class DemandaPage
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
            this.titleField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.publicadoField = new System.Windows.Forms.TextBox();
            this.categoriaField = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(12, 71);
            this.titleField.Multiline = true;
            this.titleField.Name = "titleField";
            this.titleField.ReadOnly = true;
            this.titleField.Size = new System.Drawing.Size(357, 20);
            this.titleField.TabIndex = 5;
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(12, 97);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.ReadOnly = true;
            this.descriptionField.Size = new System.Drawing.Size(357, 198);
            this.descriptionField.TabIndex = 4;
            // 
            // publicadoField
            // 
            this.publicadoField.Location = new System.Drawing.Point(375, 275);
            this.publicadoField.Multiline = true;
            this.publicadoField.Name = "publicadoField";
            this.publicadoField.ReadOnly = true;
            this.publicadoField.Size = new System.Drawing.Size(245, 20);
            this.publicadoField.TabIndex = 16;
            // 
            // categoriaField
            // 
            this.categoriaField.Location = new System.Drawing.Point(375, 71);
            this.categoriaField.Multiline = true;
            this.categoriaField.Name = "categoriaField";
            this.categoriaField.ReadOnly = true;
            this.categoriaField.Size = new System.Drawing.Size(245, 20);
            this.categoriaField.TabIndex = 15;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(93, 360);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 360);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Eliminar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DemandaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publicadoField);
            this.Controls.Add(this.categoriaField);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.descriptionField);
            this.Name = "DemandaPage";
            this.Text = "Demanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.TextBox publicadoField;
        private System.Windows.Forms.TextBox categoriaField;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
