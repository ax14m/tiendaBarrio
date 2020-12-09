using tiendaBarrio.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;





namespace tiendaBarrio.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}