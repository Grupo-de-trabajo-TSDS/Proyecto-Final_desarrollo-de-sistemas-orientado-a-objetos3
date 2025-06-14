using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final.Vistas
{
    public partial class FrmInscribirNoSocio : Form
    {
        public FrmInscribirNoSocio()
        {
            InitializeComponent();
        }

        private void FrmInscribirNoSocio_Load(object sender, EventArgs e)
        {

            this.AutoValidate = AutoValidate.Disable;

        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            string dni = txtDniNoSocio.Text.Trim();
            if (!Utilidades.ValidarNumerico(txtDniNoSocio, "DNI"))
            {
                txtDniNoSocio.Focus();
            }
            else
            {
                if (NoSocio.ExisteNoSocioPorDNI(dni))
                {
                    MessageBox.Show("Este DNI ya está registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDniNoSocio.Clear();
                    txtDniNoSocio.Focus();
                }
            }
            
        }


        private void btnInscribir_Click(object sender, EventArgs e)
        {
            dtpFechaNacimientoNoSocio.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimientoNoSocio.CustomFormat = "dd/MM/yyyy";

            NoSocio nuevo = new NoSocio(
           
                txtDniNoSocio.Text.Trim(),
                txtApellidoNoSocio.Text.Trim(),
                txtNombreNoSocio.Text.Trim(),
                dtpFechaNacimientoNoSocio.Value.ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("yyyy-MM-dd"),
                txtDireccionNoSocio.Text.Trim(),
                txtEmailNoSocio.Text.Trim(),
                txtTelefonoNoSocio.Text.Trim(),
                txtContactoUrgenciaNoSocio.Text.Trim(),
                txtFichaMedicaNoSocio.Text.Trim()                
            );

            bool guardado = NoSocio.inscripcionnosocio(nuevo);

            if (guardado)
            {
                MessageBox.Show("Inscripción exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmPrincipal().Show();
                this.Hide();
                  // O volvé al formulario principal como lo tengas definido
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Abrir frmPrincipal
            frmPrincipal inicio = new frmPrincipal();
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }
        private void FrmInscribirNoSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarNoSocio_Click(object sender, EventArgs e)
        {
            
            Utilidades.LimpiarControles(this, txtDniNoSocio); // 'txtDni' es el control donde debe quedar el foco
        

        }

        private void txtNombreNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtNombreNoSocio, "Nombre"))
                txtNombreNoSocio.Focus();
        }

        private void txtApellidoNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtApellidoNoSocio, "Apellido"))
                txtApellidoNoSocio.Focus();
        }

        private void dtpFechaNacimientoNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarFechaNacimiento(dtpFechaNacimientoNoSocio))
                dtpFechaNacimientoNoSocio.Focus();
        }

        private void txtDireccionNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtDireccionNoSocio, "Direccion"))
                txtDireccionNoSocio.Focus();
        }

        private void txtEmailNoSocio_Leave(object sender, EventArgs e)
        {
            string email = txtEmailNoSocio.Text.Trim();
            if (!Utilidades.ValidarEmail(txtEmailNoSocio) || string.IsNullOrWhiteSpace(email))
                txtEmailNoSocio.Focus();

        }

        private void txtTelefonoNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtTelefonoNoSocio, "Telefono No Socio"))
                txtTelefonoNoSocio.Focus();
        }

        private void txtContactoUrgenciaNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtContactoUrgenciaNoSocio, "Contacto Urgencia"))
                txtContactoUrgenciaNoSocio.Focus();
        }

        private void txtFichaMedicaNoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtFichaMedicaNoSocio, "Ficha"))
                txtFichaMedicaNoSocio.Focus();
        }
    }

}
