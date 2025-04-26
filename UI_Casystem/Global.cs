using ControllerEntity;
using DataEntity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Casystem
{
    public static class Global
    {
        public static RegistroDataEntity RDE = new();
        public static RegistroController RC = new();
        public static Usuario CurrentUser = new();
        public static LoginController LC = new();
        public static Listado GlobalLista = new();
        public static ListadoDataEntity LDE = new();
        public static ListadoController LDC = new();
        public static Asistente AsistenciaModel = new();
        public static AsistenciaDataEntity ADE = new();
        public static AsistenciaController AC = new();
    }
}
