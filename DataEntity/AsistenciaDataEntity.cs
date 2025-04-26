using DataEntity.DataEntity;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Casystem;

namespace DataEntity
{
    public class AsistenciaDataEntity
    {
        // crear un metodo de agregar asistencia y un meotodo de obtener las asuistencia segun el id de la lista 
        // Mnesaje: Para el reporte hacer valores contable de asistencia y no asistencia para evitar complejidad.
        public bool InsertVef;
        DataTable DGVListadoAsistencia = new DataTable(); // DGV => DataGridView de Listado de asistencia.
        public bool MthAddAsistencia(Asistente asistente)
        {
            try
            {
                using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string query = @"INSERT INTO Asistencia 
                                (idlistado, Nombre, Departamento, Asistencia) 
                                VALUES (@xidLista, @xNombre, @xDepartamento, @xAsistencia)";

                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@xidLista", SessionData.CurrentListId);
                        comando.Parameters.AddWithValue("@xNombre", asistente.NombreAsistente);
                        comando.Parameters.AddWithValue("@xDepartamento", asistente.Departamento);
                        comando.Parameters.AddWithValue("@xAsistencia", asistente.Asistencia);

                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar asistencia: {ex.Message}");
                return false;
            }
        }

        // Mth que trae las asistencia de la lista segun el id de la lista preseleccionada.
        public DataTable MthGetAsistencia(string NombreTabla, int idListado)
        {
            DataTable resultTable = new DataTable();
            var query = "SELECT Nombre, Departamento, Asistencia FROM Asistencia WHERE idlistado = @xidLista";

            try
            {
                using (SQLiteConnection conexion = ConexionBD.ObtenerConexion())
                {
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@xidLista", idListado);
                        new SQLiteDataAdapter(comando).Fill(resultTable);
                    }
                }
                return resultTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener asistencia: {ex.Message}");
                return null;
            }
        }

    }
}
