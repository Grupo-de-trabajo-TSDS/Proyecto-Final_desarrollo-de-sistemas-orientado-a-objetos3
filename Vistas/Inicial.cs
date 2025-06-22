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
    
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
            pnlnoSocio.Visible = false;
            pnlSocio.Visible = false;
            pnlinscrip.Visible = false;
        }

        private void txtDniInicial_Leaving(object sender, EventArgs e)
        {  
            string dni = txtDniInicial.Text.Trim();

            if (!Utilidades.ValidarNumerico(txtDniInicial, "DNI"))
            {
                txtDniInicial.Focus(); // txtDniInicial.Focus();
            }
            else
            {
                var resultado = Utilidades.ExisteClientePorDNI(dni);
                if (resultado.nombre != null)
                {
                    MessageBox.Show("Este DNI ya está registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView.Rows.Clear();
                    dataGridView.Rows.Add(resultado.nombre, resultado.apellido, resultado.tipoCliente, resultado.deudor);
                    pnlResultado.Visible = true;
                    pnlinscrip.Visible = false;
                    if (resultado.tipoCliente == "Socio")
                    {
                        Socio objsocio = Utilidades.ObtenerSocioPorDni(dni);
                        pnlSocio.Visible = true;
                        pnlnoSocio.Visible = false;
                    }
                    else 
                    {
                        NoSocio objnoSocio = Utilidades.ObtenerNoSocioPorDni(dni);
                        pnlnoSocio.Visible = true;
                        pnlSocio.Visible = false;
                    }

                }
                else
                {
                    // Show "No Inscripto" message
                    pnlResultado.Visible = false;
                    pnlinscrip.Visible = true;
                }
            }
        }

        private void frmInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btninscrpcionSocio_Click(object sender, EventArgs e)
        {
           frminscribirCliente inicio = new frminscribirCliente(txtDniInicial.Text.Trim(),"Socio");
            inicio.Show();
            this.Close();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void btninscripcionNoSocio_Click(object sender, EventArgs e)
        {
            frminscribirCliente inicio = new frminscribirCliente(txtDniInicial.Text.Trim(), "No Socio");
            inicio.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpagaCuota_Click(object sender, EventArgs e)
        {
            frmpagoCuotaSocial pago = new frmpagoCuotaSocial(txtDniInicial.Text.Trim());
            pago.Show();
            this.Close();
        }
        private void btnimprimeCarnet_Click(object sender, EventArgs e)
        {

        }

        private void btninscribirActividad_Click(object sender, EventArgs e)
        {
            frmregActividad regActividad = new frmregActividad(txtDniInicial.Text.Trim());
            regActividad.Show();
            this.Close();
        }

        private void btnimprimirCarnet_Click(object sender, EventArgs e)
        {

        }

        private void btnListadoMorosos_Click(object sender, EventArgs e)
        {

        }
    }
}
