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
    public partial class frmCategoria : DevExpress.XtraEditors.XtraForm
    {

        CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria()
            {
                Text = "Nueva Categoría"
            }.ShowDialog();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();

            gvCategorias.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            new frmNMCategoria((int)gvCategorias.GetFocusedRowCellValue("idCategoria"))
            {
                Text = "Modificar Categoría " + (int)gvCategorias.GetFocusedRowCellValue("idCategoria")
            }.ShowDialog();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();

            gvCategorias.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvCategorias.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar? \n\n" +
                    "{0}", gvCategorias.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    categoriaOperations.Delete((int)gvCategorias.GetFocusedRowCellValue("idCategoria"));
                    categoriaBindingSource.DataSource = categoriaOperations.GetAll();
                    gvCategorias.BestFitColumns();
                }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }
    }
}