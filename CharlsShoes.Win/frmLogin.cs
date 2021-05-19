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
using CharlsShoes.BLL;
using CharlsShoes.Entities;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Popup;

namespace CharlsShoes.Win
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool Validar()
        {
            var ban = false;
            if(lupUsuario.EditValue==null || lupUsuario.Text.Equals(""))
            {
                lupUsuario.ErrorText = "Selecciona un Usuario";
                lupUsuario.Focus();
                ban = true;
            }
            if (txtPassword.EditValue == null || txtPassword.Text.Equals(""))
            {
                txtPassword.ErrorText = "Ingrese una contraseña";
                if(ban == false)
                {
                    txtPassword.Focus();
                    ban = true;
                }
            }
            if (ban == true)
                return false;
            else
                return true;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
          

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                Misc.usuario = usuarioOperations.Login(new Usuario
                {
                    usuario = lupUsuario.Text,
                    password = txtPassword.Text
                });
                if (Misc.usuario != null)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    XtraMessageBox.Show("Credenciales incorrectas", Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lupUsuario_Popup(object sender, EventArgs e)
        {
            (((sender as LookUpEdit) as IPopupControl).PopupWindow as PopupLookUpEditForm).Width = (sender as LookUpEdit
                ).Width;
        }

        private void lupUsuario_EditValueChanged(object sender, EventArgs e)
        {
            txtPassword.EditValue = null;
        }
    }
}