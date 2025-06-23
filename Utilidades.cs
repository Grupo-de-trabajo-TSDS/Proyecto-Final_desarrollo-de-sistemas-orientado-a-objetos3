using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Collections.Generic;
using System.Net;

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

        public static bool ValidarCampoNoVacio(Control control, string nombreCampo)
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
            if (!long.TryParse(control.Text, out long value) || value == 0)
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

        public static (string apellido, string nombre, string tipoCliente, string deudor) ExisteClientePorDNI(string dni)
        {
            var contenido = (apellido: "", nombre: "", tipoCliente: "", deudor: "");
            using (Conexion conpar = new Conexion())
            {
                using (MySqlConnection conn = conpar.Abrir())
                {
                    string query = "SELECT apellido, nombre, estado FROM Socio WHERE dni = @dni";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int valor = reader.GetInt32(reader.GetOrdinal("estado"));
                                contenido.apellido = reader["apellido"]?.ToString() ?? "";
                                contenido.nombre = reader["nombre"]?.ToString() ?? "";
                                contenido.tipoCliente = "Socio";
                                contenido.deudor = (valor > 0) ? "Sin deuda" : "Con Deuda";
                            }
                        }
                    }
                    if (contenido.apellido == "" && contenido.nombre == "")
                    {
                        query = "SELECT apellido, nombre FROM NoSocio WHERE dni = @dni";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@dni", dni);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    contenido.apellido = reader["apellido"]?.ToString() ?? "";
                                    contenido.nombre = reader["nombre"]?.ToString() ?? "";
                                    contenido.tipoCliente = "NoSocio";
                                    contenido.deudor = "--";
                                }

                            }
                        }
                    }
                }
                conpar.Cerrar();
                if (contenido.apellido == "" && contenido.nombre == "")
                {
                    return (null, null, null, null); // No se encontró el cliente
                }
                else
                {
                    return (contenido.apellido, contenido.nombre, contenido.tipoCliente, contenido.deudor); // Se encontró el cliente
                }
            }
        }

        public static void Actualizar_status_socios()
        {
            string query = @"
            UPDATE Socio s
            LEFT JOIN (
            SELECT idsocio, MAX(fechapago) AS ult_fechapago
            FROM Cuota
            GROUP BY idsocio
            ) c ON s.dni = c.idsocio
            SET s.estado = CASE
            WHEN c.ult_fechapago IS NULL THEN 0
            WHEN DATE_ADD(c.ult_fechapago, INTERVAL 31 DAY) < CURDATE() THEN 0
            ELSE 1
            END
            ";
            
            try
            {
                using (var conn = new Conexion())
                {
                    using (var cmd = new MySqlCommand(query, conn.Abrir()))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando estado de socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Socio ObtenerSocioPorDni(string dni)
        {
            try
            {
                using (var conn = new Conexion())
                {
                    var con = conn.Abrir();
                    string query = @"SELECT dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed, estado
                             FROM Socio WHERE dni = @dni";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Adjust column indexes/names as needed
                                return new Socio(
                                    reader["dni"].ToString(),
                                    reader["apellido"].ToString(),
                                    reader["nombre"].ToString(),
                                    reader["fechanac"].ToString(),
                                    reader["fechainscrip"].ToString(),
                                    reader["direccion"].ToString(),
                                    reader["email"].ToString(),
                                    reader["telefono"].ToString(),
                                    reader["conturgencia"].ToString(),
                                    reader["fichamed"].ToString(),
                                    Convert.ToBoolean(reader["estado"])
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el socio: " + ex.Message);
            }
            return null;
        }
    
        public static NoSocio ObtenerNoSocioPorDni(string dni)
        {
            try
            {
                using (var conn = new Conexion())
                {
                    var con = conn.Abrir();
                    string query = @"SELECT dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed
                             FROM NoSocio WHERE dni = @dni";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Adjust column indexes/names as needed
                                return new NoSocio(
                                    reader["dni"].ToString(),
                                    reader["apellido"].ToString(),
                                    reader["nombre"].ToString(),
                                    reader["fechanac"].ToString(),
                                    reader["fechainscrip"].ToString(),
                                    reader["direccion"].ToString(),
                                    reader["email"].ToString(),
                                    reader["telefono"].ToString(),
                                    reader["conturgencia"].ToString(),
                                    reader["fichamed"].ToString()
                                    );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el socio: " + ex.Message);
            }
            return null;
        }

        public static DataTable ObtenerSociosMorosos()
        {
            string query = "SELECT dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono FROM Socio WHERE estado = 0";
            return CrearTablaDesdeDb(query);
        }
    }
}