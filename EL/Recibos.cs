using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Recibos")]
    public class Recibos
    {
        [Key]
        public int ReciboId { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal IVA { get; set; }
        [Required]
        public decimal PagoTotal { get; set; }
        [Required]
        public DateTime ReciboFecha { get; set; }
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
