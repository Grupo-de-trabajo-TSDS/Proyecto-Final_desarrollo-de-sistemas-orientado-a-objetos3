using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    public partial class frmregActividad : Form
    {
        string Dni = "";
        string idActividad = "";
        private NoSocio nuevo1 = null;
        private NoSocio existente = null;
        string modoSeleccionado;

        public frmregActividad(string dni)
        {
            InitializeComponent();
            Dni = dni;
            txtDniNoSocio.Text = Dni;
            DataTable actividades = ObtenerActividades();
            cboActividades.DataSource = actividades;
            cboActividades.DisplayMember = "descripact";
            cboActividades.ValueMember = "descripact"; // or use a unique key if available
            LlenarFormaPago();
            this.existente = Utilidades.ObtenerNoSocioPorDni(Dni);
        }

        public frmregActividad(NoSocio noSocio)
        {
            this.nuevo1 = noSocio;
            InitializeComponent();
            Dni = nuevo1.Dni;
            txtDniNoSocio.Text = Dni;
            DataTable actividades = ObtenerActividades();
            cboActividades.DataSource = actividades;
            cboActividades.DisplayMember = "descripact";
            cboActividades.ValueMember = "descripact"; // or use a unique key if available
            LlenarFormaPago();
            modoSeleccionado = cboFormasDePago.Text;
        }

        private void LlenarFormaPago()
        {
            // Llenar el ComboBox con las formas de pago
            cboFormasDePago.Items.Clear();
            cboFormasDePago.Items.Add("Contado");
            cboFormasDePago.Items.Add("1 Cuota");
            cboFormasDePago.Items.Add("3 cuotas");
            cboFormasDePago.Items.Add("6 cuotas");
            cboFormasDePago.SelectedIndex = 0;
            modoSeleccionado = cboFormasDePago.Text;
        }
        private void cboFormasDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            modoSeleccionado = cboFormasDePago.Text;
        }

        public static DataTable ObtenerActividades()
        {
            string query = "SELECT idactividad, descripact, precioact, fechaactividad FROM Actividades";
            return Utilidades.CrearTablaDesdeDb(query);
        }

        private void cboActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboActividades.SelectedItem is DataRowView row)
            {
                idActividad = row["idactividad"].ToString();
                txtPrecio.Text = row["precioact"].ToString();
                txtFecha.Text = Convert.ToDateTime(row["fechaactividad"]).ToShortDateString();
            }
        }



        private void btnPagoAct_Click(object sender, EventArgs e)
        {
            ProcesarPagoActividad();
        }

        private void ProcesarPagoActividad()
        {
            if (nuevo1 == null)
            {
                bool pagado = existente.pagarActividad(idActividad, double.Parse(txtPrecio.Text), modoSeleccionado);

                if (pagado)
                {
                    MessageBox.Show("Pago de Actividad realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new frmInicial().Show();
                    
                }
                else
                {
                    MessageBox.Show("Error al procesar el pago de la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool guardado = nuevo1.inscripcionNoSocio(nuevo1);

                if (guardado)
                {
                    MessageBox.Show("Inscripción No Socio exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new frmInicial().Show();
                    

                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bool pagado = nuevo1.pagarActividad(idActividad, double.Parse(txtPrecio.Text), modoSeleccionado);

                if (pagado)
                {

                    MessageBox.Show("Pago de Primera Actividad realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new frmInicial().Show();
                    
                }
                else
                {
                    MessageBox.Show("Error al procesar el pago de la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInicial().Show();
        }


    }
}
