using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;
using Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControllerEntity
{
    public class RegistroController
    {
        public Usuario CurrentUser = new();

        public void BefInsData(Usuario BefInsUsuario)
        {
            ValidateUserInput(BefInsUsuario);
            AddNewUser(BefInsUsuario);
        }

        public bool ValidateUserInput(Usuario BefInsUsuario)
        {
            if (string.IsNullOrEmpty(BefInsUsuario.Nombre) || string.IsNullOrEmpty(BefInsUsuario.Email) || IsPasswordStrong(BefInsUsuario.Contraseña) || string.IsNullOrEmpty(BefInsUsuario.Contraseña))
            {
                return false;
            }
            return true;
        }

        public bool IsPasswordStrong(string password)
        {
            if (password.Length < 8) return false;
            if (!password.Any(char.IsUpper)) return false;
            if (!password.Any(char.IsDigit)) return false;
            return true;
        }

        public void CreateObjectUser(string xnombre, string xemail, string xcontraseña)
        {
                CurrentUser.Nombre = xnombre;
                CurrentUser.Email = xemail;
                CurrentUser.Contraseña = xcontraseña;
        }

        public bool AddNewUser(Usuario NewUser)
        {
            try
            {
                RegistroDataEntity registroDataEntity = new();
                return registroDataEntity.MthAddNewUser(NewUser);
            }
            catch
            {
                return false;
            }
        }
    }
}
