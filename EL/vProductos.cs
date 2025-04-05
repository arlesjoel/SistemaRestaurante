using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table ("vProductos")]
    public class vProductos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        [MaxLength (100)]
        public string Producto { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int ProductoCategoria { get; set; }
        [Required]
        [MaxLength(100)]
        public string Categorias { get; set; }
    }
}
