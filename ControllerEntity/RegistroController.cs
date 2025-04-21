using System;
using System.Collections.Generic;
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
        public RegistroController() {}

        public void BefInsData(Usuario BefInsUsuario)
        {
            ValidateUser(BefInsUsuario);
            AddNewUser(BefInsUsuario);
        }

        public bool ValidateUser(Usuario BefInsUsuario)
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

        public Usuario CreateObjectUser(string xnombre, string xemail, string xcontraseña)
        {
            try
            {
                Usuario NuevoUsuario = new Usuario
                {
                    Nombre = xnombre,
                    Email = xemail,
                    Contraseña = xcontraseña
                };

                return NuevoUsuario;
            }
            catch
            {
                return null;
            }
        }

        public bool AddNewUser(Usuario NewUser)
        {
            try
            {
                RegistroDataEntity registroDataEntity = new RegistroDataEntity();
                return registroDataEntity.MthAddNewUser(NewUser); ;
            }
            catch
            {
                return false;
            }
        }
    }
}
