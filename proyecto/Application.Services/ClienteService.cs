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

            Cliente cliente = new Cliente(dto.Id, dto.Email, dto.Nombre, dto.Apellido, dto.NumeroTelefono, dto.FechaNac, dto.Instagram);

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
                Instagram = cliente.Instagram
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
                Instagram = cliente.Instagram
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

            Cliente cliente = new Cliente(dto.Id, dto.Email, dto.Nombre, dto.Apellido, dto.NumeroTelefono, dto.FechaNac, dto.Instagram);
            return clienteRepository.Update(cliente);
        }
    }
}