using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Listado
    {
        public uint idLista { get; set; }
        [Required]
        public string NombreLista { get; set; }
        public string EmailUsuario{ get; set; }
    }
}
