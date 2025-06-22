namespace Proyecto_Final.Vistas
{
    partial class frmInicial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngresoDNI = new System.Windows.Forms.Label();
            this.txtDniInicial = new System.Windows.Forms.TextBox();
            this.btnListadoMorosos = new System.Windows.Forms.Button();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeudor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlSocio = new System.Windows.Forms.Panel();
            this.btnimprimeCarnet = new System.Windows.Forms.Button();
            this.btnpagaCuota = new System.Windows.Forms.Button();
            this.pnlnoSocio = new System.Windows.Forms.Panel();
            this.btnimprimirCarnet = new System.Windows.Forms.Button();
            this.btninscribirActividad = new System.Windows.Forms.Button();
            this.lblnoInscripto = new System.Windows.Forms.Label();
            this.pnlinscrip = new System.Windows.Forms.Panel();
            this.btninscrpcionSocio = new System.Windows.Forms.Button();
            this.btninscripcionNoSocio = new System.Windows.Forms.Button();
            this.pnlResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlSocio.SuspendLayout();
            this.pnlnoSocio.SuspendLayout();
            this.pnlinscrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(169, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(462, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Club Deportivo La Esperanza";
            // 
            // lblIngresoDNI
            // 
            this.lblIngresoDNI.AutoSize = true;
            this.lblIngresoDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoDNI.Location = new System.Drawing.Point(257, 133);
            this.lblIngresoDNI.Name = "lblIngresoDNI";
            this.lblIngresoDNI.Size = new System.Drawing.Size(190, 20);
            this.lblIngresoDNI.TabIndex = 1;
            this.lblIngresoDNI.Text = "Ingrese el DNI del cliente:";
            // 
            // txtDniInicial
            // 
            this.txtDniInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniInicial.Location = new System.Drawing.Point(453, 133);
            this.txtDniInicial.Name = "txtDniInicial";
            this.txtDniInicial.Size = new System.Drawing.Size(90, 26);
            this.txtDniInicial.TabIndex = 2;
            this.txtDniInicial.Leave += new System.EventHandler(this.txtDniInicial_Leaving);
            // 
            // btnListadoMorosos
            // 
            this.btnListadoMorosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoMorosos.Location = new System.Drawing.Point(341, 369);
            this.btnListadoMorosos.Name = "btnListadoMorosos";
            this.btnListadoMorosos.Size = new System.Drawing.Size(119, 49);
            this.btnListadoMorosos.TabIndex = 4;
            this.btnListadoMorosos.Text = "Listado de morosos";
            this.btnListadoMorosos.UseVisualStyleBackColor = true;
            this.btnListadoMorosos.Click += new System.EventHandler(this.btnListadoMorosos_Click);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.dataGridView);
            this.pnlResultado.Controls.Add(this.lblDeudor);
            this.pnlResultado.Controls.Add(this.lblTipo);
            this.pnlResultado.Controls.Add(this.lblApellido);
            this.pnlResultado.Controls.Add(this.lblNombre);
            this.pnlResultado.Controls.Add(this.pnlSocio);
            this.pnlResultado.Controls.Add(this.pnlnoSocio);
            this.pnlResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlResultado.Location = new System.Drawing.Point(122, 179);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(557, 136);
            this.pnlResultado.TabIndex = 5;
            this.pnlResultado.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.TipoInsc,
            this.Estado});
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(51, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(455, 69);
            this.dataGridView.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // TipoInsc
            // 
            this.TipoInsc.HeaderText = "Tipo Insc.";
            this.TipoInsc.Name = "TipoInsc";
            this.TipoInsc.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Status";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // lblDeudor
            // 
            this.lblDeudor.AutoSize = true;
            this.lblDeudor.Location = new System.Drawing.Point(422, 14);
            this.lblDeudor.Name = "lblDeudor";
            this.lblDeudor.Size = new System.Drawing.Size(51, 20);
            this.lblDeudor.TabIndex = 3;
            this.lblDeudor.Text = "label1";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(309, 14);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "label3";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(196, 14);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "label2";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(83, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // pnlSocio
            // 
            this.pnlSocio.Controls.Add(this.btnpagaCuota);
            this.pnlSocio.Controls.Add(this.btnimprimeCarnet);
            this.pnlSocio.Location = new System.Drawing.Point(13, 75);
            this.pnlSocio.Name = "pnlSocio";
            this.pnlSocio.Size = new System.Drawing.Size(530, 61);
            this.pnlSocio.TabIndex = 4;
            // 
            // btnimprimeCarnet
            // 
            this.btnimprimeCarnet.Location = new System.Drawing.Point(333, 11);
            this.btnimprimeCarnet.Name = "btnimprimeCarnet";
            this.btnimprimeCarnet.Size = new System.Drawing.Size(142, 39);
            this.btnimprimeCarnet.TabIndex = 1;
            this.btnimprimeCarnet.Text = "Imprimir Carnet";
            this.btnimprimeCarnet.UseVisualStyleBackColor = true;
            this.btnimprimeCarnet.Click += new System.EventHandler(this.btnimprimeCarnet_Click);
            // 
            // btnpagaCuota
            // 
            this.btnpagaCuota.Location = new System.Drawing.Point(56, 11);
            this.btnpagaCuota.Name = "btnpagaCuota";
            this.btnpagaCuota.Size = new System.Drawing.Size(108, 39);
            this.btnpagaCuota.TabIndex = 0;
            this.btnpagaCuota.Text = "Pagar cuota";
            this.btnpagaCuota.UseVisualStyleBackColor = true;
            this.btnpagaCuota.Click += new System.EventHandler(this.btnpagaCuota_Click);
            // 
            // pnlnoSocio
            // 
            this.pnlnoSocio.Controls.Add(this.btnimprimirCarnet);
            this.pnlnoSocio.Controls.Add(this.btninscribirActividad);
            this.pnlnoSocio.Location = new System.Drawing.Point(13, 75);
            this.pnlnoSocio.Name = "pnlnoSocio";
            this.pnlnoSocio.Size = new System.Drawing.Size(530, 61);
            this.pnlnoSocio.TabIndex = 2;
            // 
            // btnimprimirCarnet
            // 
            this.btnimprimirCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirCarnet.Location = new System.Drawing.Point(325, 13);
            this.btnimprimirCarnet.Name = "btnimprimirCarnet";
            this.btnimprimirCarnet.Size = new System.Drawing.Size(185, 35);
            this.btnimprimirCarnet.TabIndex = 1;
            this.btnimprimirCarnet.Text = "Imp. Carnet No Socio";
            this.btnimprimirCarnet.UseVisualStyleBackColor = true;
            this.btnimprimirCarnet.Click += new System.EventHandler(this.btnimprimirCarnet_Click);
            // 
            // btninscribirActividad
            // 
            this.btninscribirActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscribirActividad.Location = new System.Drawing.Point(21, 13);
            this.btninscribirActividad.Name = "btninscribirActividad";
            this.btninscribirActividad.Size = new System.Drawing.Size(174, 35);
            this.btninscribirActividad.TabIndex = 0;
            this.btninscribirActividad.Text = "Inscribir en Actividad";
            this.btninscribirActividad.UseVisualStyleBackColor = true;
            this.btninscribirActividad.Click += new System.EventHandler(this.btninscribirActividad_Click);
            // 
            // lblnoInscripto
            // 
            this.lblnoInscripto.AutoSize = true;
            this.lblnoInscripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoInscripto.Location = new System.Drawing.Point(223, 14);
            this.lblnoInscripto.Name = "lblnoInscripto";
            this.lblnoInscripto.Size = new System.Drawing.Size(92, 20);
            this.lblnoInscripto.TabIndex = 6;
            this.lblnoInscripto.Text = "No inscripto";
            // 
            // pnlinscrip
            // 
            this.pnlinscrip.Controls.Add(this.lblnoInscripto);
            this.pnlinscrip.Controls.Add(this.btninscrpcionSocio);
            this.pnlinscrip.Controls.Add(this.btninscripcionNoSocio);
            this.pnlinscrip.Location = new System.Drawing.Point(122, 200);
            this.pnlinscrip.Name = "pnlinscrip";
            this.pnlinscrip.Size = new System.Drawing.Size(557, 115);
            this.pnlinscrip.TabIndex = 3;
            // 
            // btninscrpcionSocio
            // 
            this.btninscrpcionSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscrpcionSocio.Location = new System.Drawing.Point(34, 74);
            this.btninscrpcionSocio.Name = "btninscrpcionSocio";
            this.btninscrpcionSocio.Size = new System.Drawing.Size(174, 35);
            this.btninscrpcionSocio.TabIndex = 0;
            this.btninscrpcionSocio.Text = "Inscripción Socio";
            this.btninscrpcionSocio.UseVisualStyleBackColor = true;
            this.btninscrpcionSocio.Click += new System.EventHandler(this.btninscrpcionSocio_Click);
            // 
            // btninscripcionNoSocio
            // 
            this.btninscripcionNoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscripcionNoSocio.Location = new System.Drawing.Point(338, 74);
            this.btninscripcionNoSocio.Name = "btninscripcionNoSocio";
            this.btninscripcionNoSocio.Size = new System.Drawing.Size(185, 35);
            this.btninscripcionNoSocio.TabIndex = 1;
            this.btninscripcionNoSocio.Text = "Inscripción No Socio";
            this.btninscripcionNoSocio.UseVisualStyleBackColor = true;
            this.btninscripcionNoSocio.Click += new System.EventHandler(this.btninscripcionNoSocio_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIngresoDNI);
            this.Controls.Add(this.txtDniInicial);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.pnlinscrip);
            this.Controls.Add(this.btnListadoMorosos);
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicial_FormClosed);
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlSocio.ResumeLayout(false);
            this.pnlnoSocio.ResumeLayout(false);
            this.pnlinscrip.ResumeLayout(false);
            this.pnlinscrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngresoDNI;
        private System.Windows.Forms.TextBox txtDniInicial;
        private System.Windows.Forms.Button btnListadoMorosos;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblnoInscripto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeudor;
        private System.Windows.Forms.Panel pnlSocio;
        private System.Windows.Forms.Button btnimprimeCarnet;
        private System.Windows.Forms.Button btnpagaCuota;
        private System.Windows.Forms.Panel pnlnoSocio;
        private System.Windows.Forms.Button btnimprimirCarnet;
        private System.Windows.Forms.Button btninscribirActividad;
        private System.Windows.Forms.Panel pnlinscrip;
        private System.Windows.Forms.Button btninscrpcionSocio;
        private System.Windows.Forms.Button btninscripcionNoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}