using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class ClienteService
    {
        public ClienteDTO Add(ClienteDTO dto)
        {
            var clienteRepository = new ClienteRepository();

            // Validar que el email no esté duplicado
            if (clienteRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            Cliente cliente = new Cliente(dto.Id, dto.Email, dto.Nombre, dto.Apellido, dto.NumeroTelefono, dto.FechaNac, dto.Instagram, dto.Contrasena);

            clienteRepository.Add(cliente);

            dto.Id = cliente.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var clienteRepository = new ClienteRepository();
            return clienteRepository.Delete(id);
        }

        public ClienteDTO Get(int id)
        {
            var clienteRepository = new ClienteRepository();
            Cliente? cliente = clienteRepository.Get(id);

            if (cliente == null)
                return null;

            return new ClienteDTO
            {
                Id = cliente.Id,
                Email = cliente.Email,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                NumeroTelefono = cliente.NumeroTelefono,
                FechaNac = cliente.FechaNac,
                Instagram = cliente.Instagram,
                Contrasena = cliente.Contrasena
            };
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clienteRepository = new ClienteRepository();
            var clientes = clienteRepository.GetAll();

            return clientes.Select(cliente => new ClienteDTO
            {
                Id = cliente.Id,
                Email = cliente.Email,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                NumeroTelefono = cliente.NumeroTelefono,
                FechaNac = cliente.FechaNac,
                Instagram = cliente.Instagram,
                Contrasena = cliente.Contrasena
            }).ToList();
        }

        public bool Update(ClienteDTO dto)
        {
            var clienteRepository = new ClienteRepository();

            // Validar que el email no esté duplicado (excluyendo el cliente actual)
            if (clienteRepository.EmailExists(dto.Email, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro cliente con el Email '{dto.Email}'.");
            }

            Cliente cliente = new Cliente(dto.Id, dto.Email, dto.Nombre, dto.Apellido, dto.NumeroTelefono, dto.FechaNac, dto.Instagram, dto.Contrasena);
            return clienteRepository.Update(cliente);
        }

        public ClienteDTO? GetForLogin(CliLoginDTO cliLogin)
        {
            var clienteRepository = new ClienteRepository();
            Cliente? cliente = clienteRepository.GetByEmail(cliLogin.Email);
            if (cliente == null)
            {
                return null;
            }
            if (cliLogin.Nombre != cliente.Nombre)
            {
                throw new ArgumentException("El nombre y el email no coinciden.");
            }
            if (cliLogin.Contrasena != cliente.Contrasena)
            {
                throw new ArgumentException("La contraseña es incorrecta.");
            }

            return new ClienteDTO
            {
                Id = cliente.Id,
                Email = cliente.Email,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                NumeroTelefono = cliente.NumeroTelefono,
                FechaNac = cliente.FechaNac,
                Instagram = cliente.Instagram,
                Contrasena = cliente.Contrasena
            };
        }
    }
}