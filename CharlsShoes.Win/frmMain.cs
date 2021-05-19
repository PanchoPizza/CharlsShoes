using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
            {
                tabMdiManager.MdiParent = this;
            }
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmCliente))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Clientes...");
            new frmCliente()
            {
                MdiParent = this
            }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
            {
                tabMdiManager.MdiParent = this;
            }
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProducto))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Productos...");
            new frmProducto()
            {
                MdiParent = this
            }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnCategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
            {
                tabMdiManager.MdiParent = this;
            }
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmCategoria))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Categoría...");
            new frmCategoria()
            {
                MdiParent = this
            }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnMarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
            {
                tabMdiManager.MdiParent = this;
            }
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmMarca))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Marca...");
            new frmMarca()
            {
                MdiParent = this
            }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnColores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
            {
                tabMdiManager.MdiParent = this;
            }
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmColores))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Colores...");
            new frmColores()
            {
                MdiParent = this
            }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
            {
                tabMdiManager.MdiParent = this;
            }
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVenta))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas...");
            new frmVenta()
            {
                MdiParent = this
            }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}