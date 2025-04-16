using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class LoginDataEntity
    {
        public LoginDataEntity()
        {
            
        }

        public bool VefCredenciales(string email, string contraseña)
        {
            bool credencialesValidas = false;

            using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT Email, contrasena FROM Usuario WHERE Email = @Email AND contrasena = @Contraseña;";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);

                    using (SQLiteDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            credencialesValidas = true;
                        }
                    }
                }
            }

            return credencialesValidas;
        }
    }
}
