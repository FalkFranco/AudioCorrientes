using Login.CDatos;
using Login.CNegocio;
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

        NEmpleado objEmpleado = new NEmpleado();

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
            BorrarMensajeProvider(txtBuscar);
            if (ValidarCampos(txtBuscar, chbNombreE))
            {
                MessageBox.Show("Buscando Usuario");
            }
        }

        private void BorrarMensajeProvider(TextBox textBox)
        {
            errorProvider1.SetError(textBox, "");
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

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            AgregarEmpleados agregarEmpleados = new AgregarEmpleados();
            agregarEmpleados.ShowDialog();
            objEmpleado.CargarGrid(dgvEmpleados);
        }


        private bool ValidarCampos(TextBox textBox, CheckBox checkBox)
        {
            bool ok = true;
            if (textBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox, "No puede estar vacio");
            }
            if (checkBox.Checked && textBox.Text.Length <= 4)
            {
                ok = false;
                errorProvider1.SetError(textBox, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }

        private void chbNombreE_Click(object sender, EventArgs e)
        {
            chbDniE.Checked = false;
            chbNombreE.Checked = true;
        }

        private void chbDniE_Click(object sender, EventArgs e)
        {
            chbNombreE.Checked = false;
            chbDniE.Checked = true;
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bloqString(chbDniE, e);
        }

        private void bloqString(CheckBox checkBox, KeyPressEventArgs e)
        {
            if (checkBox.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.OcultarColumnas(dgvEmpleados);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.OcultarColumnas(dgvEmpleados);
        }
    }
}
