namespace Proyecto_Final.Vistas
{
    partial class FrmGenerarCarnet
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
            this.lblEmitirCarnet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActivarCamara = new System.Windows.Forms.Button();
            this.btnCapturarImagen = new System.Windows.Forms.Button();
            this.txtDniSocio = new System.Windows.Forms.TextBox();
            this.btnImprimirCarnetSocio = new System.Windows.Forms.Button();
            this.btnVolverAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmitirCarnet
            // 
            this.lblEmitirCarnet.AutoSize = true;
            this.lblEmitirCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmitirCarnet.Location = new System.Drawing.Point(148, 35);
            this.lblEmitirCarnet.Name = "lblEmitirCarnet";
            this.lblEmitirCarnet.Size = new System.Drawing.Size(348, 31);
            this.lblEmitirCarnet.TabIndex = 0;
            this.lblEmitirCarnet.Text = "Emisión de Carnet de Socio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(178, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnActivarCamara
            // 
            this.btnActivarCamara.Location = new System.Drawing.Point(499, 135);
            this.btnActivarCamara.Name = "btnActivarCamara";
            this.btnActivarCamara.Size = new System.Drawing.Size(87, 23);
            this.btnActivarCamara.TabIndex = 2;
            this.btnActivarCamara.Text = "Activar Cámara";
            this.btnActivarCamara.UseVisualStyleBackColor = true;
            this.btnActivarCamara.Click += new System.EventHandler(this.btnActivarCamara_Click);
            // 
            // btnCapturarImagen
            // 
            this.btnCapturarImagen.Location = new System.Drawing.Point(499, 184);
            this.btnCapturarImagen.Name = "btnCapturarImagen";
            this.btnCapturarImagen.Size = new System.Drawing.Size(87, 23);
            this.btnCapturarImagen.TabIndex = 3;
            this.btnCapturarImagen.Text = "Capturar Imagen";
            this.btnCapturarImagen.UseVisualStyleBackColor = true;
            this.btnCapturarImagen.Click += new System.EventHandler(this.btnCapturarImagen_Click);
            // 
            // txtDniSocio
            // 
            this.txtDniSocio.Location = new System.Drawing.Point(264, 86);
            this.txtDniSocio.Name = "txtDniSocio";
            this.txtDniSocio.Size = new System.Drawing.Size(116, 20);
            this.txtDniSocio.TabIndex = 4;
            this.txtDniSocio.Text = "Ingrese DNI del socio";
            // 
            // btnImprimirCarnetSocio
            // 
            this.btnImprimirCarnetSocio.Location = new System.Drawing.Point(499, 233);
            this.btnImprimirCarnetSocio.Name = "btnImprimirCarnetSocio";
            this.btnImprimirCarnetSocio.Size = new System.Drawing.Size(87, 23);
            this.btnImprimirCarnetSocio.TabIndex = 5;
            this.btnImprimirCarnetSocio.Text = "Imprimir Carnet";
            this.btnImprimirCarnetSocio.UseVisualStyleBackColor = true;
            // 
            // btnVolverAnterior
            // 
            this.btnVolverAnterior.Location = new System.Drawing.Point(499, 282);
            this.btnVolverAnterior.Name = "btnVolverAnterior";
            this.btnVolverAnterior.Size = new System.Drawing.Size(87, 23);
            this.btnVolverAnterior.TabIndex = 6;
            this.btnVolverAnterior.Text = "Volver";
            this.btnVolverAnterior.UseVisualStyleBackColor = true;
            // 
            // FrmGenerarCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverAnterior);
            this.Controls.Add(this.btnImprimirCarnetSocio);
            this.Controls.Add(this.txtDniSocio);
            this.Controls.Add(this.btnCapturarImagen);
            this.Controls.Add(this.btnActivarCamara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmitirCarnet);
            this.Name = "FrmGenerarCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Carnet";
            this.Load += new System.EventHandler(this.FrmGenerarCarnet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmitirCarnet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActivarCamara;
        private System.Windows.Forms.Button btnCapturarImagen;
        private System.Windows.Forms.TextBox txtDniSocio;
        private System.Windows.Forms.Button btnImprimirCarnetSocio;
        private System.Windows.Forms.Button btnVolverAnterior;
    }
}