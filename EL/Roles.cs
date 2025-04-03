using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public int IdRol { get; set; }
        [Required]
        [MaxLength(100)]
        public string Rol { get; set; }
        [Required]
        public DateTime FechaAsignacion { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public int UsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }
    }
}
