using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class BGEContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public BGEContext()
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

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Nombre)
                    .IsUnique();

                entity.Property(e => e.Desc)
                    .HasMaxLength(500);

                entity.Property(e => e.Fecha)
                    .IsRequired();

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(9);

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

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Cvu)
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nombre)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                      .IsRequired()
                      .HasMaxLength(500);

                entity.Property(e => e.Precio)
                      .IsRequired()
                      .HasColumnType("decimal(18,2)"); 


            });
        }
    }
}
