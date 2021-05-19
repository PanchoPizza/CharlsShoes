
namespace CharlsShoes.Win
{
    partial class frmMNProducto
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
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lupMarca = new DevExpress.XtraEditors.LookUpEdit();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lupCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lupColor = new DevExpress.XtraEditors.LookUpEdit();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(318, 37);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(461, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(110, 194);
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtStock.Properties.Mask.EditMask = "f0";
            this.txtStock.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtStock.Size = new System.Drawing.Size(150, 26);
            this.txtStock.TabIndex = 4;
            this.txtStock.EditValueChanged += new System.EventHandler(this.txtStock_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 19);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Stock:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(110, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.DisplayFormat.FormatString = "c";
            this.txtPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrecio.Properties.Mask.EditMask = "c";
            this.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio.Size = new System.Drawing.Size(150, 26);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.EditValueChanged += new System.EventHandler(this.txtPrecio_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 19);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Precio:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 162);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 26);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.EditValueChanged += new System.EventHandler(this.txtCodigo_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 19);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Código:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(110, 98);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.DisplayFormat.FormatString = "c";
            this.txtCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCosto.Properties.Mask.EditMask = "c";
            this.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCosto.Size = new System.Drawing.Size(150, 26);
            this.txtCosto.TabIndex = 1;
            this.txtCosto.EditValueChanged += new System.EventHandler(this.txtCosto_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 19);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Costo:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtDescripccion
            // 
            this.txtDescripccion.Location = new System.Drawing.Point(110, 66);
            this.txtDescripccion.Name = "txtDescripccion";
            this.txtDescripccion.Size = new System.Drawing.Size(150, 26);
            this.txtDescripccion.TabIndex = 0;
            this.txtDescripccion.EditValueChanged += new System.EventHandler(this.txtDescripccion_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 19);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Descripcción:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(110, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 26);
            this.txtId.TabIndex = 13;
            this.txtId.EditValueChanged += new System.EventHandler(this.txtId_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "ID:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lupMarca
            // 
            this.lupMarca.Location = new System.Drawing.Point(110, 226);
            this.lupMarca.Name = "lupMarca";
            this.lupMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupMarca.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "id Marca", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupMarca.Properties.DataSource = this.marcaBindingSource;
            this.lupMarca.Properties.DisplayMember = "descripcion";
            this.lupMarca.Properties.NullText = "";
            this.lupMarca.Properties.ValueMember = "idMarca";
            this.lupMarca.Size = new System.Drawing.Size(150, 26);
            this.lupMarca.TabIndex = 5;
            this.lupMarca.EditValueChanged += new System.EventHandler(this.lupMarca_EditValueChanged);
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(CharlsShoes.Entities.Marca);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 229);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 19);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Marca:";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 261);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 19);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Categoría:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // lupCategoria
            // 
            this.lupCategoria.Location = new System.Drawing.Point(110, 258);
            this.lupCategoria.Name = "lupCategoria";
            this.lupCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupCategoria.Properties.DataSource = this.categoriaBindingSource;
            this.lupCategoria.Properties.DisplayMember = "descripcion";
            this.lupCategoria.Properties.NullText = "";
            this.lupCategoria.Properties.ValueMember = "idCategoria";
            this.lupCategoria.Size = new System.Drawing.Size(150, 26);
            this.lupCategoria.TabIndex = 6;
            this.lupCategoria.EditValueChanged += new System.EventHandler(this.lupCategoria_EditValueChanged);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(CharlsShoes.Entities.Categoria);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 293);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 19);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "Color:";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // lupColor
            // 
            this.lupColor.Location = new System.Drawing.Point(110, 290);
            this.lupColor.Name = "lupColor";
            this.lupColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupColor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idColor", "id Color", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupColor.Properties.DataSource = this.colorBindingSource;
            this.lupColor.Properties.DisplayMember = "descripcion";
            this.lupColor.Properties.NullText = "";
            this.lupColor.Properties.ValueMember = "idColor";
            this.lupColor.Size = new System.Drawing.Size(150, 26);
            this.lupColor.TabIndex = 7;
            this.lupColor.EditValueChanged += new System.EventHandler(this.lupColor_EditValueChanged);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(CharlsShoes.Entities.Color);
            // 
            // frmMNProducto
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(608, 349);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lupColor);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lupCategoria);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lupMarca);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDescripccion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMNProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMNProducto";
            this.Load += new System.EventHandler(this.frmMNProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDescripccion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lupMarca;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lupCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lupColor;
        private System.Windows.Forms.BindingSource colorBindingSource;
    }
}