using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final
{

    public static class Utilidades
    {
        public static void LimpiarControles(Control contenedor, Control primerControl = null)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                switch (ctrl)
                {
                    case TextBox txt:
                        txt.Text = txt.Tag?.ToString() ?? "";
                        break;

                    case ComboBox cbo:
                        cbo.SelectedIndex = -1;
                        break;

                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;

                    case CheckBox chk:
                        chk.Checked = false;
                        break;

                    case RadioButton rdo:
                        rdo.Checked = false;
                        break;

                    case ListBox lst:
                        lst.ClearSelected();
                        break;

                    case MaskedTextBox mtxt:
                        mtxt.Clear();
                        break;
                }

                // Si el control contiene otros controles (como GroupBox, Panel, TabPage), limpiar también los hijos
                if (ctrl.HasChildren)
                {
                    LimpiarControles(ctrl);
                }
            }

            // Opcional: enfocar el primer control
            primerControl?.Focus();
        }

        public static  bool ValidarCampoNoVacio(Control control, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.BackColor = Color.MistyRose;
                MessageBox.Show($"El campo {nombreCampo} no puede estar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            control.BackColor = SystemColors.Window;
            return true;
        }

        public static bool ValidarEmail(Control control)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(control.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                control.BackColor = Color.MistyRose;
                MessageBox.Show("El correo electrónico no es válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            control.BackColor = SystemColors.Window;
            return true;
        }

        public static bool ValidarNumerico(Control control, string nombreCampo)
        {
            if ( !int.TryParse(control.Text, out int value) || value==0 )
            {
                control.BackColor = Color.MistyRose;
                MessageBox.Show($"El campo {nombreCampo} debe ser numérico.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            control.BackColor = SystemColors.Window;
            return true;
        }

        public static bool ValidarFechaNacimiento(DateTimePicker picker)
        {
            if (picker.Value.Date == DateTime.Now.Date)
            {
                picker.CalendarMonthBackground = Color.MistyRose;
                MessageBox.Show("La fecha de nacimiento no puede ser la fecha actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            picker.CalendarMonthBackground = SystemColors.Window;
            return true;
        }

        public static DataTable CrearTablaDesdeDb(string query)

        {
            try
            {
                using (var conn = new Conexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn.Abrir());
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                };
                
            }
            catch
            {
                MessageBox.Show("Error al abrir la tabla desde la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }


}

