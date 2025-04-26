using UI_Casystem;
using Models;

namespace ControllerEntity
{
    public class RegistroController
    {

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
            Global.CurrentUser.Nombre = xnombre;
            Global.CurrentUser.Email = xemail;
            Global.CurrentUser.Contraseña = xcontraseña;
        }

        public bool AddNewUser(Usuario NewUser)
        {
            try
            {
                return Global.RDE.MthAddNewUser(NewUser);
            }
            catch
            {
                return false;
            }
        }
    }
}
