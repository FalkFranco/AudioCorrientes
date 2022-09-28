using Login.CSuAdministrador.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador
{
    public partial class Pruductos : Form
    {
        public Pruductos()
        {
            InitializeComponent();
        }
        //Eventos para abrir formularios
        private void button2_Click(object sender, EventArgs e)
        {
            AgregarProductos formAgregarProd = new AgregarProductos();
            formAgregarProd.Show();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            AgregarCategoria formAddCat = new AgregarCategoria();
            formAddCat.Show();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca formAddMarca = new AgregarMarca();
            formAddMarca.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto formEditarProducto = new EditarProducto();
            formEditarProducto.Show();
        }

        //Validaciones de Formularios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBox.Show("Realizando busqueda...");
            }
           
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if(txtBuscar.Text == "")
            {
                ok = false;
                errorProviderBuscar.SetError(txtBuscar, "No puede estar vacio al realizar una busqueda");
            }
            if (txtBuscar.Text.Length <= 4)
            {
                ok = false;
                errorProviderBuscar.SetError(txtBuscar, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderBuscar.SetError(txtBuscar, "");
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Desea Eliminar el producto ....?", "Eliminar Producto", buttons, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Producto Eliminado");
                //limpiarFormulario();
            }
        }
    }
}
