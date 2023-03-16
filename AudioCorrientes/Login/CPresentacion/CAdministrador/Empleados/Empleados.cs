using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CNegocio;
using Login.CSuAdministrador.Productos;
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
            //objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.cargarDtosEmpleadosA(dgvEmpleados);
            objEmpleado.cargarDtosEmpleadosEliminadosA(dgvEmpleadosE);
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
            objEmpleado.cargarDtosEmpleadosA(dgvEmpleados);
            objEmpleado.cargarDtosEmpleadosEliminadosA(dgvEmpleadosE);
            dgvEmpleados.Columns["Activar"].Visible = false;
            //dgvEmpleados.Columns["Eliminar"].Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objEmpleado.cargarDtosEmpleadosA(dgvEmpleados);
            //dgvEmpleados.Columns["Activar"].Visible = false;
            //dgvEmpleados.Columns["Eliminar"].Visible = false;
        }

        int Id;
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvEmpleados.Columns.Count)
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
                    Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value.ToString());
                    result = MessageBox.Show("Desea eliminar el Cliente?", "Eliminar Cliente", buttons, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        EliminarEmpleado(Id);
                        objEmpleado.cargarDtosEmpleadosA(dgvEmpleados);
                        objEmpleado.cargarDtosEmpleadosEliminadosA(dgvEmpleadosE);
                    }
                }
            }  
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (chbDniE.Checked)
            {
                objEmpleado.cargarDatosEmpleadosDNIA(dgvEmpleados, txtBuscar.Text);
            }
            else
            {
                objEmpleado.cargarDatosEmpleadosNombreA(dgvEmpleados, txtBuscar.Text);
            }
        }

        private void EliminarEmpleado(int id)
        {

            SqlCommand cmd;
            SqlParameter param = new SqlParameter();
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("UPDATE Empleados SET activo = 0 Where id_empleado = @id", conexion);

            param.ParameterName = "@id";
            param.Value = id;

            cmd.Parameters.Add(param);

            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        private void ActivarEmpleado(int id)
        {

            SqlCommand cmd;
            SqlParameter param = new SqlParameter();
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("UPDATE Empleados SET activo = 1 Where id_empleado = @id", conexion);

            param.ParameterName = "@id";
            param.Value = id;

            cmd.Parameters.Add(param);

            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void dgvEmpleadosE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (dgvEmpleadosE.Columns[e.ColumnIndex].Name == "ActivarE")
            {
                Id = Convert.ToInt32(dgvEmpleadosE.CurrentRow.Cells["Id"].Value.ToString());
                result = MessageBox.Show("Desea activar el Cliente?", "Activar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ActivarEmpleado(Id);
                    objEmpleado.cargarDtosEmpleadosA(dgvEmpleados);
                    objEmpleado.cargarDtosEmpleadosEliminadosA(dgvEmpleadosE);
                }
            }
        }
    }
}
