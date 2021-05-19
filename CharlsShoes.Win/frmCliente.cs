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
    public partial class frmCliente : DevExpress.XtraEditors.XtraForm
    {


        ClienteOperations clienteOperations = ClienteOperations.Instance();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
            {
                Text = "Modificar Cliente " + gvClientes.GetFocusedRowCellValue("idCliente")
            }.ShowDialog();
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente()
            {
                Text = "Nuevo Cliente"
            }.ShowDialog();
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar? \n\n" +
                    "{0}", gvClientes.GetFocusedRowCellValue("nombre")),
                    "Charls Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
            {
                clienteOperations.Delete((int)gvClientes.GetFocusedRowCellValue("idCliente"));
                clienteBindingSource.DataSource = clienteOperations.GetAll();
                gvClientes.BestFitColumns();
            }
        }
    }
}