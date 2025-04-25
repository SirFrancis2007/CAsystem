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
    }
}
