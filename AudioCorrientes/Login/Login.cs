using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Login.CSuAdministrador;
using Login.CVendedor;
using Login.CAdministrador;
using Login.CGerente;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void msgError(string msg)
        {
            lblErrorMensaje.Text = "   " + msg;
            lblErrorMensaje.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
           if(txtPassword.Text == "")
            {
                msgError("    " + "Ingrese Contraseña");
            }
            if (txtUser.Text == "")
            {
                msgError("    " + "Ingrese Usuario");
            }
            if (txtPassword.Text == "" && txtUser.Text == "")
            {
                msgError("    " + "Ingrese Todos los campos");
            }
            else if (txtUser.Text == "SuAdmin" && txtPassword.Text == "SuAdmin")
            {
                MenuPrincipalSA menuPrincipal = new MenuPrincipalSA();
                menuPrincipal.Show();
                this.Hide();
            }else if (txtUser.Text == "Vendedor" && txtPassword.Text == "Vendedor")
            {
                MenuPrincipalVendedor menuPrincipalVendedor = new MenuPrincipalVendedor();
                menuPrincipalVendedor.Show();
                this.Hide();
            }else if (txtUser.Text == "Admin" && txtPassword.Text == "Admin")
            {
                MenuPrincipalAdministrador menuPrincipalAdministrador = new MenuPrincipalAdministrador();
                menuPrincipalAdministrador.Show();
                this.Hide();
            }else if (txtUser.Text == "Gerente" && txtPassword.Text == "Gerente")
            {
                MenuPrincipalGerente menuPrincipalGerente = new MenuPrincipalGerente();
                menuPrincipalGerente.Show();
                this.Hide();
            }
            else MessageBox.Show("No existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        
    }
}
