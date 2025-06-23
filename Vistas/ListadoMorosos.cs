using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    public partial class FrmListadoMorosos : Form
    {
        public FrmListadoMorosos()
        {
            InitializeComponent();
            CargarMorosos();
        }

        private void CargarMorosos()
        {
            DataTable morosos = Utilidades.ObtenerSociosMorosos();
            dgvMorosos.DataSource = morosos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
