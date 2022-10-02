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
    }
}
