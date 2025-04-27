using Models;
using System.Data;

namespace ControllerEntity
{
    public class AsistenciaController
    {
        public AsistenciaController() { }

        public void CreateObjAsistencia(string NombreAsistente, string Departamento, bool CheckAsistencia)
        {
            // Modelo de asistencia
            uint idLista = Global.CurrentListId;
            Global.AsistenciaModel.idLista = (int)idLista;
            Global.AsistenciaModel.NombreAsistente = NombreAsistente;
            Global.AsistenciaModel.Departamento = Departamento;
            Global.AsistenciaModel.Asistencia = CheckAsistencia;
        }

        //Método para guardar la asistencia
        public bool SaveAsistencia(Asistente asistencia)
        {
            return Global.ADE.MthAddAsistencia(asistencia); // retorna un boleano
        }

        //Mth para traer el listado de asistencia

        public DataTable MthTraerListadoAsistencia(string NombreTabla, int idListado)
        {
            return Global.ADE.MthGetAsistencia(NombreTabla, idListado);
        }
    }
}
