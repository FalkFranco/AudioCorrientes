using Login.CDatos.DEmpleados;
using Login.CNegocio;
using Login.CPresentacion.CVendedor.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            objCliente.cargarClientes(dgvClientes, true);
            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.Columns["Estado"].Visible = false;
            dgvClientes.Columns["Eliminar"].Visible = false;
            objCliente.cargarClientes(dgvClientesElim, false);
            dgvClientesElim.Columns["Id"].Visible = false;
            dgvClientesElim.Columns["Estado"].Visible = false;
            dgvClientes.Columns["Seleccionar"].Visible = false;
            //objCliente.ocultarColumnas(dgvClientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarCliente formAgregarCliente = new FormAgregarCliente();
            formAgregarCliente.ShowDialog();
            objCliente.cargarClientes(dgvClientes, true);
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
                    objCliente.cargarPorDni(dgvClientes, txtBuscar.Text,true);
                }
                else if (chbNombre.Checked)
                {
                    //MessageBox.Show("Buscando por Nombre");
                    objCliente.cargarPorNombre(dgvClientes, txtBuscar.Text, true);
                }
            
        }

        int Id;
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvClientes.Columns.Count)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                if (dgvClientes.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value.ToString());
                    FormEditarCliente FormEdit = new FormEditarCliente(Id);
                    FormEdit.ShowDialog();
                    objCliente.cargarClientes(dgvClientes, true);
                }
                if (dgvClientes.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value.ToString());
                    result = MessageBox.Show("Desea eliminar el Cliente?", "Eliminar Cliente", buttons, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Eliminar
                        EliminarCliente(Id);
                        MessageBox.Show("Cliente eliminado con Exito", "Eliminar Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        objCliente.cargarClientes(dgvClientes, true);
                        dgvClientes.Columns["Id"].Visible = false;
                        dgvClientes.Columns["Estado"].Visible = false;
                        objCliente.cargarClientes(dgvClientesElim, false);
                        dgvClientesElim.Columns["Id"].Visible = false;
                        dgvClientesElim.Columns["Estado"].Visible = false;
                    }
                }
            }
        }


        private void EliminarCliente(int id)
        {

            SqlCommand cmd;
            SqlParameter param = new SqlParameter();
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("UPDATE Clientes SET estado = 0 Where id_cliente = @id", conexion);

            param.ParameterName = "@id";
            param.Value = id;

            cmd.Parameters.Add(param);

            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        private void ActivarCliente(int id)
        {

            SqlCommand cmd;
            SqlParameter param = new SqlParameter();
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("UPDATE Clientes SET estado = 1 Where id_cliente = @id", conexion);

            param.ParameterName = "@id";
            param.Value = id;

            cmd.Parameters.Add(param);

            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void dgvClientesElim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (dgvClientesElim.Columns[e.ColumnIndex].Name == "RestaurarCliente")
            {
                Id = Convert.ToInt32(dgvClientesElim.CurrentRow.Cells["Id"].Value.ToString());
                result = MessageBox.Show("Desea restaurar el Cliente?", "Restaurar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Eliminar
                    ActivarCliente(Id);
                    MessageBox.Show("Cliente restaurado con Exito", "Restaurar Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    objCliente.cargarClientes(dgvClientes, true);
                    dgvClientes.Columns["Id"].Visible = false;
                    dgvClientes.Columns["Estado"].Visible = false;
                    objCliente.cargarClientes(dgvClientesElim, false);
                    dgvClientesElim.Columns["Id"].Visible = false;
                    dgvClientesElim.Columns["Estado"].Visible = false;
                }
            }
        }


    }
}

