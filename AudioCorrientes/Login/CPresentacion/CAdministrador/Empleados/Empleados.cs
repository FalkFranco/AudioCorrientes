using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CNegocio;
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
            objEmpleado.cargarDtosEmpleados(dgvEmpleados);
            //objEmpleado.OcultarColumnas(dgvEmpleados);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.OcultarColumnas(dgvEmpleados);
        }

        int Id;
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value.ToString());
                EditarEmpleados FormEdit = new EditarEmpleados(Id);
                FormEdit.ShowDialog();
                objEmpleado.cargarDtosEmpleados(dgvEmpleados);
            }
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id_empleado"].Value.ToString());
                result = MessageBox.Show("Desea eliminar el Cliente?\n Se eliminara de forma permanente", "Eliminar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Eliminar (Cambiar Estado)
                    //objProducto.EliminarCliente(Id);
                    //MessageBox.Show("Cliente eliminado con Exito", "Eliminar Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //objProducto.CargarGrid(dgvProductos);
                }
            }
        }
    }
}
