using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CDatos.DUsuarios;
using Login.CNegocio;
using Login.CPresentacion.CSuAdministrador.Usuarios;
using Login.CSuAdministrador.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador.Usuarios
{
    public partial class Usuarios : Form
    {
        NEmpleado objEmpleado = new NEmpleado();
        NUsuario objUsuario = new NUsuario();

        int IdUsuario;
        int IdEmpleado;
        string NomUsuarioAct;
        string Pass;
        int Rol;
        bool Activo;
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
            chbNombreU.Checked = false;
            chbDniU.Checked = true;
        }

        private void chbNombreE_Click(object sender, EventArgs e)
        {
            chbDniU.Checked = false;
            chbNombreU.Checked = true;
        }

        private void chbDniE_Click_1(object sender, EventArgs e)
        {
            chbDniE.Checked = true;
            chbNombreEl.Checked = false;
        }
        private void chbNombreEl_Click(object sender, EventArgs e)
        {
            chbNombreEl.Checked = true;
            chbDniE.Checked = false;
        }
        private void chbDniUE_Click(object sender, EventArgs e)
        {
            chbDniUE.Checked = true;
            chbNombreUE.Checked = false;
        }

        private void chbNombreUE_Click(object sender, EventArgs e)
        {
            chbNombreUE.Checked = true;
            chbDniUE.Checked = false;
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
            BorrarMensajeProviderCM(txtBuscarU);
            if (ValidarCamposCM(txtBuscarU, chbNombreU))
            {
                MessageBox.Show("Buscando Empleado");
            }
        }

        private void txtBuscarE_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqString(chbDniU, e);
        }
        private void txtBuscarE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bloqString(chbDniE, e);
        }

        private void txtBuscarUE_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqString(chbDniUE, e);
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
            objEmpleado.cargarDtosEmpleados(dgvEmpleados);
            dgvEmpleados.Columns["Editar"].Visible = false;
            //objEmpleado.OcultarColumnasSuAdmin(dgvEmpleados);
            objEmpleado.cargarDtosEmpleadosEliminados(dgvEmpleadosEliminados);
            objUsuario.cargarUsuarios(dgvUsuarios);
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["IdEmpleado"].Visible = false;
            dgvUsuarios.Columns["Activo"].Visible = false;
            objUsuario.cargarUsuariosEliminados(dgvUsuariosEliminados);
            dgvUsuariosEliminados.Columns["Id"].Visible = false;
            dgvUsuariosEliminados.Columns["IdEmpleado"].Visible = false;
            dgvUsuariosEliminados.Columns["Activo"].Visible = false;

        }
        int Id;
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Activar")
            {
                Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value.ToString());
                AgregarUsuario FormUsuario = new AgregarUsuario(Id);
                FormUsuario.ShowDialog();
                objEmpleado.cargarDtosEmpleados(dgvEmpleados);
            }
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value.ToString());
               
                result = MessageBox.Show("Desea eliminar el Usuario?", "Eliminar Usuario", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminarEmpl(Id);
                    MessageBox.Show("Usuario eliminado con Exito" + Rol.ToString(), "Eliminar Usuario Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    objEmpleado.cargarDtosEmpleados(dgvEmpleados);
                    objEmpleado.cargarDtosEmpleadosEliminados(dgvEmpleadosEliminados);
                }
            }
        }

        private void dgvUsuElim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (dgvEmpleadosEliminados.Columns[e.ColumnIndex].Name == "ActivarEmpleado")
            {
                Id = Convert.ToInt32(dgvEmpleadosEliminados.CurrentRow.Cells["Id"].Value.ToString());
                result = MessageBox.Show("Desea Activar el Empleado?", "Activar Empleado", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    activarEmpl(Id);
                    MessageBox.Show("Empleado Activado con Exito" + Rol.ToString(), "Activar Empleado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    objEmpleado.cargarDtosEmpleados(dgvEmpleados);
                    objEmpleado.cargarDtosEmpleadosEliminados(dgvEmpleadosEliminados);
                }
               
                
            }
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            objUsuario.cargarUsuarios(dgvUsuarios);
            //objUsuario.OcultarColumnas(dgvEmpleados);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objEmpleado.CargarGrid(dgvEmpleados);
            objEmpleado.OcultarColumnasSuAdmin(dgvEmpleados);
        }
        

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "EditarUsuario")
            {
                IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value.ToString());
                IdEmpleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdEmpleado"].Value.ToString());
                EditarUsuario FormEdit = new EditarUsuario(IdUsuario, IdEmpleado);
                FormEdit.ShowDialog();
                objUsuario.cargarUsuarios(dgvUsuarios);
            }
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "EliminarUsuario")
            {
                Id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString());
                IdEmpleado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdEmpleado"].Value.ToString());
                NomUsuarioAct = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                Pass = dgvUsuarios.CurrentRow.Cells["Password"].Value.ToString();
                Rol = validarRol(dgvUsuarios.CurrentRow.Cells["Rol"].Value.ToString());
                Activo = false;
                result = MessageBox.Show("Desea eliminar el Usuario?", "Eliminar Usuario", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    objUsuario.EditarUsuario(Id, IdEmpleado, NomUsuarioAct, Pass, Rol, Activo);
                    //Eliminar (Cambiar Estado)
                    //objProducto.EliminarCliente(Id);
                    MessageBox.Show("Usuario eliminado con Exito" + Rol.ToString(), "Eliminar Usuario Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    objUsuario.cargarUsuarios(dgvUsuarios);
                }
            }
        }


        private void dgvUsuariosEliminados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            if (dgvUsuariosEliminados.Columns[e.ColumnIndex].Name == "ActivarUsuario")
            {
                Id = Convert.ToInt32(dgvUsuariosEliminados.CurrentRow.Cells["Id"].Value.ToString());
                IdEmpleado = Convert.ToInt32(dgvUsuariosEliminados.CurrentRow.Cells["IdEmpleado"].Value.ToString());
                NomUsuarioAct = dgvUsuariosEliminados.CurrentRow.Cells["Usuario"].Value.ToString();
                Pass = dgvUsuariosEliminados.CurrentRow.Cells["Password"].Value.ToString();
                Rol = validarRol(dgvUsuariosEliminados.CurrentRow.Cells["Rol"].Value.ToString());
                Activo = true;
                result = MessageBox.Show("Desea Activar el Usuario?", "Activar Usuario", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    objUsuario.EditarUsuario(Id, IdEmpleado, NomUsuarioAct, Pass, Rol, Activo);
                    //Eliminar (Cambiar Estado)
                    //objProducto.EliminarCliente(Id);
                    MessageBox.Show("Usuario activado con Exito" + Rol.ToString(), "Activar Usuario Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    objUsuario.cargarUsuarios(dgvUsuarios);
                    objUsuario.cargarUsuariosEliminados(dgvUsuariosEliminados);

                }
            }
        }

        public int validarRol(String rolName)
        {

            switch (rolName)
            {
                case "Administrador":
                    return 1;
                case " Super Administrador":
                    return 2;
                case "Gerente":
                    return 3;
                case "Vendedor":
                    return 4;
                default:
                    return 0;
            }
        }

        private void btnActualizarUsuElim_Click(object sender, EventArgs e)
        {
            objUsuario.cargarUsuariosEliminados(dgvUsuariosEliminados);
        }

        


        private void eliminarEmpl(int id)
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
        private void activarEmpl(int id)
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            //Buscar
            if (chbDni.Checked)
            {
                objEmpleado.cargarDatosEmpleadosDNI(dgvEmpleados, txtBuscar.Text,true);
            }
            else
            {
                objEmpleado.cargarDatosEmpleadosNombre(dgvEmpleados, txtBuscar.Text, true);
            }
        }


        private void txtBuscarE_TextChanged_1(object sender, EventArgs e)
        {
           
            //Buscar
            if (chbDniU.Checked)
            {
                objEmpleado.cargarDatosEmpleadosDNI(dgvEmpleados, txtBuscar.Text, false);
            }
            else
            {
                objEmpleado.cargarDatosEmpleadosNombre(dgvEmpleados, txtBuscar.Text, false);
            }

        }

        


    }
}
