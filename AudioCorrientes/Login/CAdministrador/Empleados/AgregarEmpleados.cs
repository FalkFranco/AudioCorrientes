﻿using System;
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
    public partial class AgregarEmpleados : Form
    {
        
        public AgregarEmpleados()
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
                result = MessageBox.Show("Desea agregar un nuevo empleado?", "Agregar Empleado", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Empleado Agregado");
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
                errorProviderAgregarEmpleado.SetError(txtDni, msg);
            } else {
                userVal = int.Parse(txtDni.Text);
            }

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProviderAgregarEmpleado.SetError(txtNombre, msg);
            }

            if (txtApellido.Text == "")
            {
                ok = false;
                errorProviderAgregarEmpleado.SetError(txtApellido, msg);
            }
            if (txtTel.Text == "")
            {
                ok = false;
                errorProviderAgregarEmpleado.SetError(txtTel, msg);
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProviderAgregarEmpleado.SetError(txtDireccion, msg);
            }
            //Dni con 8 Caracteres

            if (txtDni.Text.Length != 8 || userVal < 10000000)
            {
                ok = false;
                errorProviderAgregarEmpleado.SetError(txtDni, msgCar);
            }
            if (txtTel.Text.Length != 10)
            {
                ok = false;
                errorProviderAgregarEmpleado.SetError(txtTel, "Ingrese un telefono valido | 10 digitos");
            }

            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProviderAgregarEmpleado.SetError(txtDni, "");
            errorProviderAgregarEmpleado.SetError(txtNombre, "");
            errorProviderAgregarEmpleado.SetError(txtApellido, "");
            errorProviderAgregarEmpleado.SetError(txtTel, "");
            errorProviderAgregarEmpleado.SetError(txtDireccion, "");
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

        private void btnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
