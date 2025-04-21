using ControllerEntity;
using DataEntity.DataEntity;
using System.Data.SQLite;

namespace DataEntity
{
    public class LoginDataEntity
    {
        private bool credencialesValidas = false;

        public bool VefCredenciales(string email, string contraseña)
        {
            using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT Nombre, Email, Contraseña FROM Usuario WHERE Email = @xEmail AND Contraseña = @xContraseña;";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@xEmail", email);
                    comando.Parameters.AddWithValue("@xContraseña", contraseña);
                    comando.CommandType = System.Data.CommandType.Text;

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
