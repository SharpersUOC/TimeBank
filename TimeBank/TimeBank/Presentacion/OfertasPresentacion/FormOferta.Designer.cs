namespace TimeBank.Presentacion.OfertasPresentacion
{
    partial class FormOferta
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
            this.timeField = new System.Windows.Forms.TextBox();
            this.saveOfertaBtn = new System.Windows.Forms.Button();
            this.titleField = new System.Windows.Forms.TextBox();
            this.decriptionField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeField
            // 
            this.timeField.Location = new System.Drawing.Point(12, 336);
            this.timeField.Multiline = true;
            this.timeField.Name = "priceField";
            this.timeField.Size = new System.Drawing.Size(357, 20);
            this.timeField.TabIndex = 7;
            this.timeField.Click += new System.EventHandler(this.timeField_TextChanged);
            // 
            // saveOfertaBtn
            // 
            this.saveOfertaBtn.Location = new System.Drawing.Point(12, 375);
            this.saveOfertaBtn.Name = "saveOfertaBtn";
            this.saveOfertaBtn.Size = new System.Drawing.Size(75, 23);
            this.saveOfertaBtn.TabIndex = 6;
            this.saveOfertaBtn.Text = "Guardar";
            this.saveOfertaBtn.UseVisualStyleBackColor = true;
            this.saveOfertaBtn.Click += new System.EventHandler(this.saveOfertaBtn_Click);
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(12, 85);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(357, 20);
            this.titleField.TabIndex = 5;
            this.titleField.TextChanged += new System.EventHandler(this.titleField_TextChanged);
            // 
            // decriptionField
            // 
            this.decriptionField.Location = new System.Drawing.Point(12, 111);
            this.decriptionField.Multiline = true;
            this.decriptionField.Name = "decriptionField";
            this.decriptionField.Size = new System.Drawing.Size(357, 189);
            this.decriptionField.TabIndex = 4;
            this.decriptionField.Click += new System.EventHandler(this.descriptionField_TextChanged);
            // 
            // FormOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.saveOfertaBtn);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.decriptionField);
            this.Name = "FormOferta";
            this.Text = "FormOferta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeField;
        private System.Windows.Forms.Button saveOfertaBtn;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox decriptionField;
    }
}