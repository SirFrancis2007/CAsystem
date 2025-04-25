using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerEntity
{
    public class LoginController
    {
        public LoginController() { }

        public bool BefVefCredencial(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || IsPasswordStrong(password))
            {
                return false;
            }
            return true;
        }

        internal string ValidateEmail(string email)
        {
            if (email.Contains("!#$%&/()=?¡¿'¨*[]"))
                return null;
            else return email;
        }

        internal bool IsPasswordStrong(string password)
        {
            if (password.Length < 8) return false;
            if (!password.Any(char.IsUpper)) return false;
            if (!password.Any(char.IsDigit)) return false;
            return true;
        }

        public bool PassCredencial(string email, string password)
        {
            try { 
                if (!BefVefCredencial(email, password))
                    throw new ArgumentException("Datos no aceptados");

                LoginDataEntity _IngresoDataEntity = new LoginDataEntity();
                return _IngresoDataEntity.VefCredenciales(email, password);
            }
            catch
            {
                return false;
            }
        } 
    }
}
