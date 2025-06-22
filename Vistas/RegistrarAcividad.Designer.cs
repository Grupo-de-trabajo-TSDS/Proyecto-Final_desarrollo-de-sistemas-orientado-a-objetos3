namespace Proyecto_Final.Vistas
{
    partial class frmregActividad
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
            this.lblAct = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDniNoSocio = new System.Windows.Forms.TextBox();
            this.cboActividades = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPagoAct = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboFormasDePago = new System.Windows.Forms.ComboBox();
            this.lblFormasPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct.Location = new System.Drawing.Point(236, 35);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(329, 37);
            this.lblAct.TabIndex = 0;
            this.lblAct.Text = "Registrar en Actividad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(278, 101);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(109, 20);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI No Socio:";
            // 
            // txtDniNoSocio
            // 
            this.txtDniNoSocio.Enabled = false;
            this.txtDniNoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniNoSocio.Location = new System.Drawing.Point(393, 101);
            this.txtDniNoSocio.Name = "txtDniNoSocio";
            this.txtDniNoSocio.Size = new System.Drawing.Size(130, 26);
            this.txtDniNoSocio.TabIndex = 2;
            // 
            // cboActividades
            // 
            this.cboActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividades.FormattingEnabled = true;
            this.cboActividades.Location = new System.Drawing.Point(140, 189);
            this.cboActividades.Name = "cboActividades";
            this.cboActividades.Size = new System.Drawing.Size(260, 28);
            this.cboActividades.TabIndex = 3;
            this.cboActividades.SelectedIndexChanged += new System.EventHandler(this.cboActividades_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(430, 190);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(560, 189);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 26);
            this.txtFecha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Actividades disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // btnPagoAct
            // 
            this.btnPagoAct.Location = new System.Drawing.Point(271, 347);
            this.btnPagoAct.Name = "btnPagoAct";
            this.btnPagoAct.Size = new System.Drawing.Size(75, 23);
            this.btnPagoAct.TabIndex = 11;
            this.btnPagoAct.Text = "Pagado";
            this.btnPagoAct.UseVisualStyleBackColor = true;
            this.btnPagoAct.Click += new System.EventHandler(this.btnPagoAct_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(445, 346);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cboFormasDePago
            // 
            this.cboFormasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormasDePago.FormattingEnabled = true;
            this.cboFormasDePago.Location = new System.Drawing.Point(316, 268);
            this.cboFormasDePago.Name = "cboFormasDePago";
            this.cboFormasDePago.Size = new System.Drawing.Size(168, 28);
            this.cboFormasDePago.TabIndex = 13;
            // 
            // lblFormasPago
            // 
            this.lblFormasPago.AutoSize = true;
            this.lblFormasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormasPago.Location = new System.Drawing.Point(335, 245);
            this.lblFormasPago.Name = "lblFormasPago";
            this.lblFormasPago.Size = new System.Drawing.Size(130, 20);
            this.lblFormasPago.TabIndex = 14;
            this.lblFormasPago.Text = "Formas de Pago:";
            // 
            // frmregActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormasPago);
            this.Controls.Add(this.cboFormasDePago);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPagoAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboActividades);
            this.Controls.Add(this.txtDniNoSocio);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblAct);
            this.Name = "frmregActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regristrar en Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDniNoSocio;
        private System.Windows.Forms.ComboBox cboActividades;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPagoAct;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cboFormasDePago;
        private System.Windows.Forms.Label lblFormasPago;
    }
}