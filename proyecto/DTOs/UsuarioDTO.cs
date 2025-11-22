using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Cvu { get; set; }
        public string Tipo { get; set; }
        public string NumeroTelefono { get; set; }
        public DateTime FechaNac { get; set; }
        public string Instagram { get; set; }
        public int? IdJefe { get; set; }
    }
}
