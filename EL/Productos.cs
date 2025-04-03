using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Producto { get; set; }
        [Required]
        public decimal ProductoPrecio { get; set; }
        [Required]
        public int ProductoCategoria { get; set; }
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
