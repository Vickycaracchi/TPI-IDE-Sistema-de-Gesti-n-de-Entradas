using System;


namespace Domain.Model
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Dni { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        public string Contrasena { get; private set; }
        public string Cvu { get; private set; }
        public string Tipo { get; private set; }
        public string NumeroTelefono { get; private set; }
        public DateTime FechaNac { get; private set; }
        public string Instagram { get; private set; }
        public int? IdJefe { get; private set; }

        public Usuario() { }

        public Usuario(int id, string dni, string nombre, string apellido, string email, string contrasena, string cvu, string tipo, string numeroTelefono, DateTime fechaNac, string instagram, int? idJefe = null)
        {
            SetId(id);
            SetDni(dni);
            SetNombre(nombre);
            SetApellido(apellido);
            SetEmail(email);
            SetContrasena(contrasena);
            SetCvu(cvu);
            SetTipo(tipo);
            SetNumeroTelefono(numeroTelefono);
            SetFechaNac(fechaNac);
            SetInstagram(instagram);
            SetIdJefe(idJefe);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }
        public void SetDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El dni no puede ser nulo o vacío.", nameof(dni));
            Dni = dni;
        }


        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido no puede ser nulo o vacío.", nameof(apellido));
            Apellido = apellido;
        }
        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Debe ser un email válido.", nameof(email));
            Email = email;
        }
        public void SetContrasena(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena))
                throw new ArgumentException("La contrasena no puede ser nula o vacía.", nameof(contrasena));
            Contrasena = contrasena;
        }


        public void SetCvu(string cvu)
        {
            if (string.IsNullOrWhiteSpace(cvu))
                throw new ArgumentException("El cvu no puede ser nulo o vacío.", nameof(cvu));
            Cvu = cvu;
        }

        public void SetTipo(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo no puede ser nulo o vacío.", nameof(tipo));
            Tipo = tipo;
        }

        public void SetNumeroTelefono(string numeroTelefono)
        {
            if (string.IsNullOrWhiteSpace(numeroTelefono))
                throw new ArgumentException("El número de teléfono no puede ser nulo o vacío.", nameof(numeroTelefono));
            NumeroTelefono = numeroTelefono;
        }

        public void SetFechaNac(DateTime fechaNac)
        {
            if (fechaNac == DateTime.MinValue)
                throw new ArgumentException("La fecha de nacimiento no puede ser vacía o inválida.", nameof(fechaNac));

            if (fechaNac > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.", nameof(fechaNac));
            FechaNac = fechaNac;
        }

        public void SetInstagram(string instagram)
        {
            if (string.IsNullOrWhiteSpace(instagram))
                throw new ArgumentException("El instagram no puede ser nulo o vacío.", nameof(instagram));
            Instagram = instagram;

        }

        public void SetIdJefe(int? idJefe)
        {
            if (idJefe.HasValue && idJefe.Value < 0)
                throw new ArgumentException("El IdJefe debe ser mayor que 0.", nameof(idJefe));
            IdJefe = idJefe;
        }
    }
}
