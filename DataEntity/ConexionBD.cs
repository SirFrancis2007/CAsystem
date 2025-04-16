using System;
using System.Data.SQLite;

namespace DataEntity
{
    public class ConexionBD
    {
        private static string cadenaConexion = "Data Source=BDC.db;Version=3;";

        public static SQLiteConnection ObtenerConexion()
        {
            try
            {
                SQLiteConnection conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
