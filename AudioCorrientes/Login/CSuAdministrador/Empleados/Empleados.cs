using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador.Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleados agregarEmpleados = new AgregarEmpleados();
            agregarEmpleados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpleados editarEmpleados = new EditarEmpleados();
            editarEmpleados.Show();
        }

        private void btnAgregarROL_Click(object sender, EventArgs e)
        {
            AgregarRol agregarRol = new AgregarRol();
            agregarRol.Show();
        }

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
            if (txtBuscar.Text == "")
            {
                ok = false;
                errorProviderBuscarEmpleado.SetError(txtBuscar, "No puede estar vacio al realizar una busqueda");
            }
            if (txtBuscar.Text.Length <= 4)
            {
                ok = false;
                errorProviderBuscarEmpleado.SetError(txtBuscar, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderBuscarEmpleado.SetError(txtBuscar, "");
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Desea Eliminar el Empleado ....?", "Eliminar Empleado", buttons, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Empleado Eliminado");
                //limpiarFormulario();
            }
        }
    }
}
