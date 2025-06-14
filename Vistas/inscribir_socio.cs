using System;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;



namespace Proyecto_Final.Vistas
{
    public partial class FrmInscribirSocio : Form
    {
        public FrmInscribirSocio()
        {
            InitializeComponent();
        }

        private void FrmInscribirSocio_Load(object sender, EventArgs e)
        {
           
            this.AutoValidate = AutoValidate.Disable;
        
        }
        //Metodo para verificación de DNI al salir del campo de texto:
        //Al ingresar un DNI, chequea si el campo está vacío o no es numérico
        // si se cumple lo anterior, se verifica si ya existe un socio con ese DNI en la base de datos
        private void txtDNI_Leave(object sender, EventArgs e)
        {
            string dni = txtDniSocio.Text.Trim();
            if (!Utilidades.ValidarNumerico(txtDniSocio, "DNI"))
            {
                txtDniSocio.Focus();
            }
            else 
            { 
                if (Socio.ExisteSocioPorDNI(dni))
                {
                    MessageBox.Show("Este DNI ya está registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDniSocio.Clear();
                    txtDniSocio.Focus();
                }
            }
        }   
            
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            dtpFechaNacimientoSocio.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimientoSocio.CustomFormat = "dd/MM/yyyy";



            Socio nuevo = new Socio(
                txtDniSocio.Text.Trim(),
                txtApellidoSocio.Text.Trim(),
                txtNombreSocio.Text.Trim(),
                dtpFechaNacimientoSocio.Value.ToString("yyyy-MM-dd"),                 
                DateTime.Now.ToString("yyyy-MM-dd"),
                txtDireccionSocio.Text.Trim(),
                txtEmailSocio.Text.Trim(),
                txtTelefonoSocio.Text.Trim(),
                txtContactoUrgenciaSocio.Text.Trim(),
                txtFichaMedicaSocio.Text.Trim(),
                bool.Parse("true")
            );

            bool guardado = Socio.inscripcionsocio(nuevo);

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

        private void FrmInscribirSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiarSocio_Click(object sender, EventArgs e)
        {
        
            Utilidades.LimpiarControles(this, txtDniSocio); // 'txtDni' es el control donde debe quedar el foco
        

        }

        private void txtNombreSocio_Leave(object sender, EventArgs e)
        {
            if( !Utilidades.ValidarCampoNoVacio(txtNombreSocio, "Nombre"))
                txtNombreSocio.Focus();
        }

        private void txtApellidoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtApellidoSocio, "Apellido"))
                txtApellidoSocio.Focus();
        }

        private void dtpFechaNacimientoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarFechaNacimiento(dtpFechaNacimientoSocio))
                dtpFechaNacimientoSocio.Focus();
        }

        private void txtDireccionSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtDireccionSocio, "Direccion"))
                txtDireccionSocio.Focus();
        }

        private void txtEmailSocio_Leave(object sender, EventArgs e)
        {
            string email = txtEmailSocio.Text.Trim();
            if (!Utilidades.ValidarEmail(txtEmailSocio) || string.IsNullOrWhiteSpace(email))
               txtEmailSocio.Focus();
            
        }

        private void txtTelefonoSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtTelefonoSocio, "Telefono Socio"))
                txtTelefonoSocio.Focus();
        }

        private void txtContactoUrgenciaSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtContactoUrgenciaSocio, "Contacto Urgencia"))
                txtContactoUrgenciaSocio.Focus();
        }

        private void txtFichaMedicaSocio_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtFichaMedicaSocio, "Ficha"))
                txtFichaMedicaSocio.Focus();
        }
    }
}
