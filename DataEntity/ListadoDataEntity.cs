using System.Data;
using System.Data.SQLite;

namespace DataEntity
{
    public class ListadoDataEntity
    {
        // Crea un método "TraerTablas" que reciba por parámetro un DataGridView.
        // Dentro del método hace una query con un select a la tabla Listado según
        // el email de la persona y llena el DataGridView con los datos obtenidos.

        public bool InsertVef;
        public static uint xidLista; // idLista => id de la tabla Listado
        DataTable DGVListado = new DataTable(); // DGV => DataGridView

        public bool NuevaLista(string NombreLista, string email)
        {
            try
            {
                using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string query = "INSERT INTO Listado (NombreLista, EmailUsuario) VALUES (@xNombreLista, @xemail)";

                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@xNombreLista", NombreLista);
                        comando.Parameters.AddWithValue("@xemail", email);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        InsertVef = filasAfectadas > 0;
                    }
                }
                return InsertVef;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable TraerListado(string Email)
        {
            // Query a SQLite
            var query = "SELECT idLista, NombreLista FROM Listado WHERE EmailUsuario = @xEmail";
            DataTable resultTable = new DataTable();

            try
            {
                using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
                {
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@xEmail", Email);
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
                return resultTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el listado: " + ex.Message);
            }
        }

    }
}
