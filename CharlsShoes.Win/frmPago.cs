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
    public partial class frmPago : DevExpress.XtraEditors.XtraForm
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            Clean();
            txtTotalPago.EditValue = Misc.totalPago;
            txtPago.EditValue = Misc.totalPago;
            txtCambio.EditValue = 0;
            
        }

        private void Clean()
        {
            txtTotalPago.EditValue = null;
            txtPago.EditValue = null;
            txtCambio.EditValue = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtPago.EditValue) >= Misc.totalPago)
            {
                Misc.pago = Convert.ToDecimal(txtPago.EditValue);
                txtCambio.EditValue = (Misc.totalPago - Misc.pago) * -1;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtPago.ErrorText = "El total es menor que el pago";
                txtPago.Focus();
            }

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                if(txtPago.EditValue != null)
                    if(Convert.ToDecimal(txtPago.EditValue)>=Misc.totalPago)
                    {
                        txtCambio.EditValue = (Misc.totalPago - Convert.ToDecimal(txtPago.EditValue)) * -1;
                        btnAceptar.Focus();
                    }
                    else
                    {
                       
                        txtPago.ErrorText = "El pago es menor que el pago";
                        txtPago.Focus();
                    }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}