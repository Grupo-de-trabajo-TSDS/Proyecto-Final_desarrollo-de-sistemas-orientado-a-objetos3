using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final

{
    public class Conexion : IDisposable
    {
        private static readonly string cadena = "server=mysql-gttsds.alwaysdata.net; database=gttsds_1; user=gttsds; password=grab&&71;";
        private MySqlConnection conn;

        //Constructor
        public  Conexion()
        {
            conn = new MySqlConnection(cadena);
        }

        //Métodos para trabajar conexiones
        public MySqlConnection Abrir()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public void Cerrar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public void Dispose()
        {
            Cerrar(); // se asegura de cerrar la conexión
            conn.Dispose();
        }

        public void ProbarConexion() //Método desarrollado sólo para probar la conectividad con la BD
        {                            //No tiene aplicación en el sistema

            using (Conexion conn = new Conexion())
            //Conexion conn = Conexion();
            {
                try
                {
                    conn.Abrir();
                    MessageBox.Show("Conexión exitosa.");
                    conn.Cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }

            }
        }

    }
}

    


    