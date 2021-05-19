using CharlsShoes.DAL;
using CharlsShoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlsShoes.BLL
{
    public class ReporteOperations
    {


        #region Singleton
        private static volatile ReporteOperations instance = null;

        private static readonly object padlock = new object();

        private CharlsShoesContext context = new CharlsShoesContext();


        private ReporteOperations() { }

        public static ReporteOperations Instance()
        {
            if (instance == null)

                lock (padlock)
                    if (instance == null)
                        instance = new ReporteOperations();
            return instance;

        }


        #endregion


        public Reporte GetByName(string name)
        {

            
            return context.Reportes.Where(r => r.nombre == name).SingleOrDefault();
        }
    }
}
