using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class VendedorService
    {
        public VendedorDTO Add(VendedorDTO dto)
        {
            var vendedorRepository = new VendedorRepository();

            // Validar que el email no esté duplicado
            if (vendedorRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un vendedor con el Email '{dto.Email}'.");
            }

            Vendedor vendedor = new Vendedor(dto.Id, dto.Dni, dto.Nombre, dto.Apellido, dto.Email, dto.Contrasena,dto.Cvu, dto.Tipo);

            vendedorRepository.Add(vendedor);

            dto.Id = vendedor.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var vendedorRepository = new VendedorRepository();
            return vendedorRepository.Delete(id);
        }

        public VendedorDTO Get(int id)
        {
            var vendedorRepository = new VendedorRepository();
            Vendedor? vendedor = vendedorRepository.Get(id);

            if (vendedor == null)
                return null;

            return new VendedorDTO
            {
                Id = vendedor.Id,
                Dni = vendedor.Dni,
                Nombre = vendedor.Nombre,
                Apellido = vendedor.Apellido,
                Email = vendedor.Email,
                Contrasena = vendedor.Contrasena,
                Cvu = vendedor.Cvu,
                Tipo = vendedor.Tipo
            };
        }

        public IEnumerable<VendedorDTO> GetAll()
        {
            var vendedorRepository = new VendedorRepository();
            var vendedors = vendedorRepository.GetAll();

            return vendedors.Select(vendedor => new VendedorDTO
            {
                Id = vendedor.Id,
                Dni = vendedor.Dni,
                Nombre = vendedor.Nombre,
                Apellido = vendedor.Apellido,
                Email = vendedor.Email,
                Contrasena = vendedor.Contrasena,
                Cvu = vendedor.Cvu,
                Tipo = vendedor.Tipo
            }).ToList();
        }

        public bool Update(VendedorDTO dto)
        {
            var vendedorRepository = new VendedorRepository();

            // Validar que el email no esté duplicado (excluyendo el vendedor actual)
            if (vendedorRepository.EmailExists(dto.Email, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro vendedor con el Email '{dto.Email}'.");
            }

            Vendedor vendedor = new Vendedor(dto.Id, dto.Dni, dto.Nombre, dto.Apellido, dto.Email, dto.Contrasena, dto.Cvu, dto.Tipo);
            return vendedorRepository.Update(vendedor);
        }

        public VendedorDTO? GetForLogin(CliLoginDTO cliLogin)
        {
            var vendedorRepository = new VendedorRepository();
            Vendedor? vendedor = vendedorRepository.GetByEmail(cliLogin.Email);
            if (vendedor == null)
            {
                return null;
            }
            if (cliLogin.Nombre != vendedor.Nombre)
            {
                throw new ArgumentException("El nombre y el email no coinciden.");
            }
            if (cliLogin.Contrasena != vendedor.Contrasena)
            {
                throw new ArgumentException("La contraseña es incorrecta.");
            }

            return new VendedorDTO
            {
                Id = vendedor.Id,
                Dni = vendedor.Dni,
                Email = vendedor.Email,
                Nombre = vendedor.Nombre,
                Apellido = vendedor.Apellido,
                Contrasena = vendedor.Contrasena,
                Cvu = vendedor.Cvu,
                Tipo = vendedor.Tipo
            };
        }
    }
}