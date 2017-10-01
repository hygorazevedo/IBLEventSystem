using IBLEventSystem.Domain.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IBLEventSystem.Entity.Contexto
{
    public class IBLContext : DbContext
    {
        public IBLContext()
            : base("ConexaoIBL")
        {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
