using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final.Vistas
{
    public partial class frmpagoCuotaSocial : Form
    {
        string Dni = null;
        private Socio nuevo1=null;
        private Socio existente=null;
        string modoSeleccionado;

        //En las siguientes lineas, la sobrecarga del constructor de formulario
        //frmpagoCuotaSocial permite recibir un DNI o un objeto Socio.
        //Esto permite que el formulario pueda ser utilizado tanto para registrar un nuevo socio
        //como para procesar el pago de la cuota social de un socio ya existente.

        public frmpagoCuotaSocial(string dni)
        {
            Dni = dni;
            InitializeComponent();
            txtSocioDni.Text = Dni;
            txtSocioDni.Enabled = false; // Desactivar el campo DNI para evitar edición
            LlenarFormaPago();
            txtMonto.Text = ""; // Inicializar el campo de monto a vacío
            this.existente = Utilidades.ObtenerSocioPorDni(Dni);
        }

        public frmpagoCuotaSocial(Socio nuevo)
        {
            this.nuevo1 = nuevo;
            InitializeComponent();
            txtSocioDni.Text = nuevo1.Dni;
            txtSocioDni.Enabled = false; // Desactivar el campo DNI para evitar edición
            LlenarFormaPago();
            txtMonto.Text = ""; // Inicializar el campo de monto a vacío
        }


        private void LlenarFormaPago()
        {
            // Llenar el ComboBox con las formas de pago
            cboFormasDePago.Items.Clear();
            cboFormasDePago.Items.Add("Contado");
            cboFormasDePago.Items.Add("1 Cuota");
            cboFormasDePago.Items.Add("3 cuotas");
            cboFormasDePago.Items.Add("6 cuotas");
            cboFormasDePago.SelectedIndex = 0; // Seleccionar el primer elemento por defecto
        }
        private void cboFormasDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            modoSeleccionado = cboFormasDePago.Text;
        }



        private void btnpagado_Click(object sender, EventArgs e)
        {
            ProcesarPagoCuota();
        }

        private void ProcesarPagoCuota()
        {
            if (nuevo1 == null)
            {
                bool pagado = existente.pagarCuota(double.Parse(txtMonto.Text), modoSeleccionado);

                if (pagado)
                {
                    MessageBox.Show("Pago de cuota realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utilidades.Actualizar_status_socios();
                    new frmInicial().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al procesar el pago de la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool guardado = nuevo1.inscripcionSocio(nuevo1);

                if (guardado)
                {
                    MessageBox.Show("Inscripción Socio exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new frmInicial().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bool pagado = nuevo1.pagarCuota(double.Parse(txtMonto.Text), modoSeleccionado);

                if (pagado)
                {
                    MessageBox.Show("Pago de Primera cuota realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new frmInicial().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al procesar el pago de la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            new frmInicial().Show();
            this.Close();
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtMonto, "Monto"))
            {
                txtMonto.Focus(); // Volver a enfocar el campo de monto si no es numérico
            }
        }
    }
}