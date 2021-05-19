using CharlsShoes.BLL;
using CharlsShoes.DAL;
using CharlsShoes.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        private int cnt = 0;
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        private ProductoOperations ProductoOperations = ProductoOperations.Instance();
        private VentaOperations ventaOperations = VentaOperations.Instance();
        private ReporteOperations reporteOperations = ReporteOperations.Instance();
        private decimal subtotal, descuento, total;
        private List<VentaDetalle> ventasDetalle = new List<VentaDetalle>();
        private Cliente cliente;
        public frmNVenta()
        {
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere","Inicializando una nueva ventana");
            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)

        {

            clienteBindingSource.DataSource = clienteOperations.GetAll();
            productoBindingSource.DataSource = ProductoOperations.GetAll();
            ventaDetalleBindingSource.DataSource = ventasDetalle;
            Misc.totalPago = 0;
            Misc.pago = 0;
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void gvVentasDetalle_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ventaDetalleBindingSource.DataSource = ventasDetalle;
            gvVentasDetalle.BestFitColumns();
        }

        private void gvVentasDetalle_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            switch((sender as GridView).FocusedColumn.FieldName)
            {
                case "cantidad":
                        e.ExceptionMode = ExceptionMode.DisplayError;
                    e.WindowCaption = "Cantidad";
                    e.ErrorText = "La cantidad debe ser mayor a 0";
                    break;
                case "dv":
                    e.ExceptionMode = ExceptionMode.DisplayError;
                    e.WindowCaption = "Descuento de venta";
                    e.ErrorText = "La cantidad debe ser mayor o igual a 0 y menor que 100";
                    break;
                case "dv2":
                    e.ExceptionMode = ExceptionMode.DisplayError;
                    e.WindowCaption = "Descuento de venta";
                    e.ErrorText = "La cantidad debe ser mayor a 0";
                    break;
            }

        }

        private void gvVentasDetalle_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if(!decimal.TryParse(e.Value.ToString(),out decimal r))
            {
                e.Valid = false;
                return;
            }
            decimal valorcelda = Convert.ToDecimal(e.Value);
            decimal precio = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("precio"));
            decimal dc = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("dc"));
            decimal dv = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("dv"));
            decimal dv2 = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("dv2"));
            decimal importe = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("importe"));
            decimal descuento = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("descuento"));
            decimal total = Convert.ToDecimal(gvVentasDetalle.GetFocusedRowCellValue("total"));

            switch((sender as GridView).FocusedColumn.FieldName)
            {
                case "cantidad":
                    if(valorcelda<1||valorcelda > 1000000)
                    {
                        e.Valid = false;
                        return;

                    }
                    importe = precio * valorcelda;
                    descuento = ((dc + dv) * importe) + dv2;
                    total = importe - descuento;


                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "importe", importe);
                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "descuento", descuento);
                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "total", total);
                    break;
                case "dv":
                    if(valorcelda < 0|| valorcelda > 100)
                    {
                        e.Valid = false;
                        return;
                    }
                    e.Value = valorcelda / 100;
                    valorcelda = Convert.ToDecimal(e.Value);
                    descuento = ((dc + valorcelda) * importe) + dv2;
                    total = importe - descuento;
                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "descuento", descuento);
                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "total", total);
                    break;

                case "dv2":
                    if(valorcelda <0 || valorcelda > 1000000)
                    {
                        e.Valid = false;
                        return;
                    }
                    descuento = ((dc + dv) * importe) + valorcelda;
                    total = importe - descuento;

                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "descuento", descuento);
                    gvVentasDetalle.SetRowCellValue(gvVentasDetalle.FocusedRowHandle, "total", total);

                    break;
            }
            Totales();
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)Keys.Enter)
            {
                if (txtCodigo.EditValue == null)
                    return;
                if (lupCliente.EditValue == null)
                {
                    txtCodigo.EditValue = null;
                    return;
                }
                Producto producto = ProductoOperations.GetByCodigo(txtCodigo.Text);
                if(producto == null)
                {
                    txtCodigo.EditValue = null;
                    txtCodigo.Focus();
                    return;
                }
                foreach(var item in ventasDetalle)
                    if(item.idProducto == producto.idProducto)
                    {
                        item.cantidad += 1;
                        item.importe = item.precio * item.cantidad;
                        item.descuento = ((item.dc + item.dv) * item.importe) + item.dv2;
                        item.total = item.importe - item.descuento;
                        ventaDetalleBindingSource.DataSource = ventasDetalle;
                        gvVentasDetalle.BestFitColumns();
                        Totales();
                        txtCodigo.EditValue = null;
                        txtCodigo.Focus();
                        return;
                    }
                cliente = clienteOperations.GetById((int)lupCliente.EditValue);
                ventasDetalle.Add(new VentaDetalle
                {
                    idProducto = producto.idProducto,
                    cantidad = 1,
                    precio = producto.precio,
                    importe = producto.precio,
                    dc=cliente.descuento,
                    dv = 0,
                    dv2=0,
                    descuento = (cliente.descuento * producto.precio),
                    total = producto.precio - (cliente.descuento * producto.precio)

                });

                ventaDetalleBindingSource.ResetBindings(false);
                ventaDetalleBindingSource.DataSource= ventasDetalle;
                gvVentasDetalle.BestFitColumns();
               
                Totales();
                txtCodigo.EditValue = null;
                txtCodigo.Focus();
                if (ventasDetalle.Count > 0)
                    lupCliente.Enabled = false;
                else
                    lupCliente.Enabled = true;
            
            }
        }

        private void frmNVenta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();

                    break;
                case Keys.F12:
                    if (ventasDetalle.Count == 0)
                        return;
                    gvVentasDetalle.CloseEditor();
                    gvVentasDetalle.UpdateCurrentRow();
                    if(new frmPago().ShowDialog()==DialogResult.OK)
                    {
                        Totales();
                       // int cnt = Convert.ToInt32(gvVentasDetalle.Columns["cantidad"].SummaryItem.SummaryValue);
                        Venta venta = ventaOperations.Add(new Venta
                        {
                            folio = 0,
                            idCliente = (int)lupCliente.EditValue,
                            fecha = DateTime.Now,
                            cantidad = cnt,
                            importe = subtotal,
                            descuento = descuento,
                            total = Misc.totalPago,
                            pago = Misc.pago,
                            status = "A",
                            idUsuario = Misc.usuario.idUsuario,
                            ventasDetalle = ventasDetalle 

                        }) ;
                        if (venta != null)
                        {
                            XtraMessageBox.Show("Venta registrada correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ////Reporte
                            ///

                            try
                            {
                                /*StiReport stiReport = new StiReport();
                                stiReport.LoadFromString(reporteOperations.GetByName("Ticket").xml);
                                 stiReport.Dictionary.Databases.Clear();
                                  stiReport.Dictionary.Databases.Add(new StiSqlDatabase("charlssdb", CharlsShoesContext.ConnectionString));
                                 stiReport.Dictionary.Variables.Add(new StiVariable("idVenta", venta.idVenta));
                                  stiReport.Print(false);*/
                                StiReport stiReport1 = new StiReport();
                                stiReport1.Load(reporteOperations.GetByName("Ticket").xml);
                                stiReport1.Compile();
                                stiReport1["idVenta"] = venta.idVenta;

                                stiReport1.Show();
                                Totales();
                              // this.Close();
                            }
                            catch(Exception ex)
                            {
                                throw new ApplicationException("Error"+ ex.Message);
                            }

                        }
                    }
                    break;
            }
        }

        private void gcVentaDetalle_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
                if (XtraMessageBox.Show("¿Deseas eliminar el renglos?", Application.ProductName,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Handled = true;
        }

        private void gvVentasDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gridView = sender as GridView;
            GridHitInfo hitInfo = gridView.CalcHitInfo(e.Location);
            if (hitInfo.Column == null || hitInfo.Column.FieldName == "Value") return;
            this.BeginInvoke(new MethodInvoker(delegate { gridView.ShowEditorByMouse(); }));

        }

        private void gvVentasDetalle_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Totales();
        }
        private void Totales()
        {
            subtotal = 0;
            descuento = 0;
            total = 0;
            cnt = 0;
            foreach(var item in ventasDetalle)
            {
                subtotal += item.importe;
                descuento += item.descuento;
                total += item.total;
                cnt = cnt + item.cantidad;
            }
            Misc.totalPago = total;
            lblSubTotal.Text = subtotal.ToString("c");
            lblDescuento.Text = descuento.ToString("c");
            lblTotal.Text = total.ToString("c");
            lblPago.Text = Misc.pago.ToString("c");
            lblCambio.Text = Misc.pago != 0 ? ((Misc.totalPago - Misc.pago) * -1).ToString("c") : 0.ToString("c");
        }
    }
}