namespace Domain.Model
{
    public class Cliente
    {
        public int Id { get; private set;}
        public string Email { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string NumeroTelefono { get; private set; }
        public DateTime FechaNac { get; private set; }
        public string Instagram { get; private set; }

        public Cliente() { }

        public Cliente(int id, string email, string nombre, string apellido, string numeroTelefono, DateTime fechaNac, string instagram)
        {
            SetId(id);
            SetEmail(email);
            SetNombre(nombre);
            SetApellido(apellido);
            SetNumeroTelefono(numeroTelefono);
            SetFechaNac(fechaNac);
            SetInstagram(instagram);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Debe ser un email válido.", nameof(email));
            Email = email;
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

        public void SetNumeroTelefono(string numeroTelefono)
        {
            if (string.IsNullOrWhiteSpace(numeroTelefono))
                throw new ArgumentException("El anúmero de teléfono no puede ser nulo o vacío.", nameof(numeroTelefono));
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

    }
}