using CharlsShoes.BLL;
using CharlsShoes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCharlsShoes
{

    [TestClass]
   public class VentaTest
    {
        private List<VentaDetalle> ventasDetalle = new List<VentaDetalle>();

        VentaOperations ventaOperations = VentaOperations.Instance();
        ProductoOperations productoOperations = ProductoOperations.Instance();
        ClienteOperations clienteOperations = ClienteOperations.Instance();
        private Cliente cliente;
        private decimal subtotal, descuento, total;
        private int cnt = 0;

        [TestInitialize]
        public void inicio()
        {
            addProductoTest("003", 1);
            addProductoTest("003", 1);
            addProductoTest("005", 1);

            Assert.AreEqual(2, ventasDetalle.Count);
        }

        [TestMethod]

        public void Test_totales()
        {
          

            Assert.AreEqual(80.0m,subtotal);
            Assert.AreEqual(8.0m, descuento);
            Assert.AreEqual(72.0m, total);

        }


        [TestMethod]
        public void Test_Descuento_DV()
        {


         
            Descuento_Test("dv", 10, 0);
            Assert.AreEqual(80.0m, subtotal);
            Assert.AreEqual(12.0m, descuento);
            Assert.AreEqual(68.0m, total);



        }
        [TestMethod]
        public void Test_Descuento_DV2()
        {

            Descuento_Test("dv", 10, 0);

            Descuento_Test("dv2", 20, 1);
            Assert.AreEqual(80.0m, subtotal);
            Assert.AreEqual(32.0m, descuento);
            Assert.AreEqual(48.0m, total);

        }
        [TestMethod]
        public void Test_Descuento_DV_INVALIDO()
        {
           
            Descuento_Test("dv", 101, 1);
            Assert.AreEqual(80.0m, subtotal);
            Assert.AreEqual(8.0m, descuento);
            Assert.AreEqual(72.0m, total);



        }

        private void addProductoTest(string codigo,int idCliente)
        {
            Producto producto = productoOperations.GetByCodigo(codigo);
          
            foreach (var item in ventasDetalle)
                if (item.idProducto == producto.idProducto)
                {
                    item.cantidad += 1;
                    item.importe = item.precio * item.cantidad;
                    item.descuento = ((item.dc + item.dv) * item.importe) + item.dv2;
                    item.total = item.importe - item.descuento;
                 
                    Totales();
                   
                    return;
                }
            cliente = clienteOperations.GetById(idCliente);
            ventasDetalle.Add(new VentaDetalle
            {
                idProducto = producto.idProducto,
                cantidad = 1,
                precio = producto.precio,
                importe = producto.precio,
                dc = cliente.descuento,
                dv = 0,
                dv2 = 0,
                descuento = (cliente.descuento * producto.precio),
                total = producto.precio - (cliente.descuento * producto.precio)

            });

            Totales();

        }


        private void Descuento_Test(string Tipodescuento,decimal valorcelda,int index)
        {
            switch (Tipodescuento)
            {
               
                case "dv":
                    if (valorcelda < 0 || valorcelda > 100)
                    {
                       
                        return;
                    }
                    decimal dec = valorcelda / 100;
                    valorcelda = Convert.ToDecimal(dec);
                    ventasDetalle[index].descuento = ((ventasDetalle[index].dc + valorcelda) * ventasDetalle[index].importe) + ventasDetalle[index].dv2;
                    ventasDetalle[index].total = ventasDetalle[index].importe - ventasDetalle[index].descuento;
                   
                    break;

                case "dv2":
                    if (valorcelda < 0 || valorcelda > 1000000)
                    {
                       
                        return;
                    }
                    ventasDetalle[index].descuento = ((ventasDetalle[index].dc + ventasDetalle[index].dv) * ventasDetalle[index].importe) + valorcelda;
                    ventasDetalle[index].total = ventasDetalle[index].importe - ventasDetalle[index].descuento;

                   

                    break;
            }
            Totales();
        }


        private void Totales()
        {
            subtotal = 0;
            descuento = 0;
            total = 0;
            cnt = 0;
            foreach (var item in ventasDetalle)
            {
                subtotal += item.importe;
                descuento += item.descuento;
                total += item.total;
                cnt = cnt + item.cantidad;
            }
           
        }



    }
}
