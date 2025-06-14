namespace Proyecto_Final.Vistas
{
    partial class frmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblNoSocio = new System.Windows.Forms.Label();
            this.btnInscribirNoSocio = new System.Windows.Forms.Button();
            this.btnInscribirSocio = new System.Windows.Forms.Button();
            this.btnEmitirCarnet = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnRegistrarActividad = new System.Windows.Forms.Button();
            this.btnListarSocios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(114, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(426, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Club Deportivo - Pantalla Principal";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(211, 68);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(63, 24);
            this.lblSocio.TabIndex = 1;
            this.lblSocio.Text = "Socio";
            // 
            // lblNoSocio
            // 
            this.lblNoSocio.AutoSize = true;
            this.lblNoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSocio.Location = new System.Drawing.Point(373, 68);
            this.lblNoSocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoSocio.Name = "lblNoSocio";
            this.lblNoSocio.Size = new System.Drawing.Size(96, 24);
            this.lblNoSocio.TabIndex = 3;
            this.lblNoSocio.Text = "No Socio";
            // 
            // btnInscribirNoSocio
            // 
            this.btnInscribirNoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirNoSocio.Location = new System.Drawing.Point(331, 104);
            this.btnInscribirNoSocio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscribirNoSocio.Name = "btnInscribirNoSocio";
            this.btnInscribirNoSocio.Size = new System.Drawing.Size(184, 50);
            this.btnInscribirNoSocio.TabIndex = 4;
            this.btnInscribirNoSocio.Text = "INSCRIBIR NO SOCIO";
            this.btnInscribirNoSocio.UseVisualStyleBackColor = true;
            this.btnInscribirNoSocio.Click += new System.EventHandler(this.btnInscribirNoSocio_Click);
            // 
            // btnInscribirSocio
            // 
            this.btnInscribirSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirSocio.Location = new System.Drawing.Point(131, 104);
            this.btnInscribirSocio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscribirSocio.Name = "btnInscribirSocio";
            this.btnInscribirSocio.Size = new System.Drawing.Size(184, 50);
            this.btnInscribirSocio.TabIndex = 1;
            this.btnInscribirSocio.Text = "INSCRIBIR SOCIO";
            this.btnInscribirSocio.UseVisualStyleBackColor = true;
            this.btnInscribirSocio.Click += new System.EventHandler(this.btnInscribirSocio_Click);
            // 
            // btnEmitirCarnet
            // 
            this.btnEmitirCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirCarnet.Location = new System.Drawing.Point(131, 213);
            this.btnEmitirCarnet.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmitirCarnet.Name = "btnEmitirCarnet";
            this.btnEmitirCarnet.Size = new System.Drawing.Size(184, 50);
            this.btnEmitirCarnet.TabIndex = 3;
            this.btnEmitirCarnet.Text = "EMITIR CARNET";
            this.btnEmitirCarnet.UseVisualStyleBackColor = true;
            this.btnEmitirCarnet.Click += new System.EventHandler(this.btnGenerarCarnet_Click);
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCuota.Location = new System.Drawing.Point(131, 159);
            this.btnPagarCuota.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(184, 50);
            this.btnPagarCuota.TabIndex = 2;
            this.btnPagarCuota.Text = "PAGAR CUOTA";
            this.btnPagarCuota.UseVisualStyleBackColor = true;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnCobrarCuota_Click);
            // 
            // btnRegistrarActividad
            // 
            this.btnRegistrarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarActividad.Location = new System.Drawing.Point(331, 159);
            this.btnRegistrarActividad.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarActividad.Name = "btnRegistrarActividad";
            this.btnRegistrarActividad.Size = new System.Drawing.Size(184, 50);
            this.btnRegistrarActividad.TabIndex = 5;
            this.btnRegistrarActividad.Text = "REGISTRAR ACTIVIDAD";
            this.btnRegistrarActividad.UseVisualStyleBackColor = true;
            this.btnRegistrarActividad.Click += new System.EventHandler(this.btnAsociarActividad_Click);
            // 
            // btnListarSocios
            // 
            this.btnListarSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSocios.Location = new System.Drawing.Point(331, 214);
            this.btnListarSocios.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarSocios.Name = "btnListarSocios";
            this.btnListarSocios.Size = new System.Drawing.Size(184, 50);
            this.btnListarSocios.TabIndex = 6;
            this.btnListarSocios.Text = "LISTAR SOCIOS";
            this.btnListarSocios.UseVisualStyleBackColor = true;
            this.btnListarSocios.Click += new System.EventHandler(this.btnListadoMorosos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(283, 276);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 39);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Use TAB para desplazar entre botones";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(644, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarSocios);
            this.Controls.Add(this.btnRegistrarActividad);
            this.Controls.Add(this.btnPagarCuota);
            this.Controls.Add(this.btnEmitirCarnet);
            this.Controls.Add(this.btnInscribirSocio);
            this.Controls.Add(this.btnInscribirNoSocio);
            this.Controls.Add(this.lblNoSocio);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblNoSocio;
        private System.Windows.Forms.Button btnInscribirNoSocio;
        private System.Windows.Forms.Button btnInscribirSocio;
        private System.Windows.Forms.Button btnEmitirCarnet;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnRegistrarActividad;
        private System.Windows.Forms.Button btnListarSocios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}