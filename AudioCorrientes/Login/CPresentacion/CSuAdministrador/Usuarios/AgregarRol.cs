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
    public partial class AgregarRol : Form
    {
        bool verPass;
        public AgregarRol()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea agregar un nuevo Usuario?", "Agregar Usuario", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Usuario Agregado");
                    //limpiarFormulario();
                }

            }
        }

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";

            bool ok = true;
            //Si estan vacios
            if (txtDni.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDni, msg);
            }

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, msg);
            }

            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassword, msg);
            }
            if(comboBoxRol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBoxRol, msg);
            }

            return ok;
        }

        private bool noEncontrarEmpleado()
        {
            if(txtDni.Text == "")
            {
                txtPassword.Enabled = false;
                comboBoxRol.Enabled = false;
                return false;
            }else
            {
                txtPassword.Enabled = true;
                comboBoxRol.Enabled = true;
                return true;
            }
        }

        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtDni, "");
            errorProvider1.SetError(txtPassword, "");
            errorProvider1.SetError(comboBoxRol, "");
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (noEncontrarEmpleado() && txtDni.Text.Length < 9 && txtDni.Text.Length != 0)
            {
                errorProvider1.SetError(txtDni, "");
                MessageBox.Show("Buscando Empleado");
                txtPassword.Enabled = true;
                comboBoxRol.Enabled = true;

            }
            else if(txtDni.Text.Length > 9 && txtDni.Text.Length != 0)
            {
                txtPassword.Enabled = false;
                comboBoxRol.Enabled = false;
                MessageBox.Show("Ingrese un Dni valido (8 caracteres)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(txtDni, "Ingrese un Dni valido (8 caracteres)");

            }
            else if(txtDni.Text.Length == 0)
            {
                txtPassword.Enabled = false;
                comboBoxRol.Enabled = false;
                MessageBox.Show("Ingrese un Dni para buscar empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(txtDni, "Ingrese un Dni para buscar empleado");
            }
        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {
            verPass = !verPass; //cambia el estado a true o false
        }

        private void btnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
