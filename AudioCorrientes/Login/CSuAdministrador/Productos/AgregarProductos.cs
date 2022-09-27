using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Login.CSuAdministrador.Productos
{
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea agregar un nuevo producto?", "Agregar Producto", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Producto Agregado");
                    //limpiarFormulario();
                }

            }
        }

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            string msgCar = "Ingrese mas de 4 caracteres";
            bool ok = true;
            //Si estan vacios
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtNombre, msg);
            }
            if (txtPrecioCompra.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtPrecioCompra, msg);
            }
            if (txtPrecioVenta.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtPrecioVenta, msg);
            }
            //if (Int32.Parse(txtPrecioVenta.Text) < Int32.Parse(txtPrecioCompra.Text))
            //{
            //    ok = false;
            //    errorProviderAgregarProducto.SetError(txtPrecioVenta, "El valor del precio de venta no puede ser menor al precio de compra");
            //}
            if (txtDescripcion.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtDescripcion, msg);
            }
            if (txtStock.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtStock, msg);
            }
            //Min Caracteres
            if (txtNombre.Text.Length <= 4)
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtNombre, msgCar);
            }
            if (txtDescripcion.Text.Length <= 20)
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtDescripcion, msgCar);
            }
            //Validacion ComboBox
            if (comboBoxCategoria.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(comboBoxCategoria, msg);
            }
            if (comboBoxMarca.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(comboBoxMarca, msg);
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderAgregarProducto.SetError(txtNombre, "");
            errorProviderAgregarProducto.SetError(txtPrecioCompra, "");
            errorProviderAgregarProducto.SetError(txtPrecioVenta, "");
            errorProviderAgregarProducto.SetError(txtStock, "");
            errorProviderAgregarProducto.SetError(txtDescripcion, "");
            errorProviderAgregarProducto.SetError(comboBoxCategoria, "");
            errorProviderAgregarProducto.SetError(comboBoxMarca, "");
        }

        //Bloqueo de teclas segun elo tipo de datos a ingresar

        //String
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Number
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
