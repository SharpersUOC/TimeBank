namespace TimeBank.Presentacion.OfertasPresentacion
{
    partial class OfertaPage
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
            this.tiempoField = new System.Windows.Forms.TextBox();
            this.contratarBtn = new System.Windows.Forms.Button();
            this.titleField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tiempoField
            // 
            this.tiempoField.Location = new System.Drawing.Point(12, 330);
            this.tiempoField.Multiline = true;
            this.tiempoField.Name = "tiempoField";
            this.tiempoField.ReadOnly = true;
            this.tiempoField.Size = new System.Drawing.Size(357, 20);
            this.tiempoField.TabIndex = 7;
            // 
            // contratarBtn
            // 
            this.contratarBtn.Location = new System.Drawing.Point(12, 369);
            this.contratarBtn.Name = "contratarBtn";
            this.contratarBtn.Size = new System.Drawing.Size(75, 23);
            this.contratarBtn.TabIndex = 6;
            this.contratarBtn.Text = "Contratar";
            this.contratarBtn.UseVisualStyleBackColor = true;
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(12, 79);
            this.titleField.Multiline = true;
            this.titleField.Name = "titleField";
            this.titleField.ReadOnly = true;
            this.titleField.Size = new System.Drawing.Size(357, 20);
            this.titleField.TabIndex = 5;
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(12, 105);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.ReadOnly = true;
            this.descriptionField.Size = new System.Drawing.Size(357, 198);
            this.descriptionField.TabIndex = 4;
            // 
            // OfertaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tiempoField);
            this.Controls.Add(this.contratarBtn);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.descriptionField);
            this.Name = "OfertaPage";
            this.Text = "Oferta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tiempoField;
        private System.Windows.Forms.Button contratarBtn;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox descriptionField;
    }
} 