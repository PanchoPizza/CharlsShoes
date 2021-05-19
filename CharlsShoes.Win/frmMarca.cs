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
    public partial class frmMarca : DevExpress.XtraEditors.XtraForm
    {

        MarcaOperations marcaOperations = MarcaOperations.Instance();
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMMarca()
            {
                Text = "Nueva Marca"
            }.ShowDialog();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMMarca((int)gvMarcas.GetFocusedRowCellValue("idMarca"))
            {
                Text = "Modificar Marca "+ (int)gvMarcas.GetFocusedRowCellValue("idMarca")
            }.ShowDialog();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar? \n\n" +
                    "{0}", gvMarcas.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
            {
                marcaOperations.Delete((int)gvMarcas.GetFocusedRowCellValue("idMarca"));
                marcaBindingSource.DataSource = marcaOperations.GetAll();
                gvMarcas.BestFitColumns();
            }
        }
    }
}