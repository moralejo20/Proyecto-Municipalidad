using Microsoft.EntityFrameworkCore;


namespace Proyecto_Municipalidad.Models

   
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) { }

        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<Evento> Evento{ get; set; }
        // public DbSet</**/>  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Noticia>().ToTable("Equipo");
            //modelBuilder.Entity<//>().ToTable("//");
        }
    }
}

