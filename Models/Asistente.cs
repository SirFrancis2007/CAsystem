using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Asistente
    {
        public int idAsistente { get; set; }
        public int idLista { get; set; }
        [Required]
        public string NombreAsistente { get; set; }
        [Required]
        public string Departamento { get; set; }
        [Required]
        public bool Asistencia { get; set; }
    }
}
