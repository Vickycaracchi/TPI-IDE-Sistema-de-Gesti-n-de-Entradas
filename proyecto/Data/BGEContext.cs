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
                    Dni = "100",
                    Nombre = "Admin",
                    Apellido = "General",
                    Email = "admin@gmail.com",
                    Contrasena = "123",
                    Cvu = "0000111122223333444455",
                    Tipo = "Administrador",
                    NumeroTelefono = "3416000000",
                    FechaNac = new DateTime(1985, 1, 10),
                    Instagram = "@adminbge",
                    IdJefe = (int?)null
                },
                new
                {
                    Id = 2,
                    Dni = "201",
                    Nombre = "Jefe 1",
                    Apellido = "Demo",
                    Email = "jefe1@gmail.com",
                    Contrasena = "123",
                    Cvu = "1111222233334444555566",
                    Tipo = "Jefe",
                    NumeroTelefono = "3416000001",
                    FechaNac = new DateTime(1987, 3, 5),
                    Instagram = "@jefe1",
                    IdJefe = (int?)null
                },
                new
                {
                    Id = 3,
                    Dni = "202",
                    Nombre = "Jefe 2",
                    Apellido = "Demo",
                    Email = "jefe2@gmail.com",
                    Contrasena = "123",
                    Cvu = "2222333344445555666677",
                    Tipo = "Jefe",
                    NumeroTelefono = "3416000002",
                    FechaNac = new DateTime(1988, 6, 12),
                    Instagram = "@jefe2",
                    IdJefe = (int?)null
                },
                new
                {
                    Id = 4,
                    Dni = "203",
                    Nombre = "Jefe 3",
                    Apellido = "Demo",
                    Email = "jefe3@gmail.com",
                    Contrasena = "123",
                    Cvu = "3333444455556666777788",
                    Tipo = "Jefe",
                    NumeroTelefono = "3416000003",
                    FechaNac = new DateTime(1989, 9, 21),
                    Instagram = "@jefe3",
                    IdJefe = (int?)null
                },
                new
                {
                    Id = 5,
                    Dni = "301",
                    Nombre = "Vendedor 1",
                    Apellido = "Demo",
                    Email = "vendedor1@gmail.com",
                    Contrasena = "123",
                    Cvu = "4444555566667777888899",
                    Tipo = "Vendedor",
                    NumeroTelefono = "3416001001",
                    FechaNac = new DateTime(1993, 2, 14),
                    Instagram = "@vendedor1",
                    IdJefe = 2
                },
                new
                {
                    Id = 6,
                    Dni = "302",
                    Nombre = "Vendedor 2",
                    Apellido = "Demo",
                    Email = "vendedor2@gmail.com",
                    Contrasena = "123",
                    Cvu = "5555666677778888999900",
                    Tipo = "Vendedor",
                    NumeroTelefono = "3416001002",
                    FechaNac = new DateTime(1994, 4, 18),
                    Instagram = "@vendedor2",
                    IdJefe = 3
                },
                new
                {
                    Id = 7,
                    Dni = "303",
                    Nombre = "Vendedor 3",
                    Apellido = "Demo",
                    Email = "vendedor3@gmail.com",
                    Contrasena = "123",
                    Cvu = "6666777788889999000011",
                    Tipo = "Vendedor",
                    NumeroTelefono = "3416001003",
                    FechaNac = new DateTime(1995, 7, 22),
                    Instagram = "@vendedor3",
                    IdJefe = 4
                },
                new
                {
                    Id = 8,
                    Dni = "401",
                    Nombre = "Cliente 1",
                    Apellido = "Demo",
                    Email = "cliente1@gmail.com",
                    Contrasena = "123",
                    Cvu = "7777888899990000111122",
                    Tipo = "Cliente",
                    NumeroTelefono = "3416002001",
                    FechaNac = new DateTime(1998, 8, 8),
                    Instagram = "@cliente1",
                    IdJefe = (int?)null
                },
                new
                {
                    Id = 9,
                    Dni = "402",
                    Nombre = "Cliente 2",
                    Apellido = "Demo",
                    Email = "cliente2@gmail.com",
                    Contrasena = "123",
                    Cvu = "8888999900001111222233",
                    Tipo = "Cliente",
                    NumeroTelefono = "3416002002",
                    FechaNac = new DateTime(1999, 1, 19),
                    Instagram = "@cliente2",
                    IdJefe = (int?)null
                },
                new
                {
                    Id = 10,
                    Dni = "403",
                    Nombre = "Cliente 3",
                    Apellido = "Demo",
                    Email = "cliente3@gmail.com",
                    Contrasena = "123",
                    Cvu = "9999000011112222333344",
                    Tipo = "Cliente",
                    NumeroTelefono = "3416002003",
                    FechaNac = new DateTime(2000, 12, 2),
                    Instagram = "@cliente3",
                    IdJefe = (int?)null
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
                    FechaDesde = new DateTime(2025, 9, 15),
                    FechaHasta = new DateTime(2025, 11, 30),
                    CantidadLote = 400,
                    LoteActual = true
                },
                new
                {
                    Id = 6,
                    Nombre = "Lote Last Minute Feria",
                    Precio = 18,
                    FechaDesde = new DateTime(2025, 12, 1),
                    FechaHasta = new DateTime(2025, 12, 5),
                    CantidadLote = 100,
                    LoteActual = false
                },
                new
                {
                    Id = 7,
                    Nombre = "Lote Early Bird Bohemia",
                    Precio = 20,
                    FechaDesde = new DateTime(2025, 10, 1),
                    FechaHasta = new DateTime(2025, 11, 10),
                    CantidadLote = 150,
                    LoteActual = false
                },
                new
                {
                    Id = 8,
                    Nombre = "Lote Regular Bohemia",
                    Precio = 30,
                    FechaDesde = new DateTime(2025, 11, 11),
                    FechaHasta = new DateTime(2025, 12, 20),
                    CantidadLote = 250,
                    LoteActual = true
                },
                new
                {
                    Id = 9,
                    Nombre = "Lote Last Minute Bohemia",
                    Precio = 40,
                    FechaDesde = new DateTime(2025, 12, 21),
                    FechaHasta = new DateTime(2025, 12, 31),
                    CantidadLote = 80,
                    LoteActual = false
                }
            );

            modelBuilder.Entity<Compra>().HasData(
                new
                {
                    IdCliente = 8,
                    FechaHora = new DateTime(2025, 9, 5, 12, 0, 0),
                    IdFiesta = 1,
                    IdVendedor = 5
                },
                new
                {
                    IdCliente = 9,
                    FechaHora = new DateTime(2025, 9, 10, 15, 30, 0),
                    IdFiesta = 2,
                    IdVendedor = 6
                },
                new
                {
                    IdCliente = 10,
                    FechaHora = new DateTime(2025, 11, 15, 18, 45, 0),
                    IdFiesta = 3,
                    IdVendedor = 7
                },
                new
                {
                    IdCliente = 8,
                    FechaHora = new DateTime(2025, 9, 15, 20, 0, 0),
                    IdFiesta = 4,
                    IdVendedor = 6
                }
            );
            
            modelBuilder.Entity<Fiesta>().HasData(
                new
                {
                    IdFiesta = 1,
                    IdLugar = 4,
                    IdEvento = 5,
                    FechaFiesta = new DateTime(2025, 10, 20, 23, 0, 0)
                },
                new
                {
                    IdFiesta = 2,
                    IdLugar = 3,
                    IdEvento = 2,
                    FechaFiesta = new DateTime(2025, 11, 15, 14, 0, 0)
                },
                new
                {
                    IdFiesta = 3,
                    IdLugar = 2,
                    IdEvento = 3,
                    FechaFiesta = new DateTime(2025, 12, 31, 22, 0, 0)
                },
                new
                {
                    IdFiesta = 4,
                    IdLugar = 1,
                    IdEvento = 4,
                    FechaFiesta = new DateTime(2025, 11, 20, 21, 0, 0)
                }
            );

            modelBuilder.Entity<Entrada>().HasData(
                new
                {
                    IdEntrada = 1001,
                    IdCliente = 8,
                    IdFiesta = 1,
                    FechaHora = new DateTime(2025, 9, 5, 12, 0, 0)
                },
                new
                {
                    IdEntrada = 1002,
                    IdCliente = 9,
                    IdFiesta = 2,
                    FechaHora = new DateTime(2025, 9, 10, 15, 30, 0)
                },
                new
                {
                    IdEntrada = 1003,
                    IdCliente = 10,
                    IdFiesta = 3,
                    FechaHora = new DateTime(2025, 11, 15, 18, 45, 0)
                },
                new
                {
                    IdEntrada = 1004,
                    IdCliente = 8,
                    IdFiesta = 4,
                    FechaHora = new DateTime(2025, 9, 15, 20, 0, 0)
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
                },
                new
                {
                    IdFiesta = 4,
                    IdLote = 1
                },
                new
                {
                    IdFiesta = 4,
                    IdLote = 2
                },
                new
                {
                    IdFiesta = 4,
                    IdLote = 3
                }
            );

            modelBuilder.Entity<CompraProducto>().HasData(
                new
                {
                    IdCliente = 8,
                    IdFiesta = 1,
                    IdProducto = 1,
                    FechaHora = new DateTime(2025, 9, 5, 12, 0, 0),
                    Cantidad = 2
                },
                new
                {
                    IdCliente = 9,
                    IdFiesta = 2,
                    IdProducto = 2,
                    FechaHora = new DateTime(2025, 9, 10, 15, 30, 0),
                    Cantidad = 1
                },
                new
                {
                    IdCliente = 10,
                    IdFiesta = 3,
                    IdProducto = 1,
                    FechaHora = new DateTime(2025, 11, 15, 18, 45, 0),
                    Cantidad = 1
                },
                new
                {
                    IdCliente = 8,
                    IdFiesta = 4,
                    IdProducto = 2,
                    FechaHora = new DateTime(2025, 9, 15, 20, 0, 0),
                    Cantidad = 3
                }
            );
        }
    }
}
