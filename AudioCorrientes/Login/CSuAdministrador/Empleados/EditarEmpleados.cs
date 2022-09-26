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
    public partial class EditarEmpleados : Form
    {
        public EditarEmpleados()
        {
            InitializeComponent();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea agregar un nuevo producto?", "Agregar Producto", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Producto Agregado");
                    //limpiarFormulario();
                }

            }
        }

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            string msgCar = "Ingrese un dni valido";
            int userVal = 0;
            bool ok = true;
            //Si estan vacios
            if (txtDni.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDni, msg);
            }
            else
            {
                userVal = int.Parse(txtDni.Text);
            }

            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassword, msg);
            }
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, msg);
            }

            if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, msg);
            }
            if (txtTel.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTel, msg);
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, msg);
            }
            //Dni con 8 Caracteres

            if (txtDni.Text.Length != 8 || userVal < 10000000)
            {
                ok = false;
                errorProvider1.SetError(txtDni, msgCar);
            }
            if (txtTel.Text.Length != 10)
            {
                ok = false;
                errorProvider1.SetError(txtTel, "Ingrese un telefono valido | 10 digitos");
            }
            //Validacion ComboBox
            if (comboBoxRol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(comboBoxRol, msg);
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtDni, "");
            errorProvider1.SetError(txtPassword, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtTel, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(comboBoxRol, "");
        }



        private void btnVerPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else txtPassword.UseSystemPasswordChar = false;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (AlgoritmoContraseñaSegura(txtPassword.Text) == false)
            {
                errorProvider1.SetError(txtPassword, "La contraseña debe contener al menos una Mayuscula, simbolo y numero");
            }
        }

        private bool AlgoritmoContraseñaSegura(string password)
        {
            bool mayuscula = false, minuscula = false, numero = false, carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }
            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }


    }
}
