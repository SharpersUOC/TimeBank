namespace TimeBank.Presentacion.DemandasPresentacion
{
    partial class DemandasPage
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
            this.demandasGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.demandasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // demandasGridView
            // 
            this.demandasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandasGridView.Location = new System.Drawing.Point(12, 66);
            this.demandasGridView.Name = "demandasGridView";
            this.demandasGridView.Size = new System.Drawing.Size(776, 372);
            this.demandasGridView.TabIndex = 1;
            // 
            // DemandasPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.demandasGridView);
            this.Name = "DemandasPage";
            this.Text = "Demandas";
            ((System.ComponentModel.ISupportInitialize)(this.demandasGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView demandasGridView;
    }
} 