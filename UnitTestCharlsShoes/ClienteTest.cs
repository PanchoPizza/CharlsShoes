using CharlsShoes.BLL;
using CharlsShoes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCharlsShoes
{
    

    [TestClass]
  public  class ClienteTest
    {
        public static int id=15;
        ClienteOperations operations = ClienteOperations.Instance();


     

        [TestMethod]
        public void Insertar()
        {
        

            Cliente cliente = new Cliente

            {   nombre = "Juan José",
                apellidoM= "Perez",
                apellidoP = "Hernandez",
                descuento = .10m,
                direccion = "Hacienda de flores",
                telefono = "476123456",
              
            };
            operations.Add(cliente);
            Assert.AreEqual(cliente.nombre,operations.GetById(id).nombre);

        }
        [TestMethod]
        public void InsertarClienteFallido()
        {


            Cliente cliente = new Cliente

            {
                
                apellidoM = "Perez",
                apellidoP = "Hernandez",
                descuento = .10m,
                direccion = "Hacienda de flores",
                telefono = "476123456",

            };
            
            Assert.AreEqual(0, operations.Add(cliente));

        }


        [TestMethod]
        public void Actualizar()
        {


            Cliente cliente = new Cliente

            {
                idCliente = id,
                nombre = "Juan jo",
                apellidoM = "Perez",
                apellidoP = "Hernandez",
                descuento = .10m,
                direccion = "Hacienda de flores",
                telefono = "476123456",

            };
            operations.Update(cliente);
            Assert.AreEqual(cliente.nombre, operations.GetById(id).nombre);

        }

        [TestMethod]
        public void Borrar (){

            List<Cliente> lista = operations.GetAll();


            if (lista.Exists(c => c.idCliente == id))

                Assert.AreEqual(1, operations.Delete(id));
            
        }




    }
}
