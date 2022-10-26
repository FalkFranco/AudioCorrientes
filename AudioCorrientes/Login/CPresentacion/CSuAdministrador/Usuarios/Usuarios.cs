using Login.CNegocio;
using Login.CPresentacion.CSuAdministrador.Usuarios;
using Login.CSuAdministrador.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador.Usuarios
{
    public partial class Usuarios : Form
    {
        NEmpleado objEmpleado = new NEmpleado();
        NUsuario objUsuario = new NUsuario();
        public Usuarios()
        {
            InitializeComponent();
        }
        private void chbDni_Click(object sender, EventArgs e)
        {
            chbNombre.Checked = false;
            chbDni.Checked = true;
        }

        private void chbNombre_Click(object sender, EventArgs e)
        {
            chbDni.Checked = false;
            chbNombre.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BorrarMensajeProviderCM(txtBuscar);
            if (ValidarCamposCM(txtBuscar, chbNombre))
            {
                MessageBox.Show("Buscando Usuario");
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqString(chbDni, e);
        }

        //Empleados
        private void chbDniE_Click(object sender, EventArgs e)
        {
            chbNombreE.Checked = false;
            chbDniE.Checked = true;
        }

        private void chbNombreE_Click(object sender, EventArgs e)
        {
            chbDniE.Checked = false;
            chbNombreE.Checked = true;
        }


        private bool ValidarCamposCM(TextBox textBox, CheckBox checkBox)
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

        private void BorrarMensajeProviderCM(TextBox textBox)
        {
            errorProvider1.SetError(textBox, "");
        }



        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            BorrarMensajeProviderCM(txtBuscarE);
            if (ValidarCamposCM(txtBuscarE, chbNombreE))
            {
                MessageBox.Show("Buscando Empleado");
            }
        }

        private void txtBuscarE_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqString(chbDniE, e);
        }

        private void bloqString( CheckBox checkBox, KeyPressEventArgs e)
        {
            if (checkBox.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            AgregarRol agregarRol = new AgregarRol();
            agregarRol.ShowDialog();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.OcultarColumnasSuAdmin(dgvEmpleados);
            objUsuario.CargarGrid(dgvUsuarios);
            objUsuario.OcultarColumnas(dgvUsuarios);
        }
        int Id;
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result;

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Activar")
            {
                Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id_empleado"].Value.ToString());
                AgregarUsuario FormUsuario = new AgregarUsuario(Id);
                FormUsuario.ShowDialog();
                objEmpleado.CargarGrid(dgvEmpleados);
            }
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            objUsuario.CargarGrid(dgvEmpleados);
            objUsuario.OcultarColumnas(dgvEmpleados);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.OcultarColumnasSuAdmin(dgvEmpleados);
        }
        int IdUsuario;
        int IdEmpleado;
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "EditarUsuario")
            {
                IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_usuario"].Value.ToString());
                IdEmpleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["empleado_id"].Value.ToString());
                EditarUsuario FormEdit = new EditarUsuario(IdUsuario, IdEmpleado);
                FormEdit.ShowDialog();
                objUsuario.CargarGrid(dgvUsuarios);
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
