using EventPlus.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Context
{
    public class EventContext : DbContext
    {
        public EventContext()
        {
        }

        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }
        //Ctrl + D = Duplica a linha
        public DbSet<ComentarioEvento> ComentarioEvento { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<PresencasEventos> PresencasEventos { get; set; }
        public DbSet<TiposEventos> TiposEventos { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LAO5MIJ\\SQLEXPRESSTEC; Database=EventPlus;TrustServerCertificate=true; User Id= sa; Pwd = abc123;");
            }
        }
    }
}
