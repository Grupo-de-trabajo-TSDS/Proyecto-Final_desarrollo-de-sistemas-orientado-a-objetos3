using System;
using System.Drawing;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;



namespace Proyecto_Final.Vistas
{
    public partial class frminscribirCliente : Form
    {
        private string dni="", tipo="";
        public frminscribirCliente(string _dni, string _tipo)
        {
            InitializeComponent();
            dni = _dni;
            lbl_dni.Text = dni;
            tipo = _tipo;
            if (tipo == "Socio")
            {
                lblTitleSocio.Text = "Inscripción Socio";
            }
            else if (tipo == "No Socio")
            {
                lblTitleSocio.Text = "Inscripción No Socio";
            }
        }
                
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Abrir frmInicial
            frmInicial inicio = new frmInicial();
            inicio.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void FrmInscribirCiente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
        
            Utilidades.LimpiarControles(this, lbl_dni); 
            txtNombreCliente.Focus();


        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            if( !Utilidades.ValidarCampoNoVacio(txtNombreCliente, "Nombre"))
                txtNombreCliente.Focus();
        }

        private void txtApellidoCliente_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtApellidoCliente, "Apellido"))
                txtApellidoCliente.Focus();
        }

        private void dtpFechaNacimientoCliente_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarFechaNacimiento(dtpFechaNacimientoCliente))
                dtpFechaNacimientoCliente.Focus();
        }

        private void txtDireccionCliente_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtDireccionCliente, "Direccion"))
                txtDireccionCliente.Focus();
        }

        private void txtEmailCliente_Leave(object sender, EventArgs e)
        {
            string email = txtEmailCliente.Text.Trim();
            if (!Utilidades.ValidarEmail(txtEmailCliente) || string.IsNullOrWhiteSpace(email))
               txtEmailCliente.Focus();
            
        }

        private void txtTelefonoCliente_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtTelefonoCliente, "Telefono Socio"))
                txtTelefonoCliente.Focus();
        }

        private void txtContactoUrgenciaCliente_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarCampoNoVacio(txtContactoEmergenciaCliente, "Contacto Urgencia"))
                txtContactoEmergenciaCliente.Focus();
        }

        private void txtFichaMedicaCliente_Leave(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarNumerico(txtFichaMedicaCliente, "Ficha"))
                txtFichaMedicaCliente.Focus();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            dtpFechaNacimientoCliente.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimientoCliente.CustomFormat = "dd/MM/yyyy";
            Socio nuevo = null;
            NoSocio nuevoNoSocio = null;
            this.Close();

            if (tipo == "Socio")
            {

                nuevo = new Socio(
                dni,
                txtApellidoCliente.Text.Trim(),
                txtNombreCliente.Text.Trim(),
                dtpFechaNacimientoCliente.Value.ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("yyyy-MM-dd"),
                txtDireccionCliente.Text.Trim(),
                txtEmailCliente.Text.Trim(),
                txtTelefonoCliente.Text.Trim(),
                txtContactoEmergenciaCliente.Text.Trim(),
                txtFichaMedicaCliente.Text.Trim(),
                bool.Parse("true")
                );
            }
            else
            {
                nuevoNoSocio = new NoSocio(

                dni,
                txtApellidoCliente.Text.Trim(),
                txtNombreCliente.Text.Trim(),
                dtpFechaNacimientoCliente.Value.ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("yyyy-MM-dd"),
                txtDireccionCliente.Text.Trim(),
                txtEmailCliente.Text.Trim(),
                txtTelefonoCliente.Text.Trim(),
                txtContactoEmergenciaCliente.Text.Trim(),
                txtFichaMedicaCliente.Text.Trim()
                );
            };

       

            if (tipo == "Socio")
            {
                frmpagoCuotaSocial pagoCuotaSocial = new frmpagoCuotaSocial(nuevo);
                pagoCuotaSocial.Show();
            }
            else if (tipo == "No Socio")
            {
                frmregActividad registrarActividad = new frmregActividad(nuevoNoSocio);
                registrarActividad.Show();
            };
        }
    }
}
