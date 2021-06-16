using System;
using System.Collections.Generic;
using System.Text;

namespace CharlsShoes.Entities
{
    public class Producto
    {
        public int idProducto { get; set; }

        public string codigo { get; set; }

        public string descripcion { get; set; }

        public decimal costo { get; set; }

        public decimal precio { get; set; }

        public int idCategoria { get; set; }

        public int idColor { get; set; }

        public int idMarca { get; set; }

        public int stock { get; set; }

        public bool activo { get; set; }


        
    }
}
