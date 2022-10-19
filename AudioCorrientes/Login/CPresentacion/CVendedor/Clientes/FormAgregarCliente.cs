using Login.CDatos;
using Login.CNegocio;
using Login.CSuAdministrador.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CVendedor.Clientes
{
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
        }
        NCliente objCliente = new NCliente();
        Dclientes datos = new Dclientes();
        string idValue = "";
        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {
            objCliente.CargarComboBox(comboBox1);
            comboBox1.SelectedValue = 1; //Por defecto al cargar es Consumidor Final
            idValue = comboBox1.SelectedValue.ToString(); //Alamacena el id para poder cargar en la db
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show("Desea agregar un nuevo Cliente?", "Agregar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int idTipoInt = Int32.Parse(idValue);//De string a int para poder almacenar en la base de datos
                    if (objCliente.AgregarCliente(txtDni.Text,txtNombre.Text,txtApellido.Text,txtTel.Text,txtDireccion.Text,txtEmail.Text, idTipoInt))
                    {
                        MessageBox.Show("El Cliente se registró correctamente", "Cliente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDni.Focus();
                    }
                    //limpiarFormulario();
                }
            }
        }

        private bool ValidarCampos()
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
            if (ValidarEmail(txtEmail.Text) == false)
            {
                ok = false;
                errorProvider1.SetError(txtEmail, "Ingrese un email valido");
            }

                return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtDni, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtTel, "");
            errorProvider1.SetError(txtDireccion, "");
        }

        public static bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = idValue;
        //}

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValue = comboBox1.SelectedValue.ToString();
        }

        private void btnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
