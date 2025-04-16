using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Usuario
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Contraseña { get; set; }
    }
}
