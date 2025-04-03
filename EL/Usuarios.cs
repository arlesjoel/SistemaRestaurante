using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [MaxLength(100)]
        public string NombreCompleto { get; set; }
        [Required]
        [MaxLength(8)]
        public string Telefono { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string NombreUsuario { get; set; }
        [Required]
        public byte[] Password { get; set; }
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
