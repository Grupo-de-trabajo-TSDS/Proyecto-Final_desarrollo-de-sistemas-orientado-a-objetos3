using System;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    partial class FrmInscribirSocio
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiarSocio = new System.Windows.Forms.Button();
            this.btnInscribirSocio = new System.Windows.Forms.Button();
            this.btnVolverSocio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDniSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtApellidoSocio = new System.Windows.Forms.TextBox();
            this.txtDireccionSocio = new System.Windows.Forms.TextBox();
            this.txtEmailSocio = new System.Windows.Forms.TextBox();
            this.txtTelefonoSocio = new System.Windows.Forms.TextBox();
            this.txtContactoUrgenciaSocio = new System.Windows.Forms.TextBox();
            this.txtFichaMedicaSocio = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimientoSocio = new System.Windows.Forms.DateTimePicker();
            this.lblTitleSocio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiarSocio, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInscribirSocio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVolverSocio, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 36);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnLimpiarSocio
            // 
            this.btnLimpiarSocio.Location = new System.Drawing.Point(3, 3);
            this.btnLimpiarSocio.Name = "btnLimpiarSocio";
            this.btnLimpiarSocio.Size = new System.Drawing.Size(74, 23);
            this.btnLimpiarSocio.TabIndex = 11;
            this.btnLimpiarSocio.Text = "LIMPIAR";
            this.btnLimpiarSocio.UseVisualStyleBackColor = true;
            this.btnLimpiarSocio.Click += new System.EventHandler(this.btnLimpiarSocio_Click);
            // 
            // btnInscribirSocio
            // 
            this.btnInscribirSocio.Location = new System.Drawing.Point(84, 3);
            this.btnInscribirSocio.Name = "btnInscribirSocio";
            this.btnInscribirSocio.Size = new System.Drawing.Size(74, 23);
            this.btnInscribirSocio.TabIndex = 10;
            this.btnInscribirSocio.Text = "INSCRIBIR";
            this.btnInscribirSocio.UseVisualStyleBackColor = true;
            this.btnInscribirSocio.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnVolverSocio
            // 
            this.btnVolverSocio.Location = new System.Drawing.Point(165, 3);
            this.btnVolverSocio.Name = "btnVolverSocio";
            this.btnVolverSocio.Size = new System.Drawing.Size(74, 23);
            this.btnVolverSocio.TabIndex = 12;
            this.btnVolverSocio.Text = "VOLVER";
            this.btnVolverSocio.UseVisualStyleBackColor = true;
            this.btnVolverSocio.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.txtDniSocio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreSocio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoSocio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccionSocio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailSocio, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefonoSocio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtContactoUrgenciaSocio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFichaMedicaSocio, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaNacimientoSocio, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 204);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtDniSocio
            // 
            this.txtDniSocio.Location = new System.Drawing.Point(3, 3);
            this.txtDniSocio.Multiline = true;
            this.txtDniSocio.Name = "txtDniSocio";
            this.txtDniSocio.Size = new System.Drawing.Size(136, 23);
            this.txtDniSocio.TabIndex = 1;
            this.txtDniSocio.Tag = "Ingrese el DNI";
            this.txtDniSocio.Text = "DNI";
            this.txtDniSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtDniSocio, "Ingrese DNI");
            this.txtDniSocio.Leave += new System.EventHandler(this.txtDNI_Leave);
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(173, 3);
            this.txtNombreSocio.Multiline = true;
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(136, 23);
            this.txtNombreSocio.TabIndex = 2;
            this.txtNombreSocio.Tag = "Ingrese el nombre";
            this.txtNombreSocio.Text = "NOMBRE";
            this.txtNombreSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNombreSocio, "Nombre");
            this.txtNombreSocio.Leave += new System.EventHandler(this.txtNombreSocio_Leave);
            // 
            // txtApellidoSocio
            // 
            this.txtApellidoSocio.Location = new System.Drawing.Point(343, 3);
            this.txtApellidoSocio.Multiline = true;
            this.txtApellidoSocio.Name = "txtApellidoSocio";
            this.txtApellidoSocio.Size = new System.Drawing.Size(136, 23);
            this.txtApellidoSocio.TabIndex = 3;
            this.txtApellidoSocio.Tag = "Ingrese el apellido";
            this.txtApellidoSocio.Text = "APELLIDO";
            this.txtApellidoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtApellidoSocio, "Apellido");
            this.txtApellidoSocio.Leave += new System.EventHandler(this.txtApellidoSocio_Leave);
            // 
            // txtDireccionSocio
            // 
            this.txtDireccionSocio.Location = new System.Drawing.Point(173, 71);
            this.txtDireccionSocio.Multiline = true;
            this.txtDireccionSocio.Name = "txtDireccionSocio";
            this.txtDireccionSocio.Size = new System.Drawing.Size(136, 23);
            this.txtDireccionSocio.TabIndex = 5;
            this.txtDireccionSocio.Tag = "Dirección";
            this.txtDireccionSocio.Text = "DIRECCION";
            this.txtDireccionSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtDireccionSocio, "Dirección");
            this.txtDireccionSocio.Leave += new System.EventHandler(this.txtDireccionSocio_Leave);
            // 
            // txtEmailSocio
            // 
            this.txtEmailSocio.Location = new System.Drawing.Point(343, 71);
            this.txtEmailSocio.Multiline = true;
            this.txtEmailSocio.Name = "txtEmailSocio";
            this.txtEmailSocio.Size = new System.Drawing.Size(136, 23);
            this.txtEmailSocio.TabIndex = 6;
            this.txtEmailSocio.Tag = "E-mail";
            this.txtEmailSocio.Text = "EMAIL";
            this.txtEmailSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEmailSocio, "Email");
            this.txtEmailSocio.Leave += new System.EventHandler(this.txtEmailSocio_Leave);
            // 
            // txtTelefonoSocio
            // 
            this.txtTelefonoSocio.Location = new System.Drawing.Point(3, 139);
            this.txtTelefonoSocio.Multiline = true;
            this.txtTelefonoSocio.Name = "txtTelefonoSocio";
            this.txtTelefonoSocio.Size = new System.Drawing.Size(136, 23);
            this.txtTelefonoSocio.TabIndex = 7;
            this.txtTelefonoSocio.Tag = "Teléfono";
            this.txtTelefonoSocio.Text = "TELEFONO";
            this.txtTelefonoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtTelefonoSocio, "Teléfono");
            this.txtTelefonoSocio.Leave += new System.EventHandler(this.txtTelefonoSocio_Leave);
            // 
            // txtContactoUrgenciaSocio
            // 
            this.txtContactoUrgenciaSocio.Location = new System.Drawing.Point(173, 139);
            this.txtContactoUrgenciaSocio.Multiline = true;
            this.txtContactoUrgenciaSocio.Name = "txtContactoUrgenciaSocio";
            this.txtContactoUrgenciaSocio.Size = new System.Drawing.Size(136, 23);
            this.txtContactoUrgenciaSocio.TabIndex = 8;
            this.txtContactoUrgenciaSocio.Tag = "Contacto de Urgencia";
            this.txtContactoUrgenciaSocio.Text = "CONTACTO URGENCIAS";
            this.txtContactoUrgenciaSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtContactoUrgenciaSocio, "Contacto Urgencias");
            this.txtContactoUrgenciaSocio.Leave += new System.EventHandler(this.txtContactoUrgenciaSocio_Leave);
            // 
            // txtFichaMedicaSocio
            // 
            this.txtFichaMedicaSocio.Location = new System.Drawing.Point(343, 139);
            this.txtFichaMedicaSocio.Multiline = true;
            this.txtFichaMedicaSocio.Name = "txtFichaMedicaSocio";
            this.txtFichaMedicaSocio.Size = new System.Drawing.Size(136, 23);
            this.txtFichaMedicaSocio.TabIndex = 9;
            this.txtFichaMedicaSocio.Tag = "Ficha médica";
            this.txtFichaMedicaSocio.Text = "FICHA MEDICA";
            this.txtFichaMedicaSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtFichaMedicaSocio, "Nº registro ficha médica");
            this.txtFichaMedicaSocio.Leave += new System.EventHandler(this.txtFichaMedicaSocio_Leave);
            // 
            // dtpFechaNacimientoSocio
            // 
            this.dtpFechaNacimientoSocio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimientoSocio.Location = new System.Drawing.Point(3, 71);
            this.dtpFechaNacimientoSocio.Name = "dtpFechaNacimientoSocio";
            this.dtpFechaNacimientoSocio.Size = new System.Drawing.Size(164, 20);
            this.dtpFechaNacimientoSocio.TabIndex = 4;
            this.dtpFechaNacimientoSocio.Leave += new System.EventHandler(this.dtpFechaNacimientoSocio_Leave);
            // 
            // lblTitleSocio
            // 
            this.lblTitleSocio.AutoSize = true;
            this.lblTitleSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSocio.Location = new System.Drawing.Point(192, 15);
            this.lblTitleSocio.Name = "lblTitleSocio";
            this.lblTitleSocio.Size = new System.Drawing.Size(249, 31);
            this.lblTitleSocio.TabIndex = 10;
            this.lblTitleSocio.Text = "INSCRIBIR SOCIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Use TAB para desplazar entre campos";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            // 
            // FrmInscribirSocio
            // 
            this.AccessibleName = "txtFechaNacimientoSocio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitleSocio);
            this.Name = "FrmInscribirSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir Socio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInscribirSocio_FormClosed);
            this.Load += new System.EventHandler(this.FrmInscribirSocio_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVolverSocio;
        private System.Windows.Forms.Button btnInscribirSocio;
        private System.Windows.Forms.Button btnLimpiarSocio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDniSocio;
        private System.Windows.Forms.TextBox txtContactoUrgenciaSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtApellidoSocio;
        private System.Windows.Forms.TextBox txtDireccionSocio;
        private System.Windows.Forms.TextBox txtEmailSocio;
        private System.Windows.Forms.TextBox txtTelefonoSocio;
        private System.Windows.Forms.TextBox txtFichaMedicaSocio;
        private System.Windows.Forms.Label lblTitleSocio;
        private Label label1;
        private ToolTip toolTip1;
        private DateTimePicker dtpFechaNacimientoSocio;
    }
}