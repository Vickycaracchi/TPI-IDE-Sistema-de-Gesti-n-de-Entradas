using Domain.Model;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Entrada> Entradas {get; set; }
        public DbSet<CompraProducto> ComprasProductos { get; set; }
        public DbSet<FiestaLote> FiestasLotes { get; set; }
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

                entity.Property(e => e.IdJefe)
                    .IsRequired(false);

                entity.HasOne<Usuario>()
                    .WithMany()
                    .HasForeignKey(u => u.IdJefe)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => new { e.Id});

                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                      .IsRequired()
                      .HasMaxLength(500);

                entity.Property(e => e.Precio)
                      .IsRequired();
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
                entity.HasKey(e => new { e.Id });

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Nombre)
                    .IsUnique();

                entity.Property(e => e.Precio)
                    .IsRequired();

                entity.Property(e => e.FechaDesde)
                    .IsRequired();

                entity.Property(e => e.FechaHasta)
                    .IsRequired();
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.FechaHora, e.IdFiesta});

                entity.Property(e => e.IdCliente)
                    .IsRequired();

                entity.Property(e => e.IdFiesta)
                    .IsRequired();

                entity.Property(e => e.FechaHora)
                    .IsRequired();

                entity.Property(e => e.IdVendedor)
                    .IsRequired();

                entity.HasOne<Usuario>()
                    .WithMany() 
                    .HasForeignKey(c => c.IdVendedor)
                    .OnDelete(DeleteBehavior.Restrict); 

                entity.HasOne<Usuario>()
                    .WithMany() 
                    .HasForeignKey(c => c.IdCliente)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Fiesta>()
                    .WithMany() 
                    .HasForeignKey(c => c.IdFiesta)
                    .OnDelete(DeleteBehavior.Restrict);
            });

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

            modelBuilder.Entity<Entrada>(entity =>
            {
                entity.HasKey(e => new { e.IdEntrada });
                
                entity.Property(e => e.IdEntrada)
                    .IsRequired()
                    .ValueGeneratedNever();
                
                entity.Property(e => e.IdFiesta)
                    .IsRequired();
                
                entity.Property(e => e.IdCliente)
                    .IsRequired();

                entity.Property(e => e.FechaHora)
                    .IsRequired();

                entity.HasOne<Compra>()
                    .WithMany()
                    .HasForeignKey(c => new { c.IdCliente, c.FechaHora, c.IdFiesta })
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CompraProducto>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.FechaHora, e.IdFiesta, e.IdProducto });
                
                entity.Property(e => e.IdCliente)
                    .IsRequired();

                entity.Property(e => e.FechaHora)
                    .IsRequired();

                entity.Property(e => e.IdFiesta)
                    .IsRequired();

                entity.Property(e => e.IdProducto)
                    .IsRequired();
                
                entity.Property(e => e.Cantidad)
                    .IsRequired();

                entity.HasOne<Compra>()
                    .WithMany()
                    .HasForeignKey(c => new { c.IdCliente, c.FechaHora, c.IdFiesta })
                    .OnDelete(DeleteBehavior.Restrict);
                
                entity.HasOne<Producto>()
                    .WithMany()
                    .HasForeignKey(c => c.IdProducto)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<FiestaLote>(entity =>
            {
                entity.HasKey(e => new { e.IdFiesta, e.IdLote });

                entity.Property(e => e.IdFiesta)
                    .IsRequired();

                entity.Property(e => e.IdLote)
                    .IsRequired();
                
                entity.HasOne<Fiesta>()
                    .WithMany()
                    .HasForeignKey(c => c.IdFiesta )
                    .OnDelete(DeleteBehavior.Restrict);
                
                entity.HasOne<Lote>()
                    .WithMany()
                    .HasForeignKey(c => c.IdLote)
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
                },

                new  
                {
                    Id = 3,
                    Nombre = "Bohemia",
                    Desc = "Fiesta nocturna de publico adolecente."
                },

                new
                {
                    Id = 4,
                    Nombre = "La Cúpula del Templo",
                    Desc = "Fiesta nocturna de publico adolecente."
                },

                new 
                {
                    Id = 5,
                    Nombre = "Bresh",
                    Desc = "Fiesta nocturna de publico adolecente."
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
                    Descripcion = "Vaso ecofriendly.",
                    Precio = 10 
                },
                new  
                {
                    Id = 2,
                    Descripcion = "Hamburguesa con queso.",
                    Precio = 25
                }
            );

            modelBuilder.Entity<Lugar>().HasData(
                new
                {
                    Id = 1,
                    Nombre = "La sala de las Artes",
                    Direccion = "Av Ovidio Lagos y Guemes",
                    Ciudad = "Rosario"
                },
                new
                {
                    Id = 2,
                    Nombre = "Vorterix",
                    Direccion = "Av. Federico Lacroze 3455",
                    Ciudad = "Ciudad Autónoma de Buenos Aires"
                },
                new
                {
                    Id = 3,
                    Nombre = "Centro Cultural Güemes",
                    Direccion = "Güemes 2808",
                    Ciudad = "Rosario"
                },
                new
                {
                    Id = 4,
                    Nombre = "BIOCERES ARENA",
                    Direccion = "Cafferata 729",
                    Ciudad = "Rosario"
                }
            );
            
            modelBuilder.Entity<Lote>().HasData(
                new
                {
                    Id = 1,
                    Nombre = "Lote Early Bird",
                    Precio = 15,
                    FechaDesde = new DateTime(2025, 9, 1),
                    FechaHasta = new DateTime(2025, 9, 30),
                    CantidadLote = 100,
                    LoteActual = false
                },
                new
                {
                    Id = 2,
                    Nombre = "Lote Regular",
                    Precio = 25,
                    FechaDesde = new DateTime(2025, 10, 1),
                    FechaHasta = new DateTime(2025, 12, 30),
                    CantidadLote = 300,
                    LoteActual = true
                },
                new
                {
                    Id = 3,
                    Nombre = "Lote Last Minute",
                    Precio = 35,
                    FechaDesde = new DateTime(2025, 12, 31),
                    FechaHasta = new DateTime(2025, 12, 31),
                    CantidadLote = 50,
                    LoteActual = false
                },
                new
                {
                    Id = 4,
                    Nombre = "Lote Early Bird Feria",
                    Precio = 5,
                    FechaDesde = new DateTime(2025, 8, 1),
                    FechaHasta = new DateTime(2025, 8, 31),
                    CantidadLote = 200,
                    LoteActual = false
                },
                new
                {
                    Id = 5,
                    Nombre = "Lote Regular Feria",
                    Precio = 12,
                    FechaDesde = new DateTime(2025, 9, 1),
                    FechaHasta = new DateTime(2025, 11, 14),
                    CantidadLote = 400,
                    LoteActual = true
                },
                new
                {
                    Id = 6,
                    Nombre = "Lote Last Minute Feria",
                    Precio = 18,
                    FechaDesde = new DateTime(2025, 11, 15),
                    FechaHasta = new DateTime(2025, 11, 15),
                    CantidadLote = 100,
                    LoteActual = false
                },
                new
                {
                    Id = 7,
                    Nombre = "Lote Early Bird Bohemia",
                    Precio = 20,
                    FechaDesde = new DateTime(2025, 9, 15),
                    FechaHasta = new DateTime(2025, 10, 10),
                    CantidadLote = 150,
                    LoteActual = false
                },
                new
                {
                    Id = 8,
                    Nombre = "Lote Regular Bohemia",
                    Precio = 30,
                    FechaDesde = new DateTime(2025, 10, 11),
                    FechaHasta = new DateTime(2025, 10, 19),
                    CantidadLote = 250,
                    LoteActual = true
                },
                new
                {
                    Id = 9,
                    Nombre = "Lote Last Minute Bohemia",
                    Precio = 40,
                    FechaDesde = new DateTime(2025, 10, 20),
                    FechaHasta = new DateTime(2025, 10, 20),
                    CantidadLote = 80,
                    LoteActual = false
                }
            );

            modelBuilder.Entity<Compra>().HasData(
                new
                {
                    IdCliente = 1,
                    FechaHora = new DateTime(2025, 10, 15, 5, 12, 5),
                    IdFiesta = 1,
                    IdVendedor = 10
                },
                new
                {
                    IdCliente = 1,
                    FechaHora = new DateTime(2025, 10, 15, 5, 13, 5),
                    IdFiesta = 1,
                    IdVendedor = 10,
                },
                new
                {
                    IdCliente = 1,
                    FechaHora = new DateTime(2025, 10, 15, 5, 14, 5),
                    IdFiesta = 1,
                    IdVendedor = 10
                }
            );
            
            modelBuilder.Entity<Fiesta>().HasData(
                new
                {
                    IdFiesta = 1,
                    IdLugar = 2,
                    IdEvento = 3,
                    FechaFiesta = new DateTime(2025, 12, 31, 22, 0, 0)
                },
                new
                {
                    IdFiesta = 2,
                    IdLugar = 1,
                    IdEvento = 4,
                    FechaFiesta = new DateTime(2025, 11, 15, 21, 0, 0)
                },
                new
                {
                    IdFiesta = 3,
                    IdLugar = 4,
                    IdEvento = 5,
                    FechaFiesta = new DateTime(2025, 10, 20, 23, 0, 0)
                }
            );

            modelBuilder.Entity<FiestaLote>().HasData
            (
                new
                {
                    IdFiesta = 1,
                    IdLote = 1
                },
                new
                {
                    IdFiesta = 1,
                    IdLote = 2
                },
                new
                {
                    IdFiesta = 1,
                    IdLote = 3
                },
                new
                {
                    IdFiesta = 2,
                    IdLote = 4
                },
                new
                {
                    IdFiesta = 2,
                    IdLote = 5
                },
                new
                {
                    IdFiesta = 2,
                    IdLote = 6
                },
                new
                {
                    IdFiesta = 3,
                    IdLote = 7
                },
                new
                {
                    IdFiesta = 3,
                    IdLote = 8
                },
                new
                {
                    IdFiesta = 3,
                    IdLote = 9
                }
            );
        }
    }
}
