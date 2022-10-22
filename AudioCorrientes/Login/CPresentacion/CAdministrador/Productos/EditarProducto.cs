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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.CSuAdministrador.Productos
{
    public partial class EditarProducto : Form
    {
        NProductos objProducto = new NProductos();
        string idValueCat;
        string idValueMarca;

        public EditarProducto(int pId)
        {
            InitializeComponent();
            objProducto.CargarFormEditar(pId, txtIdProducto, cbCategoria, cbMarca, txtNombre, txtDescripcion, txtPrecio, txtStock, chbEstado);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea editar este producto?", "Editar Producto", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtIdProducto.Text);
                    int idcat = Int32.Parse(idValueCat);//De string a int para poder almacenar en la base de datos
                    int idmarca = Int32.Parse(idValueMarca);//De string a int para poder almacenar en la base de datos
                    float precio = float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture.NumberFormat);
                    precio.ToString("0.00");
                    int stock = Int32.Parse(txtStock.Text);
                    bool estado = ValidarEstado(chbEstado);

                                            //int id, int idCat, int idMar, string nombre, string descripcion, float precio, int stock, bool estado
                    if (objProducto.EditarProducto(id,idcat,idmarca,txtNombre.Text,txtDescripcion.Text,precio,stock,estado))
                    {
                        MessageBox.Show("El Producto se Edito correctamente", "Cliente Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //txtDni.Focus();
                    }
                    //limpiarFormulario();
                }
            }
        }

        public bool ValidarEstado(CheckBox chbEstado)
        {
            if (!chbEstado.Checked)
            {
                return false;
            }
            return true; 
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
                errorProviderEditarProducto.SetError(txtNombre, msg);
            }
            if (txtPrecio.Text == "")
            {
                ok = false;
                errorProviderEditarProducto.SetError(txtPrecio, msg);
            }
            if (txtDescripcion.Text == "")
            {
                ok = false;
                errorProviderEditarProducto.SetError(txtDescripcion, msg);
            }
            if (txtStock.Text == "")
            {
                ok = false;
                errorProviderEditarProducto.SetError(txtStock, msg);
            }
            //Min Caracteres
            if (txtNombre.Text.Length <= 4)
            {
                ok = false;
                errorProviderEditarProducto.SetError(txtNombre, msgCar);
            }
            if (txtDescripcion.Text.Length <= 20)
            {
                ok = false;
                errorProviderEditarProducto.SetError(txtDescripcion, msgCar);
            }
            //Validacion ComboBox
            if (cbCategoria.Text == "")
            {
                ok = false;
                errorProviderEditarProducto.SetError(cbCategoria, msg);
            }
            if (cbMarca.Text == "")
            {
                ok = false;
                errorProviderEditarProducto.SetError(cbMarca, msg);
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderEditarProducto.SetError(txtNombre, "");
            errorProviderEditarProducto.SetError(txtPrecio, "");
            errorProviderEditarProducto.SetError(txtStock, "");
            errorProviderEditarProducto.SetError(txtDescripcion, "");
            errorProviderEditarProducto.SetError(cbCategoria, "");
            errorProviderEditarProducto.SetError(cbMarca, "");
        }

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

        //Modificar id al cambiar comboBox
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValueCat = cbCategoria.SelectedValue.ToString(); 
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValueMarca = cbMarca.SelectedValue.ToString();
        }



        //Cargar Id al rellenar formulario

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            idValueCat = cbCategoria.SelectedValue.ToString();
            idValueMarca = cbMarca.SelectedValue.ToString();
        }
    }
}
