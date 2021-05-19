using CharlsShoes.BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlsShoes.Win
{
    public partial class frmColores : DevExpress.XtraEditors.XtraForm
    {
        ColorOperations colorOperations = ColorOperations.Instance();


        public frmColores()
        {
            InitializeComponent();
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            new frmNMColores()
            {
                Text = "Nuevo Color"
            }.ShowDialog();
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMColores((int)gvColores.GetFocusedRowCellValue("idColor"))
            {
                Text = "Modificar Color "+ (int)gvColores.GetFocusedRowCellValue("idColor")
            }.ShowDialog();
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar? \n\n" +
                    "{0}", gvColores.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
            {
                colorOperations.Delete((int)gvColores.GetFocusedRowCellValue("idColor"));
                colorBindingSource.DataSource = colorOperations.GetAll();
                gvColores.BestFitColumns();
            }
        }
    }
}