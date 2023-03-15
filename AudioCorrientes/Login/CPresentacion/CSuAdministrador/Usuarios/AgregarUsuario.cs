using Login.CNegocio;
using Login.CVendedor.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.CPresentacion.CSuAdministrador.Usuarios
{
    public partial class AgregarUsuario : Form
    {   NEmpleado objEmpleado = new NEmpleado(); 
        NUsuario objUsuario = new NUsuario();
        string idValue = "";
        public AgregarUsuario(int pId)
        {
            InitializeComponent();
            objEmpleado.CargarFormUsuario(pId, txtIdEmpleado, txtDni, txtNombre, txtApellido, txtEmail);
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                int idEmp = Int32.Parse(txtIdEmpleado.Text);
                int idRol = Int32.Parse(idValue);//De string a int para poder almacenar en la base de datos
                result = MessageBox.Show("Desea agregar un nuevo Usuario?", "Agregar Usuario", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (objUsuario.AgregarUsuario(idEmp, txtUsuario.Text, txtPass.Text, idRol))
                    {
                        MessageBox.Show("El Usuario se registró correctamente", "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarEmpleados();
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

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValue = cbRol.SelectedValue.ToString();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            objUsuario.CargarComboBoxRol(cbRol);
            cbRol.SelectedValue = 1; //Por defecto al cargar es Consumidor Final
            idValue = cbRol.SelectedValue.ToString(); //Alamacena el id para poder cargar en la db
        }

        public void actualizarEmpleados()
        {
            SqlCommand cmd;
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("ActualizarEmpl", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
