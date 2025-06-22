using System;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    public partial class frmPrincipal : Form
    {
        private string _dni;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInscribirSocio_Click(object sender, EventArgs e)
        {

            FrmInscribirSocio inicio = new FrmInscribirSocio(_dni);
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo

        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            // Abrir frmCobrarCuota
            frmPagoCuotaSocial inicio = new frmPagoCuotaSocial(_dni);

            inicio.Show();
            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {
            // Abrir frmGenerarCarnet
            FrmGenerarCarnet inicio = new FrmGenerarCarnet(_dni);
            inicio.Show();
            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }
        private void btnInscribirNoSocio_Click(object sender, EventArgs e)
        {
            // Abrir frmInscribirNoSocio
            FrmInscribirNoSocio inicio = new FrmInscribirNoSocio(_dni);
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }

        private void btnAsociarActividad_Click(object sender, EventArgs e)
        {
            // Abrir frmAsociarActividad
            frmRegistrarActividad inicio = new frmRegistrarActividad();
            inicio.Show();
            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }

        private void btnListadoMorosos_Click(object sender, EventArgs e)
        {
            // Abrir frmListadoMorosos
            FrmListadoMorosos inicio = new FrmListadoMorosos();
            inicio.Show();
            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Abrir frmPrincipal
            frmLogin inicio = new frmLogin();
            inicio.Show();

            // Cerrar el formulario actual
            this.Close(); // o this.Hide(); si querés solo ocultarlo
        }

        
    }
}
