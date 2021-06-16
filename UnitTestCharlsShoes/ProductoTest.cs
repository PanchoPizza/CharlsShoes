using CharlsShoes.BLL;
using CharlsShoes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCharlsShoes
{


    [TestClass]
  public  class ProductoTest
    {


        public static int id=12;
        ProductoOperations operations = ProductoOperations.Instance();
        [TestMethod]
        
        public void TestCRUD()
        {

        }

        public void Insertar()
        {


            Producto producto = new Producto
            {
                codigo="00055",
                descripcion="Fanta",
                idCategoria=1,
                idMarca = 2,
                idColor=2,
                precio=30.0m,
                costo=20.0m,
                stock = 10
                
                
                
                
            };
            operations.Add(producto);
            Assert.AreEqual(producto.codigo, operations.GetById(id).codigo);

        }


        [TestMethod]
        public void InsertarProductoFallido()
        {


            Producto producto = new Producto
            {
                
                descripcion = "Fanta",
                idCategoria = 1,
                idMarca = 2,
                idColor = 2,
                precio = 30.0m,
                costo = 20.0m,
                stock = 10,
                
                


            };

            Assert.AreEqual(0, operations.Add(producto));

        }

        [TestMethod]
        public void Actualizar()
        {


            Producto producto = new Producto
            {
                idProducto = id,
                codigo = "00055",
                descripcion = "Fanta Uva",
                idCategoria = 1,
                idMarca = 2,
                idColor = 2,
                precio = 30.0m,
                costo = 20.0m,
                stock = 10,
                activo=true,



            };
            operations.Update(producto);
            Assert.AreEqual(producto.codigo, operations.GetById(id).codigo);

        }

        [TestMethod]
        public void Borrar()
        {

            List<Producto> lista = operations.GetAll();


            if (lista.Exists(c => c.idProducto == id))

                Assert.AreEqual(1, operations.Delete(id));

        }


    }
}
