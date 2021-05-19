using CharlsShoes.DAL;
using CharlsShoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlsShoes.BLL
{
    public class ProductoOperations
    {


        #region Singleton
        private static volatile ProductoOperations instance = null;

        private static readonly object padlock = new object();

        private CharlsShoesContext context = new CharlsShoesContext();


        private ProductoOperations() { }

        public static ProductoOperations Instance()
        {
            if (instance == null)

                lock (padlock)
                    if (instance == null)
                        instance = new ProductoOperations();
            return instance;

        }


        #endregion

        public int Add(Producto producto)
        {
            context.Add(producto);
            return context.SaveChanges();
        }


        public int Delete(int idProducto)
        {
            Producto producto = context.Productos.Where(c => c.idProducto == idProducto).FirstOrDefault();
            producto.activo = false;
            return context.SaveChanges();

        }

        public List<Producto> GetAll()
        {
            return context.Productos.Where(c => c.activo == true).ToList();
        }

        public Producto GetById(int idProducto)
        {

            return context.Find<Producto>(idProducto);
        }

        public Producto GetByCodigo(string codigo)
        {
            return context.Productos.Where(p => p.codigo == codigo).SingleOrDefault();
        }
        public int Update(Producto producto)
        {
            context.Update(producto);
            return context.SaveChanges();
        }
    }
}
