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
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Fiesta> Fiestas {get; set;}
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

            modelBuilder.Entity<Lote>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Precio)
                    .IsRequired()
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FechaDesde)
                    .IsRequired();

                entity.Property(e => e.FechaHasta)
                    .IsRequired();

                entity.Property(e => e.CantidadLote)
                    .IsRequired();

                entity.HasIndex(e => e.Nombre)
                    .IsUnique();
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => new { e.IdVendedor, e.IdCliente, e.FechaHora});

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
                    Desc = "Banda local tocando en vivo, ¡imperdible!"
                },

                new  
                {
                    Id = 2,
                    Nombre = "Feria de Artesanía",
                    Desc = "Exposición de productos hechos a mano por artistas locales."
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
                    Dni = "qwe",
                    Nombre = "Ana",
                    Apellido = "Gomez",
                    Email = "ana.gomez@example.com",
                    Contrasena = "qwe", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Vendedor",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(1985, 10, 20),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 10,
                    Dni = "zxc",
                    Nombre = "Martin",
                    Apellido = "Perez",
                    Email = "mar.perez@example.com",
                    Contrasena = "zxc", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Jefe",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(2005, 10, 20),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 3,
                    Dni = "asd",
                    Nombre = "Joaquin",
                    Apellido = "Lopez",
                    Email = "joaco.lopez@example.com",
                    Contrasena = "asd", // Usar un hash real aquí
                    Cvu = "91823918239128319823",
                    Tipo = "Administrador",
                    NumeroTelefono = "3211321331",
                    FechaNac = new DateTime(1980, 3, 4),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 4,
                    Dni = "1234",
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Email = "juan4.perez@example.com",
                    Contrasena = "1234", // Usar un hash real aquí
                    Cvu = "1111222233334444555566",
                    Tipo = "Cliente",
                    NumeroTelefono = "600111222",
                    FechaNac = new DateTime(1990, 5, 15),
                    Instagram = "@juanperez"
                },
                new
                {
                    Id = 5,
                    Dni = "1235",
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Email = "juan.perez5@example.com",
                    Contrasena = "1235", // Usar un hash real aquí
                    Cvu = "1111222233334444555566",
                    Tipo = "Cliente",
                    NumeroTelefono = "600111222",
                    FechaNac = new DateTime(1990, 5, 15),
                    Instagram = "@juanperez"
                },
                new
                {
                    Id = 6,
                    Dni = "qwe",
                    Nombre = "Ana",
                    Apellido = "Gomez",
                    Email = "ana.gomez6@example.com",
                    Contrasena = "qwe6", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Vendedor",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(1985, 10, 20),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 7,
                    Dni = "qwe7",
                    Nombre = "Ana",
                    Apellido = "Gomez",
                    Email = "ana.gomez7@example.com",
                    Contrasena = "qwe7", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Vendedor",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(1985, 10, 20),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 8,
                    Dni = "asd8",
                    Nombre = "Joaquin",
                    Apellido = "Lopez",
                    Email = "joaco.lopez8@example.com",
                    Contrasena = "asd8", // Usar un hash real aquí
                    Cvu = "91823918239128319823",
                    Tipo = "Administrador",
                    NumeroTelefono = "3211321331",
                    FechaNac = new DateTime(1980, 3, 4),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 9,
                    Dni = "asd",
                    Nombre = "Joaquin",
                    Apellido = "Lopez",
                    Email = "joaco.lopez9@example.com",
                    Contrasena = "asd9", // Usar un hash real aquí
                    Cvu = "91823918239128319823",
                    Tipo = "Administrador",
                    NumeroTelefono = "3211321331",
                    FechaNac = new DateTime(1980, 3, 4),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 11,
                    Dni = "zxc2",
                    Nombre = "Martin",
                    Apellido = "Perez",
                    Email = "mar.perez2@example.com",
                    Contrasena = "zxc2", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Jefe",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(2005, 10, 20),
                    Instagram = "@anagomez"
                },
                new
                {
                    Id = 12,
                    Dni = "zxc3",
                    Nombre = "Martin",
                    Apellido = "Perez",
                    Email = "mar.perez3@example.com",
                    Contrasena = "zxc3", // Usar un hash real aquí
                    Cvu = "9999888877776666555544",
                    Tipo = "Jefe",
                    NumeroTelefono = "600333444",
                    FechaNac = new DateTime(2005, 10, 20),
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

            modelBuilder.Entity<Lugar>().HasData(
                new
                {
                    Id = 1,
                    Nombre = "La sala de las Artes.",
                    Direccion = "Av Ovidio Lagos y Guemes",
                    Ciudad = "Rosario"
                },
                new
                {
                    Id = 2,
                    Nombre = "Teatro Vorterix.",
                    Direccion = "Av Ovidio Lagos y Guemes",
                    Ciudad = "Buenos Aires"
                }
            );
            modelBuilder.Entity<Compra>().HasData(
                new
                {
                    FechaHora = new DateTime(2025, 10, 15, 5, 12, 5),
                    CantidadCompra = 4,
                    Entrada = "entrada-1",
                    IdVendedor = 10,
                    IdCliente = 1,
                    IdFiesta = 1
                },
                new
                {
                    FechaHora = new DateTime(2025, 10, 15, 5, 13, 5),
                    CantidadCompra = 5,
                    Entrada = "entrada-2",
                    IdVendedor = 10,
                    IdCliente = 1,
                    IdFiesta = 1
                },
                new
                {
                    FechaHora = new DateTime(2025, 10, 15, 5, 14, 5),
                    CantidadCompra = 6,
                    Entrada = "entrada-3",
                    IdVendedor = 10,
                    IdCliente = 1,
                    IdFiesta = 1
                }
            );

            modelBuilder.Entity<Fiesta>(entity =>
            {
                entity.HasKey(e => new { e.IdFiesta });

                entity.Property(e => e.IdFiesta)
                .IsRequired();

                entity.Property(e => e.IdLugar)
                    .IsRequired();

                entity.Property(e => e.IdEvento)
                    .IsRequired();

                entity.Property(e => e.FechaFiesta)
                    .IsRequired();

                entity.HasOne<Lugar>()
                    .WithMany()
                    .HasForeignKey(c => c.IdLugar)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Evento>()
                    .WithMany()
                    .HasForeignKey(c => c.IdEvento)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
