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
    public partial class AgregarRol : Form
    {
        public AgregarRol()
        {
            InitializeComponent();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea agregar una nuevo Rol?", "Agregar Rol", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Marca Agregada");
                    //limpiarFormulario();
                }
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtRol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRol, "No puede estar vacio");
            }
            if (txtRol.Text.Length <= 4)
            {
                ok = false;
                errorProvider1.SetError(txtRol, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtRol, "");
        }
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
