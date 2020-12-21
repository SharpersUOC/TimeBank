namespace TimeBank.Presentacion.DemandasPresentacion
{
    partial class FormDemanda
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
            this.saveDemandaBtn = new System.Windows.Forms.Button();
            this.titleField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.categoriaField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveDemandaBtn
            // 
            this.saveDemandaBtn.Location = new System.Drawing.Point(12, 373);
            this.saveDemandaBtn.Name = "saveDemandaBtn";
            this.saveDemandaBtn.Size = new System.Drawing.Size(75, 23);
            this.saveDemandaBtn.TabIndex = 10;
            this.saveDemandaBtn.Text = "Guardar";
            this.saveDemandaBtn.UseVisualStyleBackColor = true;
            this.saveDemandaBtn.Click += new System.EventHandler(this.saveDemandaBtn_Click);
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(12, 64);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(357, 20);
            this.titleField.TabIndex = 9;
            this.titleField.TextChanged += new System.EventHandler(this.titleField_TextChanged);

            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(12, 128);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(357, 189);
            this.descriptionField.TabIndex = 8;
            this.descriptionField.TextChanged += new System.EventHandler(this.descriptionField_TextChanged);

            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(93, 373);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Limpiar";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(174, 373);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.saveDemandaBtn.Click += new System.EventHandler(this.cancelBtn_Click);

            // 
            // categoriaField
            // 
            this.categoriaField.FormattingEnabled = true;
            this.categoriaField.Location = new System.Drawing.Point(399, 66);
            this.categoriaField.Name = "categoriaField";
            this.categoriaField.Size = new System.Drawing.Size(121, 21);
            this.categoriaField.TabIndex = 13;
            this.categoriaField.SelectedIndexChanged += new System.EventHandler(this.categoriaField_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Título:";
            // 
            // FormDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoriaField);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveDemandaBtn);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.descriptionField);
            this.Name = "FormDemanda";
            this.Text = "FormDemanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveDemandaBtn;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox categoriaField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
} 