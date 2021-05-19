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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        Cliente cliente;
        ClienteOperations clienteOperations = ClienteOperations.Instance();
        public frmNMCliente()
        {
            InitializeComponent();
        }
        public frmNMCliente(int idCliente)
        {
            InitializeComponent();

            cliente = clienteOperations.GetById(idCliente);
            txtNombre.EditValue = cliente.nombre;
            txtApellidoP.EditValue = cliente.apellidoP;
            txtApellidoM.EditValue = cliente.apellidoM;
            txtDireccion.EditValue = cliente.direccion;
            txtTelefono.EditValue = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();
        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa Nombre ";
                if (ban == false)
                {
                    txtNombre.Focus();
                    ban = true;
                }
                
            }
            if (string.IsNullOrEmpty(txtApellidoP.Text))
            {
                txtApellidoP.ErrorText = "Ingresa Apellido P. ";
                if (ban == false)
                {
                    txtApellidoP.Focus();
                    ban = true;
                }
                
            }
            if (string.IsNullOrEmpty(txtApellidoM.Text))
            {
                txtApellidoM.ErrorText = "Ingresa Apellido M. ";
                if (ban == false)
                {
                    txtApellidoM.Focus();
                    ban = true;
                }
                
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                txtDireccion.ErrorText = "Ingresa Dirección ";
                if (ban == false)
                {
                    txtDireccion.Focus();
                    ban = true;
                }
                
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa Teléfono ";
                if (ban == false)
                {
                    txtTelefono.Focus();
                    ban = true;
                }
                
            }
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresa Descuento ";
                if (ban == false)
                {
                    txtDescuento.Focus();
                    ban = true;
                }
               
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

                if (cliente == null)
                {

                    if (clienteOperations.Add(new Cliente
                    {

                        nombre = txtNombre.Text,
                        apellidoP = txtApellidoP.Text,
                        apellidoM = txtApellidoM.Text,
                        direccion = txtDireccion.Text, 
                        telefono = txtTelefono.Text, 
                    descuento = Convert.ToDecimal(txtDescuento.EditValue)
                    }) > 0)
                    {
                        XtraMessageBox.Show("Cliente Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    cliente.nombre = txtNombre.Text;
                    cliente.apellidoP = txtApellidoP.Text;
                    cliente.apellidoM = txtApellidoM.Text;
                    cliente.direccion = txtDireccion.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.EditValue);

                    if (clienteOperations.Update(cliente) > 0)
                    {

                        XtraMessageBox.Show("Cliente Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

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