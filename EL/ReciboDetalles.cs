using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("ReciboDetalles")]
    public class ReciboDetalles
    {
        [Key]
        public int IdReciboDetalle { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Recibo { get; set; }
        [Required]
        public int Producto { get; set; }
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
