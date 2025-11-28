using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class UsuarioService
    {
        public UsuarioDTO Add(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            // Validar que el email no esté duplicado
            if (usuarioRepository.EmailOrDniExists(dto.Email, dto.Dni))
            {
                throw new ArgumentException($"Ya existe un usuario con el Email '{dto.Email}' o el Dni '{dto.Dni}'.");
            }

            Usuario usuario = new Usuario(dto.Id, dto.Dni, dto.Nombre, dto.Apellido, dto.Email, dto.Contrasena, dto.Cvu, dto.Tipo, dto.NumeroTelefono, dto.FechaNac, dto.Instagram, dto.IdJefe);

            usuarioRepository.Add(usuario);

            dto.Id = usuario.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            try
            {
                return usuarioRepository.Delete(id);
            }
            catch (InvalidOperationException)
            {
                throw; 
            }
        }

        public UsuarioDTO Get(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario? usuario = usuarioRepository.Get(id);

            if (usuario == null)
                return null;

            return new UsuarioDTO
            {
                Id = usuario.Id,
                Dni = usuario.Dni,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Contrasena = usuario.Contrasena,
                Cvu = usuario.Cvu,
                Tipo = usuario.Tipo,
                NumeroTelefono = usuario.NumeroTelefono,
                FechaNac = usuario.FechaNac,
                Instagram = usuario.Instagram,
                IdJefe = usuario.IdJefe
            };
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            var usuarioRepository = new UsuarioRepository();
            var usuarios = usuarioRepository.GetAll();

            return usuarios.Select(usuario => new UsuarioDTO
            {
                Id = usuario.Id,
                Dni = usuario.Dni,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Contrasena = usuario.Contrasena,
                Cvu = usuario.Cvu,
                Tipo = usuario.Tipo,
                NumeroTelefono = usuario.NumeroTelefono,
                FechaNac = usuario.FechaNac,
                Instagram = usuario.Instagram,
                IdJefe = usuario.IdJefe
            }).ToList();
        }

        public IEnumerable<UsuarioDTO> GetByTipo(string tipoBuscado)
        {
            var usuarioRepository = new UsuarioRepository();
            var usuarios = usuarioRepository.GetByTipo(tipoBuscado);

            return usuarios.Select(usuario => new UsuarioDTO
            {
                Id = usuario.Id,
                Dni = usuario.Dni,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Contrasena = usuario.Contrasena,
                Cvu = usuario.Cvu,
                Tipo = usuario.Tipo,
                NumeroTelefono = usuario.NumeroTelefono,
                FechaNac = usuario.FechaNac,
                Instagram = usuario.Instagram,
                IdJefe = usuario.IdJefe
            }).ToList();
        }

        public bool Update(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            // Validar que el email no esté duplicado (excluyendo el usuario actual)
            if (usuarioRepository.EmailOrDniExists(dto.Email, dto.Dni, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro usuario con el Email '{dto.Email}'.");
            }

            Usuario usuario = new Usuario(dto.Id, dto.Dni, dto.Nombre, dto.Apellido, dto.Email, dto.Contrasena, dto.Cvu, dto.Tipo, dto.NumeroTelefono, dto.FechaNac, dto.Instagram, dto.IdJefe);
            return usuarioRepository.Update(usuario);
        }

        public UsuarioDTO? GetForLogin(LoginDTO userLogin)
        {
            var usuarioRepository = new UsuarioRepository();
            Usuario? usuario = usuarioRepository.GetByDni(userLogin.Dni);
            if (usuario == null)
            {
                return null;
            }
            if (userLogin.Contrasena != usuario.Contrasena)
            {
                throw new ArgumentException("La contraseña es incorrecta.");
            }

            return new UsuarioDTO
            {
                Id = usuario.Id,
                Dni = usuario.Dni,
                Email = usuario.Email,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Contrasena = usuario.Contrasena,
                Cvu = usuario.Cvu,
                Tipo = usuario.Tipo,
                NumeroTelefono = usuario.NumeroTelefono,
                FechaNac = usuario.FechaNac,
                Instagram = usuario.Instagram,
                IdJefe = usuario.IdJefe
            };
        }

        public bool AsignarVendedorAJefe(int idVendedor, int idJefe)
        {
            var usuarioRepository = new UsuarioRepository();
            
            var vendedor = usuarioRepository.Get(idVendedor);
            if (vendedor == null)
            {
                throw new ArgumentException($"No se encontró un vendedor con Id {idVendedor}.");
            }

            if (vendedor.Tipo.ToLower() != "vendedor")
            {
                throw new ArgumentException($"El usuario con Id {idVendedor} no es un vendedor.");
            }

            var jefe = usuarioRepository.Get(idJefe);
            if (jefe == null)
            {
                throw new ArgumentException($"No se encontró un jefe con Id {idJefe}.");
            }

            if (jefe.Tipo.ToLower() != "jefe")
            {
                throw new ArgumentException($"El usuario con Id {idJefe} no es un jefe.");
            }

            vendedor.SetIdJefe(idJefe);
            
            var dto = new UsuarioDTO
            {
                Id = vendedor.Id,
                Dni = vendedor.Dni,
                Nombre = vendedor.Nombre,
                Apellido = vendedor.Apellido,
                Email = vendedor.Email,
                Contrasena = vendedor.Contrasena,
                Cvu = vendedor.Cvu,
                Tipo = vendedor.Tipo,
                NumeroTelefono = vendedor.NumeroTelefono,
                FechaNac = vendedor.FechaNac,
                Instagram = vendedor.Instagram,
                IdJefe = vendedor.IdJefe
            };

            return usuarioRepository.Update(vendedor);
        }
    }
}