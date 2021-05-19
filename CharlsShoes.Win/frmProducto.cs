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
    public partial class frmProducto : DevExpress.XtraEditors.XtraForm
    {


      private  ProductoOperations productoOperations = ProductoOperations.Instance();
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private ColorOperations colorOperations = ColorOperations.Instance();
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            productoBindingSource.DataSource = productoOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = productoOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvProductos.BestFitColumns();

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMNProducto()
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = productoOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMNProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
            {
                Text = "Modificar Producto " + gvProductos.GetFocusedRowCellValue("idProducto")
            }.ShowDialog();
            productoBindingSource.DataSource = productoOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar? \n\n" +
                    "{0}", gvProductos.GetFocusedRowCellValue("descripcion")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
            {
                productoOperations.Delete((int)gvProductos.GetFocusedRowCellValue("idProducto"));
                productoBindingSource.DataSource = productoOperations.GetAll();
                marcaBindingSource.DataSource = marcaOperations.GetAll();
                colorBindingSource.DataSource = colorOperations.GetAll();
                categoriaBindingSource.DataSource = categoriaOperations.GetAll();
                gvProductos.BestFitColumns();
            }
        }
    }
}