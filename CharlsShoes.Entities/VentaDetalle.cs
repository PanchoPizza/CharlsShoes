using System;
using System.Collections.Generic;
using System.Text;

namespace CharlsShoes.Entities
{
    public class VentaDetalle
    {
        public int idVentaDetalle { get; set; }

        public int idVenta { get; set; }

        public int idProducto { get; set; }

        public int cantidad { get; set; }

        public decimal precio { get; set; }

        public decimal importe { get; set; }

        public decimal dc { get; set; }

        public decimal dv { get; set; }

        public decimal dv2 { get; set; }

        public decimal descuento { get; set; }

        public decimal total { get; set; }

        public Venta venta { get; set; }


    }
}
