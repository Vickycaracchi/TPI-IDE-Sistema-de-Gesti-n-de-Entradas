using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOs
{
    public class ClienteDTO
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string NumeroTelefono { get; private set; }
        public DateTime FechaNac { get; private set; }
        public string Instagram { get; private set; }
    }
}
