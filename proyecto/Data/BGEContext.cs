using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class BGEContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        internal BGEContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("La cadena de conexión 'DefaultConnection' no está definida en appsettings.json.");
                }

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                // Restricción única para Email
                entity.HasIndex(e => e.Email)
                    .IsUnique();

                entity.Property(e => e.NumeroTelefono)
                    .HasMaxLength(15);

                entity.Property(e => e.FechaNac)
                    .IsRequired();

                entity.Property(e => e.Instagram)
                    .HasMaxLength(100);
            });

            /*modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Nombre)
                    .IsUnique();

                // Datos iniciales
                entity.HasData(
                    new { Id = 1, Nombre = "Argentina" },
                    new { Id = 2, Nombre = "Brasil" },
                    new { Id = 3, Nombre = "Chile" },
                    new { Id = 4, Nombre = "Uruguay" },
                    new { Id = 5, Nombre = "Paraguay" }
                );
        });*/
        }
    }
}
