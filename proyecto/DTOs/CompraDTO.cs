﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CompraDTO
    {
        public DateTime FechaHora { get; set; }
        public int CantidadCompra { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
    }
}
