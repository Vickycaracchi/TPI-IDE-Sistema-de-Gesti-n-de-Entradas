using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Model;
using Data;

namespace Application.Services
{
    public class ClienteService
    {
        public void Add(Cliente cliente)
        {
            cliente.SetId(GetNextId());

            ClientesInMemory.Clientes.Add(cliente);
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

        public Cliente Get(int id)
        {
            //Deberia devolver un objeto cloneado 
            return ClientesInMemory.Clientes.Find(x => x.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            //Devuelvo una lista nueva cada vez que se llama a GetAll
            //pero idealmente deberia implementar un Deep Clone
            return ClientesInMemory.Clientes.ToList();
        }

        public bool Update(Cliente cliente)
        {
            Cliente? clienteToUpdate = ClientesInMemory.Clientes.Find(x => x.Id == cliente.Id);

            if (clienteToUpdate != null)
            {
                clienteToUpdate.SetEmail(cliente.Email);
                clienteToUpdate.SetNombre(cliente.Nombre);
                clienteToUpdate.SetApellido(cliente.Apellido);
                clienteToUpdate.SetNumeroTelefono(cliente.NumeroTelefono);
                clienteToUpdate.SetInstagram(cliente.Instagram);

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
