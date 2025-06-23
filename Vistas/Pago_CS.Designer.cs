namespace Proyecto_Final.Vistas
{
    partial class frmpagoCuotaSocial
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
            this.btnpagado = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFormasPago = new System.Windows.Forms.Label();
            this.cboFormasDePago = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago de Cuotas Sociales";
            // 
            // txtSocioDni
            // 
            this.txtSocioDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocioDni.Location = new System.Drawing.Point(350, 123);
            this.txtSocioDni.Name = "txtSocioDni";
            this.txtSocioDni.Size = new System.Drawing.Size(100, 26);
            this.txtSocioDni.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni del Socio solicitante:";
            // 
            // btnpagado
            // 
            this.btnpagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagado.Location = new System.Drawing.Point(296, 292);
            this.btnpagado.Name = "btnpagado";
            this.btnpagado.Size = new System.Drawing.Size(94, 38);
            this.btnpagado.TabIndex = 5;
            this.btnpagado.Text = "Pagado";
            this.btnpagado.UseVisualStyleBackColor = true;
            this.btnpagado.Click += new System.EventHandler(this.btnpagado_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(418, 291);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(86, 39);
            this.btnvolver.TabIndex = 7;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(218, 169);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(112, 20);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto a pagar";
            // 
            // lblFormasPago
            // 
            this.lblFormasPago.AutoSize = true;
            this.lblFormasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormasPago.Location = new System.Drawing.Point(463, 172);
            this.lblFormasPago.Name = "lblFormasPago";
            this.lblFormasPago.Size = new System.Drawing.Size(117, 20);
            this.lblFormasPago.TabIndex = 9;
            this.lblFormasPago.Text = "Forma de pago";
            // 
            // cboFormasDePago
            // 
            this.cboFormasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormasDePago.FormattingEnabled = true;
            this.cboFormasDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito 1 cuota",
            "Tarjeta de Crédito 2 cuotas",
            "Tarjeta de Crédito 3 cuotas",
            "Tarjeta de Débito"});
            this.cboFormasDePago.Location = new System.Drawing.Point(461, 205);
            this.cboFormasDePago.Name = "cboFormasDePago";
            this.cboFormasDePago.Size = new System.Drawing.Size(121, 28);
            this.cboFormasDePago.TabIndex = 10;
            this.cboFormasDePago.SelectedIndexChanged += new System.EventHandler(this.cboFormasDePago_SelectedIndexChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(220, 205);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 26);
            this.txtMonto.TabIndex = 13;
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // frmpagoCuotaSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cboFormasDePago);
            this.Controls.Add(this.lblFormasPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnpagado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSocioDni);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(179, 18);
            this.Name = "frmpagoCuotaSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Cuota Social";
            this.Load += new System.EventHandler(this.frmpagoCuotaSocial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSocioDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpagado;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFormasPago;
        private System.Windows.Forms.ComboBox cboFormasDePago;
        private System.Windows.Forms.TextBox txtMonto;
    }
}