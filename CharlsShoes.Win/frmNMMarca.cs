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
    public partial class frmNMMarca : DevExpress.XtraEditors.XtraForm
    {

        private Marca marca;
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        public frmNMMarca()
        {
            InitializeComponent();
        }
        public frmNMMarca(int idMarca)
        {
            InitializeComponent();
            marca = marcaOperations.GetById(idMarca);
            txtDescripcion.EditValue = marca.descripcion;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {

                if (marca == null)
                {

                    if (marcaOperations.Add(new Marca
                    {

                        descripcion = txtDescripcion.Text,

                    }) > 0)
                    {
                        XtraMessageBox.Show("Marca Insertada Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    marca.descripcion = txtDescripcion.Text;

                    if (marcaOperations.Update(marca) > 0)
                    {

                        XtraMessageBox.Show("Marca Modificada Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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