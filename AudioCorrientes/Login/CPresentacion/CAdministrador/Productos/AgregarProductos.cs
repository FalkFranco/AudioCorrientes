using Login.CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.CSuAdministrador.Productos
{
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }
        NProductos objProducto = new NProductos(); 
        string idValueMarca = "";
        string idValueCat = "";

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea agregar un nuevo Producto?", "Agregar Producto", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int idCat = Int32.Parse(idValueCat);//De string a int para poder almacenar en la base de datos
                    int idMarca = Int32.Parse(idValueMarca);//De string a int para poder almacenar en la base de datos
                    float precio = float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat);
                    precio.ToString("0.00");
                    int stock = Int32.Parse(txtStock.Text);
                    bool estado = true;
                    if (objProducto.AgregarProducto(idCat, idMarca, txtNombre.Text, txtDescripcion.Text, precio, stock,estado))
                    {
                        MessageBox.Show("El Producto se registró correctamente", "Producto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("El Producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
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
            if (txtPrecio.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(txtPrecio, msg);
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
            if (cbCategoria.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(cbCategoria, msg);
            }
            if (cbMarca.Text == "")
            {
                ok = false;
                errorProviderAgregarProducto.SetError(cbMarca, msg);
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderAgregarProducto.SetError(txtNombre, "");
            errorProviderAgregarProducto.SetError(txtPrecio, "");
            errorProviderAgregarProducto.SetError(txtStock, "");
            errorProviderAgregarProducto.SetError(txtDescripcion, "");
            errorProviderAgregarProducto.SetError(cbCategoria, "");
            errorProviderAgregarProducto.SetError(cbMarca, "");
        }

        //Bloqueo de teclas segun el tipo de datos a ingresar

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

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            objProducto.CargarComboBoxMarca(cbMarca);
            objProducto.CargarComboBoxCategoria(cbCategoria);
            cbMarca.SelectedValue = 1; //Por defecto al cargar es Consumidor Final
            cbCategoria.SelectedValue = 1; //Por defecto al cargar es Consumidor Final
            idValueMarca = cbMarca.SelectedValue.ToString(); //Alamacena el id para poder cargar en la db
            idValueCat = cbCategoria.SelectedValue.ToString(); //Alamacena el id para poder cargar en la db
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValueCat = cbCategoria.SelectedValue.ToString();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValueMarca = cbMarca.SelectedValue.ToString();
        }
    }
}
