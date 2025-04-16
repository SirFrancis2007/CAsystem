using Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class RegistroDataEntity
    {
        public RegistroDataEntity()
        {
            
        }

        public void MthAddNewUser(Usuario NewUser)
        {
            using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO Usuario (Nombre, Email, Contraseña) VALUES (@Nombre, @Email, @Contraseña);";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", NewUser.Nombre);
                    comando.Parameters.AddWithValue("@Email", NewUser.Email);
                    comando.Parameters.AddWithValue("@Contraseña", NewUser.Contraseña);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
