namespace Proyecto_Final.Vistas
{
    partial class frmPagoCuotaSocial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSocioDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTipoDeSocio = new System.Windows.Forms.Label();
            this.lblFormasPago = new System.Windows.Forms.Label();
            this.cboFormasDePago = new System.Windows.Forms.ComboBox();
            this.cboTipoSocio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago de Cuotas Sociales";
            // 
            // txtSocioDni
            // 
            this.txtSocioDni.Location = new System.Drawing.Point(266, 123);
            this.txtSocioDni.Name = "txtSocioDni";
            this.txtSocioDni.Size = new System.Drawing.Size(100, 20);
            this.txtSocioDni.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni del Socio solicitante:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblTipoDeSocio
            // 
            this.lblTipoDeSocio.AutoSize = true;
            this.lblTipoDeSocio.Location = new System.Drawing.Point(102, 163);
            this.lblTipoDeSocio.Name = "lblTipoDeSocio";
            this.lblTipoDeSocio.Size = new System.Drawing.Size(71, 13);
            this.lblTipoDeSocio.TabIndex = 8;
            this.lblTipoDeSocio.Text = "Tipo de socio";
            // 
            // lblFormasPago
            // 
            this.lblFormasPago.AutoSize = true;
            this.lblFormasPago.Location = new System.Drawing.Point(371, 163);
            this.lblFormasPago.Name = "lblFormasPago";
            this.lblFormasPago.Size = new System.Drawing.Size(152, 13);
            this.lblFormasPago.TabIndex = 9;
            this.lblFormasPago.Text = "Seleccione una forma de pago";
            // 
            // cboFormasDePago
            // 
            this.cboFormasDePago.FormattingEnabled = true;
            this.cboFormasDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito 1 cuota",
            "Tarjeta de Crédito 2 cuotas",
            "Tarjeta de Crédito 3 cuotas",
            "Tarjeta de Débito"});
            this.cboFormasDePago.Location = new System.Drawing.Point(387, 180);
            this.cboFormasDePago.Name = "cboFormasDePago";
            this.cboFormasDePago.Size = new System.Drawing.Size(121, 21);
            this.cboFormasDePago.TabIndex = 10;
            // 
            // cboTipoSocio
            // 
            this.cboTipoSocio.FormattingEnabled = true;
            this.cboTipoSocio.Location = new System.Drawing.Point(83, 179);
            this.cboTipoSocio.Name = "cboTipoSocio";
            this.cboTipoSocio.Size = new System.Drawing.Size(121, 21);
            this.cboTipoSocio.TabIndex = 11;
            this.cboTipoSocio.SelectedIndexChanged += new System.EventHandler(this.cboFormasDePago_SelectedIndexChanged);
            // 
            // frmPagoCuotaSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 327);
            this.Controls.Add(this.cboTipoSocio);
            this.Controls.Add(this.cboFormasDePago);
            this.Controls.Add(this.lblFormasPago);
            this.Controls.Add(this.lblTipoDeSocio);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSocioDni);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(179, 18);
            this.Name = "frmPagoCuotaSocial";
            this.Text = "Pago Cuota Social";
            this.Load += new System.EventHandler(this.frmPagoCuotaSocial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSocioDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTipoDeSocio;
        private System.Windows.Forms.Label lblFormasPago;
        private System.Windows.Forms.ComboBox cboFormasDePago;
        private System.Windows.Forms.ComboBox cboTipoSocio;
    }
}