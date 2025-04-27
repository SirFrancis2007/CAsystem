using DataEntity;
using Models;

namespace ControllerEntity
{
    public static class Global
    {
        public static AsistenciaDataEntity ADE = new();
        public static RegistroDataEntity RDE = new();
        public static ListadoDataEntity LDE = new();

        public static AsistenciaController AC = new();
        public static LoginController LC = new();
        public static ListadoController LDC = new();
        public static RegistroController RC = new();

        public static Listado GlobalLista = new();
        public static Asistente AsistenciaModel = new();

        public static Usuario CurrentUser = new();
        public static uint CurrentListId { get; set; }
    }
}
