using System;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    partial class frminscribirCliente
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
            this.btnLimpiarSocio = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnVolverSocio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtContactoEmergenciaCliente = new System.Windows.Forms.TextBox();
            this.txtFichaMedicaCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimientoCliente = new System.Windows.Forms.DateTimePicker();
            this.lblTitleSocio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiarSocio
            // 
            this.btnLimpiarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarSocio.Location = new System.Drawing.Point(214, 402);
            this.btnLimpiarSocio.Name = "btnLimpiarSocio";
            this.btnLimpiarSocio.Size = new System.Drawing.Size(98, 36);
            this.btnLimpiarSocio.TabIndex = 9;
            this.btnLimpiarSocio.Text = "Limpiar";
            this.btnLimpiarSocio.UseVisualStyleBackColor = true;
            this.btnLimpiarSocio.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(356, 402);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(94, 36);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // btnVolverSocio
            // 
            this.btnVolverSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverSocio.Location = new System.Drawing.Point(494, 402);
            this.btnVolverSocio.Name = "btnVolverSocio";
            this.btnVolverSocio.Size = new System.Drawing.Size(93, 36);
            this.btnVolverSocio.TabIndex = 11;
            this.btnVolverSocio.Text = "Volver";
            this.btnVolverSocio.UseVisualStyleBackColor = true;
            this.btnVolverSocio.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_dni, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreCliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoCliente, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccionCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailCliente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefonoCliente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtContactoEmergenciaCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFichaMedicaCliente, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaNacimientoCliente, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 302);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_dni.Location = new System.Drawing.Point(3, 3);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(0, 20);
            this.lbl_dni.TabIndex = 1;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(213, 3);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(180, 23);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.Tag = "Ingrese el nombre";
            this.txtNombreCliente.Text = "NOMBRE";
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNombreCliente, "Nombre");
            this.txtNombreCliente.Leave += new System.EventHandler(this.txtNombreCliente_Leave);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(423, 3);
            this.txtApellidoCliente.Multiline = true;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(136, 23);
            this.txtApellidoCliente.TabIndex = 2;
            this.txtApellidoCliente.Tag = "Ingrese el apellido";
            this.txtApellidoCliente.Text = "APELLIDO";
            this.txtApellidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtApellidoCliente, "Apellido");
            this.txtApellidoCliente.Leave += new System.EventHandler(this.txtApellidoCliente_Leave);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(213, 103);
            this.txtDireccionCliente.Multiline = true;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(136, 23);
            this.txtDireccionCliente.TabIndex = 4;
            this.txtDireccionCliente.Tag = "Dirección";
            this.txtDireccionCliente.Text = "DIRECCION";
            this.txtDireccionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtDireccionCliente, "Dirección");
            this.txtDireccionCliente.Leave += new System.EventHandler(this.txtDireccionCliente_Leave);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(423, 103);
            this.txtEmailCliente.Multiline = true;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(136, 23);
            this.txtEmailCliente.TabIndex = 5;
            this.txtEmailCliente.Tag = "E-mail";
            this.txtEmailCliente.Text = "EMAIL";
            this.txtEmailCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEmailCliente, "Email");
            this.txtEmailCliente.Leave += new System.EventHandler(this.txtEmailCliente_Leave);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(3, 203);
            this.txtTelefonoCliente.Multiline = true;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(136, 23);
            this.txtTelefonoCliente.TabIndex = 6;
            this.txtTelefonoCliente.Tag = "Teléfono";
            this.txtTelefonoCliente.Text = "TELEFONO";
            this.txtTelefonoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtTelefonoCliente, "Teléfono");
            this.txtTelefonoCliente.Leave += new System.EventHandler(this.txtTelefonoCliente_Leave);
            // 
            // txtContactoEmergenciaCliente
            // 
            this.txtContactoEmergenciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoEmergenciaCliente.Location = new System.Drawing.Point(213, 203);
            this.txtContactoEmergenciaCliente.Multiline = true;
            this.txtContactoEmergenciaCliente.Name = "txtContactoEmergenciaCliente";
            this.txtContactoEmergenciaCliente.Size = new System.Drawing.Size(136, 23);
            this.txtContactoEmergenciaCliente.TabIndex = 7;
            this.txtContactoEmergenciaCliente.Tag = "Contacto de Urgencia";
            this.txtContactoEmergenciaCliente.Text = "CONTACTO URGENCIAS";
            this.txtContactoEmergenciaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtContactoEmergenciaCliente, "Contacto Urgencias");
            this.txtContactoEmergenciaCliente.Leave += new System.EventHandler(this.txtContactoUrgenciaCliente_Leave);
            // 
            // txtFichaMedicaCliente
            // 
            this.txtFichaMedicaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFichaMedicaCliente.Location = new System.Drawing.Point(423, 203);
            this.txtFichaMedicaCliente.Multiline = true;
            this.txtFichaMedicaCliente.Name = "txtFichaMedicaCliente";
            this.txtFichaMedicaCliente.Size = new System.Drawing.Size(136, 23);
            this.txtFichaMedicaCliente.TabIndex = 8;
            this.txtFichaMedicaCliente.Tag = "Ficha médica";
            this.txtFichaMedicaCliente.Text = "FICHA MEDICA";
            this.txtFichaMedicaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtFichaMedicaCliente, "Nº registro ficha médica");
            this.txtFichaMedicaCliente.Leave += new System.EventHandler(this.txtFichaMedicaCliente_Leave);
            // 
            // dtpFechaNacimientoCliente
            // 
            this.dtpFechaNacimientoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimientoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimientoCliente.Location = new System.Drawing.Point(3, 103);
            this.dtpFechaNacimientoCliente.Name = "dtpFechaNacimientoCliente";
            this.dtpFechaNacimientoCliente.Size = new System.Drawing.Size(164, 26);
            this.dtpFechaNacimientoCliente.TabIndex = 3;
            this.dtpFechaNacimientoCliente.Leave += new System.EventHandler(this.dtpFechaNacimientoCliente_Leave);
            // 
            // lblTitleSocio
            // 
            this.lblTitleSocio.AutoSize = true;
            this.lblTitleSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSocio.Location = new System.Drawing.Point(269, 9);
            this.lblTitleSocio.Name = "lblTitleSocio";
            this.lblTitleSocio.Size = new System.Drawing.Size(262, 31);
            this.lblTitleSocio.TabIndex = 10;
            this.lblTitleSocio.Text = "Inscripcion No Socio";
            this.lblTitleSocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Use TAB para desplazar entre campos";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            // 
            // frminscribirCliente
            // 
            this.AccessibleName = "txtFechaNacimientoSocio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverSocio);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnLimpiarSocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitleSocio);
            this.Name = "frminscribirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInscribirCiente_FormClosed);
            this.Load += new System.EventHandler(this.frminscribirCliente_Load);
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
        private System.Windows.Forms.Button btnVolverSocio;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnLimpiarSocio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtContactoEmergenciaCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtFichaMedicaCliente;
        private System.Windows.Forms.Label lblTitleSocio;
        private Label label1;
        private ToolTip toolTip1;
        private DateTimePicker dtpFechaNacimientoCliente;
        private Label lbl_dni;
    }
}