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
    public partial class frmPagoCuotaSocial : Form
    {
        public frmPagoCuotaSocial()
        {
            InitializeComponent();
            LlenarTipoSocio();
        }

        private void cboFormasDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFormasDePago.SelectedIndex = 0; // Selects "Item 1"
        }

        private void txtMontoCuotaSocio_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void frmPagoCuotaSocial_Load(object sender, EventArgs e)
        {

        }

        private void LlenarTipoSocio()
        {
            
            string query = "SELECT categoria, valorcuota FROM cuotasocios";
            cboTipoSocio.DataSource = Utilidades.CrearTablaDesdeDb(query);
            cboTipoSocio.DisplayMember = "categoria";
            cboTipoSocio.ValueMember = "valorcuota";
        }

        private void cboTipoSocio_TextChanged(object sender, EventArgs e)
        {
            var valorSeleccionado = cboTipoSocio.SelectedValue; // valorcuota
            var categoriaSeleccionada = cboTipoSocio.Text;      // categoria
        }
    }
}
