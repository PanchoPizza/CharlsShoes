using System;
using System.Collections.Generic;
using System.Text;

namespace CharlsShoes.Entities
{
  public  class Cliente
    {

        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public decimal descuento { get; set; }
        public bool activo { get; set; }

    }
}
