using Login.CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CPresentacion.CSuAdministrador.Usuarios
{
    public partial class EditarUsuario : Form
    {
        NUsuario objUsuario = new NUsuario();
        NEmpleado objEmpleado = new NEmpleado();
        string idValue = "";
        public EditarUsuario(int pIdUsu, int pIdEmpl)
        {
            InitializeComponent();
            objEmpleado.CargarFormUsuario(pIdEmpl, txtIdEmpleado, txtDni, txtNombre, txtApellido, txtEmail);
            objUsuario.CargarFormEditar(pIdUsu, txtIdUsuario, txtIdEmpleado, txtUsuario, txtPass, cbRol, chbEstado);
        }

       

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                int idUsuario = Int32.Parse(txtIdUsuario.Text);
                int idEmp = Int32.Parse(txtIdEmpleado.Text);
                int idRol = Int32.Parse(idValue);//De string a int para poder almacenar en la base de datos
                bool estado = ValidarEstado(chbEstado);
                result = MessageBox.Show("Desea editar el Usuario?", "Editar Usuario", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (objUsuario.EditarUsuario(idUsuario,idEmp, txtUsuario.Text, txtPass.Text, idRol, estado))
                    {
                        MessageBox.Show("El Usuario se registró correctamente", "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDni.Focus();
                    }
                    //limpiarFormulario();
                }
            }
        }
        public bool ValidarEstado(CheckBox chbEstado)
        {
            if (!chbEstado.Checked)
            {
                return false;
            }
            return true;
        }

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            bool ok = true;
            //Si estan vacios
            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDni, msg);
            }
            if (txtPass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, msg);
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtPass, "");
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            idValue = cbRol.SelectedValue.ToString();
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValue = cbRol.SelectedValue.ToString();
        }
    }
}
