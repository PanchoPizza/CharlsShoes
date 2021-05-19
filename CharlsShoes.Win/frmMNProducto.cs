using CharlsShoes.BLL;
using CharlsShoes.Entities;
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
    public partial class frmMNProducto : DevExpress.XtraEditors.XtraForm
    {
        
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private ColorOperations colorOperations = ColorOperations.Instance();
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        private Producto producto;
        private ProductoOperations productoOperations = ProductoOperations.Instance();
        public frmMNProducto()
        {
            InitializeComponent();
        }
        public frmMNProducto(int idProducto)
        {
            InitializeComponent();
            producto = productoOperations.GetById(idProducto);
            txtId.EditValue = producto.idProducto;
            txtDescripccion.EditValue = producto.descripcion;
            txtPrecio.EditValue = producto.precio.ToString(); ;
            txtCosto.EditValue = producto.costo.ToString(); ;
            txtCodigo.EditValue = producto.codigo;
            txtStock.EditValue = producto.stock.ToString(); ;
            lupCategoria.EditValue = producto.idCategoria;
            lupColor.EditValue = producto.idColor;
            lupMarca.EditValue = producto.idMarca;
        }

        private void frmMNProducto_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {

                if (producto == null)
                {

                    if (productoOperations.Add(new Producto
                    {
                        descripcion = txtDescripccion.Text,
                        precio = Convert.ToDecimal(txtPrecio.EditValue),
                        costo = Convert.ToDecimal(txtCosto.EditValue),
                        codigo = txtCodigo.Text,
                        stock = Convert.ToInt32(txtStock.EditValue),
                        idCategoria = Convert.ToInt32(lupCategoria.EditValue),
                        idMarca = Convert.ToInt32(lupMarca.EditValue),
                        idColor = Convert.ToInt32(lupColor.EditValue)

                        

                    }) > 0)
                    {
                        XtraMessageBox.Show("Producto Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error inesperado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                else
                {
                    producto.descripcion = txtDescripccion.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.EditValue);
                    producto.costo = Convert.ToDecimal(txtCosto.EditValue);
                    producto.codigo = txtCodigo.Text;
                    producto.stock = Convert.ToInt32(txtStock.EditValue);
                    producto.idCategoria = Convert.ToInt32(lupCategoria.EditValue);
                    producto.idMarca = Convert.ToInt32(lupMarca.EditValue);
                    producto.idColor = Convert.ToInt32(lupColor.EditValue);

                    if (productoOperations.Update(producto) > 0)
                    {

                        XtraMessageBox.Show("Producto Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error inesperado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }

            }
        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripccion.Text))
            {
                txtDescripccion.ErrorText = "Ingresa descripción ";
                txtDescripccion.Focus();
                ban = true;
            }

            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                txtCosto.ErrorText = "Ingresa el Costo ";
                if (ban == false)
                {
                    txtCosto.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingresa código ";
                if (ban == false)
                {
                    txtCodigo.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingresa Precio ";
                if (ban == false)
                {
                    txtPrecio.Focus();
                    ban = true;
                }
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingresa Stock ";
                if (ban == false)
                {
                    txtStock.Focus();
                    ban = true;
                }
            }
            if (lupMarca.EditValue == null)
            {
                lupMarca.ErrorText = "Ingresa Marca ";
                if (ban == false)
                {
                    lupMarca.Focus();
                    ban = true;
                }
            }
            if (lupCategoria.EditValue == null)
            {
                lupCategoria.ErrorText = "Ingresa Categoría ";
                if (ban == false)
                {
                    lupCategoria.Focus();
                    ban = true;
                }
            }
            if (lupColor.EditValue == null)
            {
                lupColor.ErrorText = "Ingresa Color ";
                if (ban == false)
                {
                    lupColor.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

        private void txtCosto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lupColor_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void lupCategoria_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void lupMarca_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripccion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}