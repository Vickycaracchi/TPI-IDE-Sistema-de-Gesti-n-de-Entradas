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
            if (usuarioRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un usuario con el Email '{dto.Email}'.");
            }

            Usuario usuario = new Usuario(dto.Id, dto.Dni, dto.Nombre, dto.Apellido, dto.Email, dto.Contrasena, dto.Cvu, dto.Tipo, dto.NumeroTelefono, dto.FechaNac, dto.Instagram);

            usuarioRepository.Add(usuario);

            dto.Id = usuario.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var usuarioRepository = new UsuarioRepository();
            return usuarioRepository.Delete(id);
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
                Tipo = usuario.Tipo
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
                Instagram = usuario.Instagram
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
                Instagram = usuario.Instagram
            }).ToList();
        }

        public bool Update(UsuarioDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();

            // Validar que el email no esté duplicado (excluyendo el usuario actual)
            if (usuarioRepository.EmailExists(dto.Email, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro usuario con el Email '{dto.Email}'.");
            }

            Usuario usuario = new Usuario(dto.Id, dto.Dni, dto.Nombre, dto.Apellido, dto.Email, dto.Contrasena, dto.Cvu, dto.Tipo, dto.NumeroTelefono, dto.FechaNac, dto.Instagram);
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
                Instagram = usuario.Instagram
            };
        }
    }
}