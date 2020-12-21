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
            this.saveOfertaBtn = new System.Windows.Forms.Button();
            this.titleField = new System.Windows.Forms.TextBox();
            this.decriptionField = new System.Windows.Forms.TextBox();
            this.categoriaField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.minutosField = new System.Windows.Forms.NumericUpDown();
            this.horasField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minutosField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasField)).BeginInit();
            this.SuspendLayout();
            // 
            // saveOfertaBtn
            // 
            this.saveOfertaBtn.Location = new System.Drawing.Point(12, 381);
            this.saveOfertaBtn.Name = "saveOfertaBtn";
            this.saveOfertaBtn.Size = new System.Drawing.Size(75, 23);
            this.saveOfertaBtn.TabIndex = 6;
            this.saveOfertaBtn.Text = "Guardar";
            this.saveOfertaBtn.UseVisualStyleBackColor = true;
            this.saveOfertaBtn.Click += new System.EventHandler(this.saveOfertaBtn_Click);
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(12, 57);
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
            this.decriptionField.TextChanged += new System.EventHandler(this.decriptionField_TextChanged);
            // 
            // categoriaField
            // 
            this.categoriaField.FormattingEnabled = true;
            this.categoriaField.Location = new System.Drawing.Point(410, 56);
            this.categoriaField.Name = "categoriaField";
            this.categoriaField.Size = new System.Drawing.Size(121, 21);
            this.categoriaField.TabIndex = 8;
            this.categoriaField.SelectedIndexChanged += new System.EventHandler(this.categoriaField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tiempo: (HH:MM)";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(93, 381);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Borrar";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(174, 381);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // minutosField
            // 
            this.minutosField.Location = new System.Drawing.Point(70, 336);
            this.minutosField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutosField.Name = "minutosField";
            this.minutosField.Size = new System.Drawing.Size(49, 20);
            this.minutosField.TabIndex = 15;
            this.minutosField.ValueChanged += new System.EventHandler(this.minutosField_ValueChanged);
            // 
            // horasField
            // 
            this.horasField.Location = new System.Drawing.Point(15, 336);
            this.horasField.Name = "horasField";
            this.horasField.Size = new System.Drawing.Size(45, 20);
            this.horasField.TabIndex = 16;
            this.horasField.ValueChanged += new System.EventHandler(this.horasField_ValueChanged);
            // 
            // FormOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horasField);
            this.Controls.Add(this.minutosField);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoriaField);
            this.Controls.Add(this.saveOfertaBtn);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.decriptionField);
            this.Name = "FormOferta";
            this.Text = "FormOferta";
            ((System.ComponentModel.ISupportInitialize)(this.minutosField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveOfertaBtn;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox decriptionField;
        private System.Windows.Forms.ComboBox categoriaField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown minutosField;
        private System.Windows.Forms.NumericUpDown horasField;
    }
}