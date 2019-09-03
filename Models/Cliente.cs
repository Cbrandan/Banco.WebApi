using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombre { get; set; }
        public DateTimeOffset? FechaNacimiento { get; set; }

        public DateTime FechaAlta { get; set; }

    }
}
