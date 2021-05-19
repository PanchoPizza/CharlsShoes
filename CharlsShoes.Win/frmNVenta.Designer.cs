
namespace CharlsShoes.Win
{
    partial class frmNVenta
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
            this.lupCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcVentaDetalle = new DevExpress.XtraGrid.GridControl();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentasDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVentaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lupCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentasDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lupCliente
            // 
            this.lupCliente.Location = new System.Drawing.Point(85, 55);
            this.lupCliente.Name = "lupCliente";
            this.lupCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoP", "apellido P", 82, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoM", "apellido M", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descuento", "descuento", 84, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupCliente.Properties.DataSource = this.clienteBindingSource;
            this.lupCliente.Properties.DisplayMember = "nombre";
            this.lupCliente.Properties.NullText = "";
            this.lupCliente.Properties.ValueMember = "idCliente";
            this.lupCliente.Size = new System.Drawing.Size(404, 26);
            this.lupCliente.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CharlsShoes.Entities.Cliente);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lupCliente);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(23, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1029, 100);
            this.groupControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cliente:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtCodigo);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(23, 113);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1029, 100);
            this.groupControl2.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(404, 54);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Código";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblCambio);
            this.groupControl3.Controls.Add(this.lblPago);
            this.groupControl3.Controls.Add(this.lblTotal);
            this.groupControl3.Controls.Add(this.lblDescuento);
            this.groupControl3.Controls.Add(this.lblSubTotal);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(3, 523);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1049, 172);
            this.groupControl3.TabIndex = 3;
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCambio.Location = new System.Drawing.Point(878, 108);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(162, 54);
            this.lblCambio.TabIndex = 9;
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPago.Location = new System.Drawing.Point(878, 36);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(162, 54);
            this.lblPago.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotal.Location = new System.Drawing.Point(615, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 54);
            this.lblTotal.TabIndex = 7;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblDescuento.Appearance.Options.UseFont = true;
            this.lblDescuento.Appearance.Options.UseForeColor = true;
            this.lblDescuento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDescuento.Location = new System.Drawing.Point(381, 41);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(179, 54);
            this.lblDescuento.TabIndex = 6;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblSubTotal.Appearance.Options.UseFont = true;
            this.lblSubTotal.Appearance.Options.UseForeColor = true;
            this.lblSubTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSubTotal.Location = new System.Drawing.Point(121, 41);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(133, 54);
            this.lblSubTotal.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(756, 122);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(119, 29);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Su Cambio";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(783, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 29);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Su Pago";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(566, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 29);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Total";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(260, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(115, 29);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Descuento";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 29);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Sub Total";
            // 
            // gcVentaDetalle
            // 
            this.gcVentaDetalle.DataSource = this.ventaDetalleBindingSource;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcVentaDetalle.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcVentaDetalle.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcVentaDetalle_EmbeddedNavigator_ButtonClick);
            this.gcVentaDetalle.Location = new System.Drawing.Point(3, 219);
            this.gcVentaDetalle.MainView = this.gvVentasDetalle;
            this.gcVentaDetalle.Name = "gcVentaDetalle";
            this.gcVentaDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupProductos});
            this.gcVentaDetalle.Size = new System.Drawing.Size(1058, 310);
            this.gcVentaDetalle.TabIndex = 4;
            this.gcVentaDetalle.UseEmbeddedNavigator = true;
            this.gcVentaDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentasDetalle});
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataSource = typeof(CharlsShoes.Entities.VentaDetalle);
            // 
            // gvVentasDetalle
            // 
            this.gvVentasDetalle.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.gvVentasDetalle.Appearance.GroupPanel.Options.UseFont = true;
            this.gvVentasDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gvVentasDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentasDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvVentasDetalle.Appearance.Row.Options.UseFont = true;
            this.gvVentasDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVentaDetalle,
            this.colidVenta,
            this.colidProducto,
            this.colcantidad,
            this.colprecio,
            this.colimporte,
            this.coldc,
            this.coldv,
            this.coldv2,
            this.coldescuento,
            this.coltotal,
            this.colventa});
            this.gvVentasDetalle.GridControl = this.gcVentaDetalle;
            this.gvVentasDetalle.Name = "gvVentasDetalle";
            this.gvVentasDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentasDetalle.OptionsView.ShowFooter = true;
            this.gvVentasDetalle.OptionsView.ShowGroupPanel = false;
            this.gvVentasDetalle.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colimporte, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvVentasDetalle.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gvVentasDetalle_RowDeleted);
            this.gvVentasDetalle.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvVentasDetalle_ValidateRow);
            this.gvVentasDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvVentasDetalle_MouseDown);
            this.gvVentasDetalle.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvVentasDetalle_ValidatingEditor);
            this.gvVentasDetalle.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.gvVentasDetalle_InvalidValueException);
            // 
            // colidVentaDetalle
            // 
            this.colidVentaDetalle.FieldName = "idVentaDetalle";
            this.colidVentaDetalle.MinWidth = 30;
            this.colidVentaDetalle.Name = "colidVentaDetalle";
            this.colidVentaDetalle.Width = 112;
            // 
            // colidVenta
            // 
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.MinWidth = 30;
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Width = 112;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "Producto";
            this.colidProducto.ColumnEdit = this.rlupProductos;
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.MinWidth = 30;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.OptionsColumn.AllowEdit = false;
            this.colidProducto.OptionsColumn.AllowFocus = false;
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 1;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Producto", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
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
            this.rlupProductos.PopupSizeable = false;
            this.rlupProductos.ShowFooter = false;
            this.rlupProductos.ValueMember = "idProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CharlsShoes.Entities.Producto);
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cnt";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 30;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "{0:#.##}Pzas.")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 0;
            this.colcantidad.Width = 112;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "c";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.MinWidth = 30;
            this.colprecio.Name = "colprecio";
            this.colprecio.OptionsColumn.AllowEdit = false;
            this.colprecio.OptionsColumn.AllowFocus = false;
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            this.colprecio.Width = 112;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.MinWidth = 30;
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.OptionsColumn.AllowFocus = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 3;
            this.colimporte.Width = 112;
            // 
            // coldc
            // 
            this.coldc.Caption = "DC";
            this.coldc.DisplayFormat.FormatString = "P1";
            this.coldc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldc.FieldName = "dc";
            this.coldc.MinWidth = 30;
            this.coldc.Name = "coldc";
            this.coldc.OptionsColumn.AllowEdit = false;
            this.coldc.OptionsColumn.AllowFocus = false;
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
            // coldescuento
            // 
            this.coldescuento.Caption = "Desc";
            this.coldescuento.DisplayFormat.FormatString = "c";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.MinWidth = 30;
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.OptionsColumn.AllowEdit = false;
            this.coldescuento.OptionsColumn.AllowFocus = false;
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 7;
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
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowFocus = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 8;
            this.coltotal.Width = 112;
            // 
            // colventa
            // 
            this.colventa.FieldName = "venta";
            this.colventa.MinWidth = 30;
            this.colventa.Name = "colventa";
            this.colventa.Width = 112;
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 697);
            this.Controls.Add(this.gcVentaDetalle);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmNVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNVenta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lupCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentasDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lupCliente;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcVentaDetalle;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentasDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVentaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldc;
        private DevExpress.XtraGrid.Columns.GridColumn coldv;
        private DevExpress.XtraGrid.Columns.GridColumn coldv2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colventa;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}