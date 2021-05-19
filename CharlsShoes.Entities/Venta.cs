using System;
using System.Collections.Generic;
using System.Text;

namespace CharlsShoes.Entities
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int folio { get; set; }
        public int idCliente { get; set; }
        public DateTime fecha { get; set; }

        public int cantidad { get; set; }
        public decimal importe { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        public decimal pago { get; set; }
        public string status { get; set; }
        public int idUsuario { get; set; }
        public List<VentaDetalle> ventasDetalle { get; set; }
    }
}
