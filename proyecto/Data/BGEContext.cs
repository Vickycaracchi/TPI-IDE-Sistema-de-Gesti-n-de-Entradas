using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class BGEContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Lugar> Lugares { get; set; }

        public DbSet<Compra> Compras { get; set; }
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

            modelBuilder.Entity<Usuario>(entity =>
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

                entity.Property(e => e.NumeroTelefono)
                    .HasMaxLength(15);

                entity.Property(e => e.FechaNac)
                    .IsRequired();

                entity.Property(e => e.Instagram)
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

            modelBuilder.Entity<Lugar>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Nombre)
                    .IsUnique();

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => new { e.IdVendedor, e.IdCliente, e.FechaHora });

                entity.Property(e => e.IdVendedor)
                    .IsRequired();

                entity.Property(e => e.IdCliente)
                    .IsRequired();

                entity.Property(e => e.FechaHora)
                    .IsRequired();

                entity.Property(e => e.CantidadCompra)
                    .IsRequired(); 

                entity.HasOne<Usuario>()
                    .WithMany() 
                    .HasForeignKey(c => c.IdVendedor)
                    .OnDelete(DeleteBehavior.Restrict); 

                entity.HasOne<Usuario>()
                    .WithMany() 
                    .HasForeignKey(c => c.IdCliente)
                    .OnDelete(DeleteBehavior.Restrict); 
            });

            modelBuilder.Entity<Evento>().HasData(
                new  
                {
                    Id = 1,
                    Nombre = "Concierto de Rock",
                    Desc = "Banda local tocando en vivo, ¡imperdible!",
                    Fecha = DateTime.Now.AddDays(10), Lugar = "The Venue" 
                },

                new  
                {
                    Id = 2,
                    Nombre = "Feria de Artesanía",
                    Desc = "Exposición de productos hechos a mano por artistas locales.",
                    Fecha = DateTime.Now.AddMonths(1),
                    Lugar = "Plaza Central" 
                }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new
                {
                    Id = 1,
                    Dni = "123",
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Email = "juan.perez@example.com",
                    Contrasena = "123", // Usar un hash real aquí
                    Cvu = "1111222233334444555566",
                    Tipo = "Cliente",
                    NumeroTelefono = "600111222",
                    FechaNac = new DateTime(1990, 5, 15),
                    Instagram = "@juanperez"
                },
                new
                {
                    Id = 2,
                    Dni = "111",
                    Nombre = "Ana",
                    Apellido = "Gomez",
                    Email = "ana.gomez@example.com",
                    Contrasena = "111", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Vendedor",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(1985, 10, 20),
                    Instagram = "@anagomez"
                }
            );

            modelBuilder.Entity<Producto>().HasData(
                new  
                { 
                    Id = 1,
                    Nombre = "Camiseta Oficial",
                    Descripcion = "Camiseta de algodón con logo del evento.",
                    Precio = 25.50m 
                },
                new  
                {
                    Id = 2,
                    Nombre = "Poster Limitado",
                    Descripcion = "Poster numerado de la feria, edición especial.",
                    Precio = 10.00m 
                }
            );
        }
    }
}
