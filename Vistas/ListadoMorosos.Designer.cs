namespace Proyecto_Final.Vistas
{
    partial class FrmListadoMorosos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMorosos;
        private System.Windows.Forms.Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMorosos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMorosos
            // 
            this.dgvMorosos.AllowUserToAddRows = false;
            this.dgvMorosos.AllowUserToDeleteRows = false;
            this.dgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMorosos.Location = new System.Drawing.Point(12, 12);
            this.dgvMorosos.Name = "dgvMorosos";
            this.dgvMorosos.ReadOnly = true;
            this.dgvMorosos.Size = new System.Drawing.Size(760, 400);
            this.dgvMorosos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(697, 420);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmListadoMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvMorosos);
            this.Name = "FrmListadoMorosos";
            this.Text = "Listado de Socios Morosos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
