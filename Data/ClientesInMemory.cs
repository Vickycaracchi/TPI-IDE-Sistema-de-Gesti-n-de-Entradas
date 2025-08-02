using System;
using System.Collections.Generic;
using Domain.Model;
namespace Data
{
    internal class ClientesInMemory
    {       
        public static List<Cliente> Clientes;

        static ClientesInMemory()
        {
            Clientes = new List<Cliente>
            {
                new Cliente(1, ereschini06@gmail.com, "Enrico", "Reschini", "3415618806" , DateTime.Now, "enri.reschini"),
                new Cliente(2, vickypau1d@gmail.com, "Victoria", "Caracchi", "----------" , DateTime.Now, "---"),
                new Cliente(3, lautiponce03@gmail.com, "Lautaro", "Ponce", "----------" , DateTime.Now, "---"),
            };
        }
    }
}