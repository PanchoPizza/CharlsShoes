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
    public partial class frmNMCategoria : DevExpress.XtraEditors.XtraForm
    {

        Categoria categoria;
        CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        public frmNMCategoria()
        {
            InitializeComponent();
        }
        public frmNMCategoria(int idCategoria)
        {
            InitializeComponent();

            categoria = categoriaOperations.GetById(idCategoria);
            txtDescripcion.EditValue = categoria.descripcion;


        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa descripción ";
                txtDescripcion.Focus();
                ban = true;
            }
            
            return !ban;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNMCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {

                if (categoria == null)
                {

                    if (categoriaOperations.Add(new Categoria
                    {

                        descripcion = txtDescripcion.Text,

                    }) >0)
                    {
                        XtraMessageBox.Show("Categoría Insertada Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    categoria.descripcion = txtDescripcion.Text;
                    
                    if (categoriaOperations.Update(categoria) > 0)
                    {

                        XtraMessageBox.Show("Categoría Modificada Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}