using ApiPruebaTecnica.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaTecnica.Contexto
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        public DbSet<Trabajador> Trabajadores {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trabajador>()
                .Property(t => t.Nombre)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Trabajador>()
                .Property(t => t.Apellido)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Trabajador>()
                .Property(t => t.Email)
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Trabajador>()
                .Property(t => t.Fecha_Inicio_Vigencia)
                .HasColumnType("datetime")
                .IsRequired();
        }

    }
}
