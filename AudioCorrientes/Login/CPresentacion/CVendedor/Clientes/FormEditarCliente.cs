using Login.CDatos;
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
    public partial class FormEditarCliente : Form
    {
        NCliente objCliente = new NCliente();
        string idValue;
        public FormEditarCliente(int pId)
        {
            InitializeComponent();
            objCliente.CargarFormEditar(pId,txtId, txtDni, txtNombre, txtApellido, txtTel, txtDireccion, txtEmail, comboBox1);
        }
        private void btnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea editar el Cliente?", "Editar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    int idTipoInt = Int32.Parse(idValue);//De string a int para poder almacenar en la base de datos
                    if (objCliente.EditarCliente(id,txtDni.Text, txtNombre.Text, txtApellido.Text, txtTel.Text, txtDireccion.Text, txtEmail.Text, idTipoInt))
                    {
                        MessageBox.Show("El Cliente se Edito correctamente", "Cliente Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDni.Focus();
                    }
                    //limpiarFormulario();
                }
            }
        }

        public bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            string msgCar = "Ingrese un DNI valido";
            bool ok = true;
            //Si estan vacios
            if (txtDni.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDni, msg);
            }
            //else
            //{
            //    userVal = int.Parse(txtCuit.Text);
            //}

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
            if (txtEmail.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEmail, msg);
            }
            //Dni con 8 Caracteres

            if (txtDni.Text.Length != 8)
            {
                ok = false;
                errorProvider1.SetError(txtDni, msgCar);
            }
            if (txtTel.Text.Length != 10)
            {
                ok = false;
                errorProvider1.SetError(txtTel, "Ingrese un telefono valido | 10 digitos");
            }
            //Email Valido
            if (FormAgregarCliente.ValidarEmail(txtEmail.Text) == false)
            {
                ok = false;
                errorProvider1.SetError(txtEmail, "Ingrese un email valido");
            }

            return ok;
        }

        public void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtDni, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtTel, "");
            errorProvider1.SetError(txtDireccion, "");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValue = comboBox1.SelectedValue.ToString();
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            idValue = comboBox1.SelectedValue.ToString();
        }
    }
}
