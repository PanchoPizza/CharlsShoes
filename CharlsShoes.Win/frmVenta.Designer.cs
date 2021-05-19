
namespace CharlsShoes.Win
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.gvDetallesVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVentaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupCliente = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirT = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimirR = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ventasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetallesVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetallesVenta
            // 
            this.gvDetallesVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVentaDetalle,
            this.colidVenta1,
            this.colidProducto,
            this.colcantidad1,
            this.colprecio,
            this.colimporte1,
            this.coldc,
            this.coldv,
            this.coldv2,
            this.coldescuento1,
            this.coltotal1,
            this.colventa});
            this.gvDetallesVenta.GridControl = this.gcVentas;
            this.gvDetallesVenta.Name = "gvDetallesVenta";
            this.gvDetallesVenta.OptionsBehavior.Editable = false;
            this.gvDetallesVenta.OptionsView.ColumnAutoWidth = false;
            this.gvDetallesVenta.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDetallesVenta.OptionsView.ShowGroupPanel = false;
            // 
            // colidVentaDetalle
            // 
            this.colidVentaDetalle.FieldName = "idVentaDetalle";
            this.colidVentaDetalle.MinWidth = 30;
            this.colidVentaDetalle.Name = "colidVentaDetalle";
            this.colidVentaDetalle.Width = 112;
            // 
            // colidVenta1
            // 
            this.colidVenta1.FieldName = "idVenta";
            this.colidVenta1.MinWidth = 30;
            this.colidVenta1.Name = "colidVenta1";
            this.colidVenta1.Width = 112;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "Producto";
            this.colidProducto.ColumnEdit = this.rlupProductos;
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.MinWidth = 30;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 0;
            this.colidProducto.Width = 112;
            // 
            // rlupProductos
            // 
            this.rlupProductos.AutoHeight = false;
            this.rlupProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupProductos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProducto", "id Producto", 94, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 60, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("costo", "costo", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("precio", "precio", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idColor", "id Color", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "id Marca", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("stock", "stock", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupProductos.DataSource = this.productoBindingSource;
            this.rlupProductos.DisplayMember = "descripcion";
            this.rlupProductos.Name = "rlupProductos";
            this.rlupProductos.NullText = "";
            this.rlupProductos.ValueMember = "idProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CharlsShoes.Entities.Producto);
            // 
            // colcantidad1
            // 
            this.colcantidad1.Caption = "Cantidad";
            this.colcantidad1.FieldName = "cantidad";
            this.colcantidad1.MinWidth = 30;
            this.colcantidad1.Name = "colcantidad1";
            this.colcantidad1.Visible = true;
            this.colcantidad1.VisibleIndex = 1;
            this.colcantidad1.Width = 112;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "c";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.MinWidth = 30;
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            this.colprecio.Width = 112;
            // 
            // colimporte1
            // 
            this.colimporte1.Caption = "Importe";
            this.colimporte1.DisplayFormat.FormatString = "c";
            this.colimporte1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte1.FieldName = "importe";
            this.colimporte1.MinWidth = 30;
            this.colimporte1.Name = "colimporte1";
            this.colimporte1.Visible = true;
            this.colimporte1.VisibleIndex = 3;
            this.colimporte1.Width = 112;
            // 
            // coldc
            // 
            this.coldc.Caption = "DC";
            this.coldc.DisplayFormat.FormatString = "P1";
            this.coldc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldc.FieldName = "dc";
            this.coldc.MinWidth = 30;
            this.coldc.Name = "coldc";
            this.coldc.Visible = true;
            this.coldc.VisibleIndex = 4;
            this.coldc.Width = 112;
            // 
            // coldv
            // 
            this.coldv.Caption = "DV";
            this.coldv.DisplayFormat.FormatString = "P1";
            this.coldv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldv.FieldName = "dv";
            this.coldv.MinWidth = 30;
            this.coldv.Name = "coldv";
            this.coldv.Visible = true;
            this.coldv.VisibleIndex = 5;
            this.coldv.Width = 112;
            // 
            // coldv2
            // 
            this.coldv2.Caption = "DV2";
            this.coldv2.DisplayFormat.FormatString = "c";
            this.coldv2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldv2.FieldName = "dv2";
            this.coldv2.MinWidth = 30;
            this.coldv2.Name = "coldv2";
            this.coldv2.Visible = true;
            this.coldv2.VisibleIndex = 6;
            this.coldv2.Width = 112;
            // 
            // coldescuento1
            // 
            this.coldescuento1.Caption = "Descuento";
            this.coldescuento1.DisplayFormat.FormatString = "c";
            this.coldescuento1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento1.FieldName = "descuento";
            this.coldescuento1.MinWidth = 30;
            this.coldescuento1.Name = "coldescuento1";
            this.coldescuento1.Visible = true;
            this.coldescuento1.VisibleIndex = 7;
            this.coldescuento1.Width = 112;
            // 
            // coltotal1
            // 
            this.coltotal1.Caption = "Total";
            this.coltotal1.DisplayFormat.FormatString = "c";
            this.coltotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal1.FieldName = "total";
            this.coltotal1.MinWidth = 30;
            this.coltotal1.Name = "coltotal1";
            this.coltotal1.Visible = true;
            this.coltotal1.VisibleIndex = 8;
            this.coltotal1.Width = 112;
            // 
            // colventa
            // 
            this.colventa.FieldName = "venta";
            this.colventa.MinWidth = 30;
            this.colventa.Name = "colventa";
            this.colventa.Width = 112;
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventaBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvDetallesVenta;
            gridLevelNode1.RelationName = "ventasDetalle";
            this.gcVentas.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcVentas.Location = new System.Drawing.Point(0, 34);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupCliente,
            this.rlupUsuarios,
            this.rlupProductos});
            this.gcVentas.Size = new System.Drawing.Size(1423, 403);
            this.gcVentas.TabIndex = 5;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas,
            this.gvDetallesVenta});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(CharlsShoes.Entities.Venta);
            // 
            // gvVentas
            // 
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colfolio,
            this.colidCliente,
            this.colfecha,
            this.colcantidad,
            this.colimporte,
            this.coldescuento,
            this.coltotal,
            this.colpago,
            this.colstatus,
            this.colidUsuario});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsView.ColumnAutoWidth = false;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            this.gvVentas.ViewCaption = "Detalle Venta";
            // 
            // colidVenta
            // 
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.MinWidth = 30;
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Width = 112;
            // 
            // colfolio
            // 
            this.colfolio.Caption = "Folio";
            this.colfolio.FieldName = "folio";
            this.colfolio.MinWidth = 30;
            this.colfolio.Name = "colfolio";
            this.colfolio.Visible = true;
            this.colfolio.VisibleIndex = 0;
            this.colfolio.Width = 112;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Cliente";
            this.colidCliente.ColumnEdit = this.rlupCliente;
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.MinWidth = 30;
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 1;
            this.colidCliente.Width = 112;
            // 
            // rlupCliente
            // 
            this.rlupCliente.AutoHeight = false;
            this.rlupCliente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupCliente.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoP", "apellido P", 82, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoM", "apellido M", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descuento", "descuento", 84, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupCliente.DataSource = this.clienteBindingSource;
            this.rlupCliente.DisplayMember = "nombre";
            this.rlupCliente.Name = "rlupCliente";
            this.rlupCliente.NullText = "";
            this.rlupCliente.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CharlsShoes.Entities.Cliente);
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 30;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 112;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 30;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 112;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.MinWidth = 30;
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 4;
            this.colimporte.Width = 112;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.DisplayFormat.FormatString = "c";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.MinWidth = 30;
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 5;
            this.coldescuento.Width = 112;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "c";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 30;
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            this.coltotal.Width = 112;
            // 
            // colpago
            // 
            this.colpago.Caption = "Pago";
            this.colpago.DisplayFormat.FormatString = "c";
            this.colpago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpago.FieldName = "pago";
            this.colpago.MinWidth = 30;
            this.colpago.Name = "colpago";
            this.colpago.Visible = true;
            this.colpago.VisibleIndex = 7;
            this.colpago.Width = 112;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Status";
            this.colstatus.FieldName = "status";
            this.colstatus.MinWidth = 30;
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 8;
            this.colstatus.Width = 112;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Usuario";
            this.colidUsuario.ColumnEdit = this.rlupUsuarios;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.MinWidth = 30;
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 9;
            this.colidUsuario.Width = 112;
            // 
            // rlupUsuarios
            // 
            this.rlupUsuarios.AutoHeight = false;
            this.rlupUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupUsuarios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idUsuario", "id Usuario", 85, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "usuario", 65, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("password", "password", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupUsuarios.DataSource = this.usuarioBindingSource;
            this.rlupUsuarios.DisplayMember = "nombre";
            this.rlupUsuarios.Name = "rlupUsuarios";
            this.rlupUsuarios.NullText = "";
            this.rlupUsuarios.ValueMember = "idUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(CharlsShoes.Entities.Usuario);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 34);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(1423, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 34);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Size = new System.Drawing.Size(1423, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 34);
            this.barDockControl2.Manager = null;
            this.barDockControl2.Size = new System.Drawing.Size(1423, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnImprimirT,
            this.btnImprimirR,
            this.btnCancelar});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImprimirR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nueva Venta";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnImprimirT
            // 
            this.btnImprimirT.Caption = "Imprimir Ticket";
            this.btnImprimirT.Id = 2;
            this.btnImprimirT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirT.ImageOptions.SvgImage")));
            this.btnImprimirT.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnImprimirT.Name = "btnImprimirT";
            // 
            // btnImprimirR
            // 
            this.btnImprimirR.Caption = "Imprimir Remision";
            this.btnImprimirR.Id = 3;
            this.btnImprimirR.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirR.ImageOptions.SvgImage")));
            this.btnImprimirR.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnImprimirR.Name = "btnImprimirR";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar Venta";
            this.btnCancelar.Id = 4;
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnCancelar.Name = "btnCancelar";
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(1423, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1423, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1423, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // ventasDetalleBindingSource
            // 
            this.ventasDetalleBindingSource.DataMember = "ventasDetalle";
            this.ventasDetalleBindingSource.DataSource = this.ventaBindingSource;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 437);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetallesVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetallesVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colfolio;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colpago;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnImprimirT;
        private DevExpress.XtraBars.BarButtonItem btnImprimirR;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.BindingSource ventasDetalleBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidVentaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte1;
        private DevExpress.XtraGrid.Columns.GridColumn coldc;
        private DevExpress.XtraGrid.Columns.GridColumn coldv;
        private DevExpress.XtraGrid.Columns.GridColumn coldv2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento1;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colventa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}