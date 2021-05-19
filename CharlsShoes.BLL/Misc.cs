using CharlsShoes.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CharlsShoes.BLL
{
    public class Misc
    {
        public static Usuario usuario;
        public static bool actualiza = false;
        public static decimal totalPago = 0;
        public static decimal pago = 0;
        private static OpenFileDialog openFileDialog;
           


        public static string BuscarReporte()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            openFileDialog.Title = "Seleccionar Reporte";
            openFileDialog.Filter = "Stimulsoft Reports Files (*.mrt)|*.mrt";
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }
    }
}
