using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class ClienteService
    {
        public ClienteDTO Add(ClienteDTO dto)
        {
            // Validar que el email no esté duplicado
            if (ClientesInMemory.Clientes.Any(c => c.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            var id = GetNextId();

            Cliente cliente = new Cliente(id, dto.Email, dto.Nombre, dto.Apellido, dto.NumeroTelefono , dto.FechaNac, dto.Instagram);

            ClientesInMemory.Clientes.Add(cliente);

            dto.Id = cliente.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            Cliente? clienteToDelete = ClientesInMemory.Clientes.Find(x => x.Id == id);

            if (clienteToDelete != null)
            {
                ClientesInMemory.Clientes.Remove(clienteToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public ClienteDTO Get(int id)
        {
            Cliente? cliente = ClientesInMemory.Clientes.Find(x => x.Id == id);

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
            return ClientesInMemory.Clientes.Select(cliente => new ClienteDTO
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
            Cliente? clienteToUpdate = ClientesInMemory.Clientes.Find(x => x.Id == dto.Id);

            if (clienteToUpdate != null)
            {
                // Validar que el email no esté duplicado (excluyendo el cliente actual)
                if (ClientesInMemory.Clientes.Any(c => c.Id != dto.Id && c.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe otro cliente con el Email '{dto.Email}'.");
                }

                clienteToUpdate.SetNombre(dto.Nombre);
                clienteToUpdate.SetApellido(dto.Apellido);
                clienteToUpdate.SetEmail(dto.Email);
                clienteToUpdate.SetNumeroTelefono(dto.NumeroTelefono);
                clienteToUpdate.SetInstagram(dto.Instagram);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextId()
        {
            int nextId;

            if (ClientesInMemory.Clientes.Count > 0)
            {
                nextId = ClientesInMemory.Clientes.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}