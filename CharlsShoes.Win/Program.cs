using CharlsShoes.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlsShoes.Win
{
    static class Program
    {
        private static CharlsShoesContext charlsShoesContext = new CharlsShoesContext();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            charlsShoesContext.Database.Migrate();
        
           if(new frmLogin().ShowDialog()== DialogResult.OK)
              Application.Run(new frmMain());
            
            
        }
    }
}
