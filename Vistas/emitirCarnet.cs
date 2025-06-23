using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;



namespace Proyecto_Final.Vistas
{
    public partial class FrmGenerarCarnet : Form
    {
        NoSocio nosocio = null;
        Socio socio = null;
        public FrmGenerarCarnet(string dni, string tipo)
        {
            InitializeComponent();
            if(tipo == "Socio")
            {
                socio = Utilidades.ObtenerSocioPorDni(dni);
                lblNombre.Text = socio.Nombre;
                lblApellido.Text = socio.Apellido;
                lblTipo.Text = "Socio";
                lblFechaInscrip.Text = socio.Fechainscrip.ToString();
                txtDni.Text = socio.Dni;

            }
            else if (tipo == "No Socio")
            {
                nosocio = Utilidades.ObtenerNoSocioPorDni(dni);
                lblNombre.Text = nosocio.Nombre;
                lblApellido.Text = nosocio.Apellido;
                lblTipo.Text = "No Socio";
                lblFechaInscrip.Text = nosocio.Fechainscrip.ToString();
                txtDni.Text = nosocio.Dni;
            }

        }

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        

        private void StartCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No webcam found.");
                return;
            }
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += (s, e) =>
            {
                pictureBox1.Image = (Bitmap)e.Frame.Clone();
            };
            videoSource.Start();
        }




        private void CaptureImage()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save("captured.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Image saved!");
            }
        }



        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
                videoSource.SignalToStop();
        }

        private void btnActivarCamara_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void btnCapturarImagen_Click(object sender, EventArgs e)
        {
            CaptureImage();
            if (videoSource != null && videoSource.IsRunning)
                videoSource.SignalToStop();

        }

        private void FrmGenerarCarnet_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverAnterior_Click(object sender, EventArgs e)
        {
            frmInicial inicio = new frmInicial();
            inicio.Show();
            this.Hide();
        }
    }

}
