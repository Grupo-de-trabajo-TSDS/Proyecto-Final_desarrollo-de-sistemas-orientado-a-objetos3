using System;
using MySql.Data.MySqlClient;
using Proyecto_Final;

public class Persona
{
    private string dni;
    private string apellido;
    private string nombre;
    private string fechanac;
    private string fechainscrip;
    private string direccion;
    private string email;
    private string telefono;
    private string conturgencia;
    private string fichamed;

    //constructor
    public Persona(string dni, string apellido, string nombre, string fechanac, string fechainscrip, string direccion, string email, string telefono, string conturgencia, string fichamed)
    {
        this.dni = dni;
        this.apellido = apellido;
        this.nombre = nombre;
        this.fechanac = fechanac;
        this.fechainscrip = fechainscrip;
        this.direccion = direccion;
        this.email = email;
        this.telefono = telefono;
        this.conturgencia = conturgencia;
        this.fichamed = fichamed;
    }

    //getter y setter
    public string Dni { get { return dni; } set { dni = value; } }
    public string Apellido { get { return apellido; } set { apellido = value; } }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Fechanac { get { return fechanac; } set { fechanac = value; } }
    public string Fechainscrip { get { return fechainscrip; } set { fechainscrip = value; } }
    public string Direccion { get { return direccion; } set { direccion = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }
    public string Conturgencia { get { return conturgencia; } set { conturgencia = value; } }
    public string Fichamed { get { return fichamed; } set { fichamed = value; } }
}

public class Socio : Persona
{
    private bool estado;

    //constructor
    public Socio(string dni, string apellido, string nombre, string fechanac, string fechainscrip, string direccion, string email, string telefono, string conturgencia, string fichamed, bool estado) : base(dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed)
    {
        this.estado = estado;
    }

    //getter y setter
    public bool Estado { get { return estado; } set { estado = value; } }



    //methods    

    public bool pagarCuota(double valor, string modo)
    {
        try
        {
            using (var conn = new Conexion())
            {
                var con = conn.Abrir();
                string query = @"INSERT INTO Cuota (idsocio, preciocuotasocial, fechapago, metodopago)
                             VALUES (@dni, @valor, @fecha, @modo)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@dni", this.Dni);
                    cmd.Parameters.AddWithValue("@valor", valor.ToString());
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modo", modo);
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }
        catch
        {
            return false;
        }
    }

    public bool inscripcionSocio(Socio nuevo)
    {
        try
        {
            using (var conn = new Conexion())
            {
                var con = conn.Abrir();
                string query = @"INSERT INTO Socio 
                            (dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed, socio, estado) 
                            VALUES 
                            (@dni, @apellido, @nombre, @fechanac, @fechainscrip, @direccion, @email, @telefono, @conturgencia, @fichamed, 1, 1)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@dni", nuevo.Dni);
                    cmd.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                    cmd.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                    cmd.Parameters.AddWithValue("@fechanac", nuevo.Fechanac);
                    cmd.Parameters.AddWithValue("@fechainscrip", nuevo.Fechainscrip);
                    cmd.Parameters.AddWithValue("@direccion", nuevo.Direccion);
                    cmd.Parameters.AddWithValue("@email", nuevo.Email);
                    cmd.Parameters.AddWithValue("@telefono", nuevo.Telefono);
                    cmd.Parameters.AddWithValue("@conturgencia", nuevo.Conturgencia);
                    cmd.Parameters.AddWithValue("@fichamed", nuevo.Fichamed);
                    cmd.Parameters.AddWithValue("@estado", nuevo.Estado ? 1 : 0);

                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }
        catch
        {
            return false;
        }
    }
}

public class NoSocio : Persona
{

    //constructor
    public NoSocio(string dni, string apellido, string nombre, string fechanac, string fechainscrip, string direccion, string email, string telefono, string conturgencia, string fichamed) : base(dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed)
    {

    }

    //methods
  
    public bool inscripcionNoSocio(NoSocio nuevo)
    {
        try
        {
            using (var conn = new Conexion())
            {
                var con = conn.Abrir();
                string query = @"INSERT INTO NoSocio 
                            (dni, apellido, nombre, fechanac, fechainscrip, direccion, email, telefono, conturgencia, fichamed) 
                            VALUES 
                            (@dni, @apellido, @nombre, @fechanac, @fechainscrip, @direccion, @email, @telefono, @conturgencia, @fichamed)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@dni", nuevo.Dni);
                    cmd.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                    cmd.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                    cmd.Parameters.AddWithValue("@fechanac", nuevo.Fechanac);
                    cmd.Parameters.AddWithValue("@fechainscrip", nuevo.Fechainscrip);
                    cmd.Parameters.AddWithValue("@direccion", nuevo.Direccion);
                    cmd.Parameters.AddWithValue("@email", nuevo.Email);
                    cmd.Parameters.AddWithValue("@telefono", nuevo.Telefono);
                    cmd.Parameters.AddWithValue("@conturgencia", nuevo.Conturgencia);
                    cmd.Parameters.AddWithValue("@fichamed", nuevo.Fichamed);

                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }
        catch
        {
            return false;
        }
    }

    public bool pagarActividad(string idactividad, double valor, string modo)
    {
        try
        {
            using (var conn = new Conexion())
            {
                var con = conn.Abrir();
                string query = @"INSERT INTO Pago_Actividad (idactividad, idnsocio, fechapago, precioactividad, metodopago)
                             VALUES (@idactividad, @dni, @valor, @fecha, @modo)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idactividad", idactividad.ToString());
                    cmd.Parameters.AddWithValue("@dni", this.Dni);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@valor", valor.ToString());
                    cmd.Parameters.AddWithValue("@modo", modo);

                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
        }
        catch
        {
            return false;
        }
    }
}



