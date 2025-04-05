using Microsoft.EntityFrameworkCore;
using EL;



namespace DAL
{
    public class BDSistemaRestaurante : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Conection.ConexionString(true));
        }

        public DbSet<Roles>? Roles { get; set; }
        public DbSet<Usuarios>? Usuarios { get; set; }
        public DbSet<Recibos>? Recibos { get; set; }
        public DbSet<ReciboDetalles>? ReciboDetalles { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<vProductos>? vProductos { get; set; }

    }
}