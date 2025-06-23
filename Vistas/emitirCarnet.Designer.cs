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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnImprimirCarnetSocio = new System.Windows.Forms.Button();
            this.btnVolverAnterior = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFechaInscrip = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmitirCarnet
            // 
            this.lblEmitirCarnet.AutoSize = true;
            this.lblEmitirCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmitirCarnet.Location = new System.Drawing.Point(148, 35);
            this.lblEmitirCarnet.Name = "lblEmitirCarnet";
            this.lblEmitirCarnet.Size = new System.Drawing.Size(243, 31);
            this.lblEmitirCarnet.TabIndex = 0;
            this.lblEmitirCarnet.Text = "Emisión de Carnet ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(105, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnActivarCamara
            // 
            this.btnActivarCamara.Location = new System.Drawing.Point(119, 319);
            this.btnActivarCamara.Name = "btnActivarCamara";
            this.btnActivarCamara.Size = new System.Drawing.Size(87, 23);
            this.btnActivarCamara.TabIndex = 2;
            this.btnActivarCamara.Text = "Activar Cámara";
            this.btnActivarCamara.UseVisualStyleBackColor = true;
            this.btnActivarCamara.Click += new System.EventHandler(this.btnActivarCamara_Click);
            // 
            // btnCapturarImagen
            // 
            this.btnCapturarImagen.Location = new System.Drawing.Point(119, 362);
            this.btnCapturarImagen.Name = "btnCapturarImagen";
            this.btnCapturarImagen.Size = new System.Drawing.Size(87, 23);
            this.btnCapturarImagen.TabIndex = 3;
            this.btnCapturarImagen.Text = "Capturar Imagen";
            this.btnCapturarImagen.UseVisualStyleBackColor = true;
            this.btnCapturarImagen.Click += new System.EventHandler(this.btnCapturarImagen_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(302, 251);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(116, 20);
            this.txtDni.TabIndex = 4;
            this.txtDni.Text = "Ingrese DNI del socio";
            // 
            // btnImprimirCarnetSocio
            // 
            this.btnImprimirCarnetSocio.Location = new System.Drawing.Point(344, 381);
            this.btnImprimirCarnetSocio.Name = "btnImprimirCarnetSocio";
            this.btnImprimirCarnetSocio.Size = new System.Drawing.Size(87, 23);
            this.btnImprimirCarnetSocio.TabIndex = 5;
            this.btnImprimirCarnetSocio.Text = "Imprimir Carnet";
            this.btnImprimirCarnetSocio.UseVisualStyleBackColor = true;
            // 
            // btnVolverAnterior
            // 
            this.btnVolverAnterior.Location = new System.Drawing.Point(447, 381);
            this.btnVolverAnterior.Name = "btnVolverAnterior";
            this.btnVolverAnterior.Size = new System.Drawing.Size(87, 23);
            this.btnVolverAnterior.TabIndex = 6;
            this.btnVolverAnterior.Text = "Volver";
            this.btnVolverAnterior.UseVisualStyleBackColor = true;
            this.btnVolverAnterior.Click += new System.EventHandler(this.btnVolverAnterior_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(262, 129);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(325, 129);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 16);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellito";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(397, 170);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 16);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "label1";
            // 
            // lblFechaInscrip
            // 
            this.lblFechaInscrip.AutoSize = true;
            this.lblFechaInscrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscrip.Location = new System.Drawing.Point(397, 206);
            this.lblFechaInscrip.Name = "lblFechaInscrip";
            this.lblFechaInscrip.Size = new System.Drawing.Size(44, 16);
            this.lblFechaInscrip.TabIndex = 10;
            this.lblFechaInscrip.Text = "label1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(265, 170);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 16);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Tipo:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(262, 206);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(115, 16);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Fecha Inscripción:";
            // 
            // FrmGenerarCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblFechaInscrip);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVolverAnterior);
            this.Controls.Add(this.btnImprimirCarnetSocio);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnCapturarImagen);
            this.Controls.Add(this.btnActivarCamara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmitirCarnet);
            this.Name = "FrmGenerarCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Carnet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmitirCarnet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActivarCamara;
        private System.Windows.Forms.Button btnCapturarImagen;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnImprimirCarnetSocio;
        private System.Windows.Forms.Button btnVolverAnterior;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFechaInscrip;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}