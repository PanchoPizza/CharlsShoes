using CharlsShoes.DAL;
using CharlsShoes.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlsShoes.BLL
{
    public class VentaOperations
    {


        #region Singleton
        private static volatile VentaOperations instance = null;

        private static readonly object padlock = new object();

        private CharlsShoesContext context = new CharlsShoesContext();


        private VentaOperations() { }

        public static VentaOperations Instance()
        {
            if (instance == null)

                lock (padlock)
                    if (instance == null)
                        instance = new VentaOperations();
            return instance;

        }


        #endregion

        public Venta Add(Venta venta)
        {
            Folio folio = context.Folios.Where(f => f.descripcion == "Remision").SingleOrDefault();
            folio.valor++;
            context.Update(folio);
            venta.folio = folio.valor;
           venta= context.Add(venta).Entity;
            context.SaveChanges();
            return venta;
        }


        public int Delete(int idVenta)
        {
            /*  Venta venta = context.Ventas.Where(c => c.idVenta == idVenta).FirstOrDefault();
              venta.activo = false;
              return context.SaveChanges();
            */
            return 0;
        }

        public List<Venta> GetAll()
        {

            return context.Ventas.Where(v => v.status == "A").Include(v => v.ventasDetalle).ToList();
            //return context.Ventas.Where(c => c.activo == true).ToList();
        }

        public Venta GetById(int idVenta)
        {

            return context.Find<Venta>(idVenta);
        }

        public int Update(Venta venta)
        {
            context.Update(venta);
            return context.SaveChanges();
        }

    }
}
