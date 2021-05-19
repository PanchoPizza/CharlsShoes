using CharlsShoes.BLL;
using CharlsShoes.Entities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlsShoes.Win
{
    public partial class frmNMColores : DevExpress.XtraEditors.XtraForm
    {
        private ColorOperations colorOperations = ColorOperations.Instance();
        private Color color;
        public frmNMColores()
        {
            InitializeComponent();
        }
        public frmNMColores(int idColor)
        {
            InitializeComponent();
            color = colorOperations.GetById(idColor);
            txtDescripcion.EditValue = color.descripcion;
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                if (color == null)
                {

                    if (colorOperations.Add(new Color
                    {

                        descripcion = txtDescripcion.Text,

                    }) > 0)
                    {
                        XtraMessageBox.Show("Color Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    color.descripcion = txtDescripcion.Text;

                    if (colorOperations.Update(color) > 0)
                    {

                        XtraMessageBox.Show("Color Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}