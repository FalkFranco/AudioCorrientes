using Login.CNegocio;
using Login.CPresentacion.CVendedor.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CVendedor.Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        NCliente objCliente = new NCliente();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //validacion txtbox
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                //Buscar
                if (chbCuit.Checked)
                {
                    //MessageBox.Show("Buscando por DNI");
                    objCliente.CargarGridDni(dgvClientes, txtBuscar.Text);
                }
                else if (chbNombre.Checked)
                {
                    //MessageBox.Show("Buscando por Nombre");
                    objCliente.CargarGridNom(dgvClientes, txtBuscar.Text);
                }
            }
        }

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            bool ok = true;
            //Si estan vacios
            if (txtBuscar.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtBuscar, msg);
            }
            if (chbCuit.Checked == true && txtBuscar.Text.Length > 11)
            {
                ok = false;
                errorProvider1.SetError(txtBuscar, "Ingrese un DNI valido (8 digitos)");
            }
            return ok;
        }

        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtBuscar, "");
        }


        private void chbNombre_Click(object sender, EventArgs e)
        {
            chbCuit.Checked = false;
            chbNombre.Checked = true;
        }

        private void chbCuit_Click(object sender, EventArgs e)
        {
            chbNombre.Checked = false;
            chbCuit.Checked = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chbCuit.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {
            objCliente.CargarGrid(dgvClientes);
            objCliente.ocultarColumnas(dgvClientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarCliente formAgregarCliente = new FormAgregarCliente();
            formAgregarCliente.ShowDialog();
            objCliente.CargarGrid(dgvClientes);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objCliente.CargarGrid(dgvClientes);
            objCliente.ocultarColumnas(dgvClientes);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //validacion txtbox
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                //Buscar
                if (chbCuit.Checked)
                {
                    //MessageBox.Show("Buscando por DNI");
                    objCliente.CargarGridDni(dgvClientes, txtBuscar.Text);
                }
                else if (chbNombre.Checked)
                {
                    //MessageBox.Show("Buscando por Nombre");
                    objCliente.CargarGridNom(dgvClientes, txtBuscar.Text);
                }
            }
        }

        int Id;
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (dgvClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                Id = Convert.ToInt32( dgvClientes.CurrentRow.Cells["id_cliente"].Value.ToString());
                FormEditarCliente FormEdit = new FormEditarCliente(Id);
                FormEdit.ShowDialog();
                objCliente.CargarGrid(dgvClientes);
            }
            if (dgvClientes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id_cliente"].Value.ToString());
                result = MessageBox.Show("Desea eliminar el Cliente?\n Se eliminara de forma permanente", "Eliminar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Eliminar
                    objCliente.EliminarCliente(Id);
                    MessageBox.Show("Cliente eliminado con Exito", "Eliminar Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    objCliente.CargarGrid(dgvClientes);
                }
            }
        }

    }
}

