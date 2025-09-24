using System;


namespace Domain.Model
{
    public class Vendedor
    {
        public int Id { get; private set; }
        public string Dni { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        public string Contrasena { get; private set; }
        public string Tipo { get; private set; }
        public string Cvu { get; private set; }

        public Vendedor() { }

        public Vendedor(int id, string dni, string nombre, string apellido, string email, string contrasena, string cvu, string tipo)
        {
            SetId(id);
            SetDni(dni);
            SetNombre(nombre);
            SetApellido(apellido);
            SetEmail(email);
            SetContrasena(contrasena);
            SetCvu(cvu);
            SetTipo(tipo);
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

    }
}
