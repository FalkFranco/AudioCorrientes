using Login.CDatos.DProductos;
using Login.CNegocio;
using Login.CVendedor.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CPresentacion.CVendedor.Clientes
{
    public partial class ClientesVendedor : Form
    {
        NCliente objCliente = new NCliente();

        public ClientesVendedor()
        {
            InitializeComponent();
        }

        private void ClientesVendedor_Load(object sender, EventArgs e)
        {
            objCliente.cargarClientesVen(dgvClientes, true);
            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.Columns["Estado"].Visible = false;
        }

        private void dgvClientesElim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            objCliente.cargarClientesVen(dgvClientesElim, false);
            dgvClientesElim.Columns["Id"].Visible = false;
            dgvClientesElim.Columns["Estado"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarCliente formAgregarCliente = new FormAgregarCliente();
            formAgregarCliente.ShowDialog();
            objCliente.cargarClientes(dgvClientes, true);
        }

        private void chbCuit_Click(object sender, EventArgs e)
        {
            chbNombre.Checked = false;
            chbCuit.Checked = true;
        }

        private void chbNombre_Click(object sender, EventArgs e)
        {
            chbCuit.Checked = false;
            chbNombre.Checked = true;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objCliente.cargarClientes(dgvClientes, true);
            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.Columns["Estado"].Visible = false;
            //objCliente.ocultarColumnas(dgvClientes);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //validacion txtbox

            //Buscar
            if (chbCuit.Checked)
            {
                //MessageBox.Show("Buscando por DNI");
                objCliente.cargarPorDni(dgvClientes, txtBuscar.Text, true);
            }
            else if (chbNombre.Checked)
            {
                //MessageBox.Show("Buscando por Nombre");
                objCliente.cargarPorNombre(dgvClientes, txtBuscar.Text, true);
            }

        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (chbCuit.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
