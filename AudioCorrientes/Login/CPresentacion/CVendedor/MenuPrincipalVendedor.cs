using Login.CDatos.DUsuarios;
using Login.CVendedor.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Login.CVendedor
{
    public partial class MenuPrincipalVendedor : Form
    {
        UsuarioLogin pUsuario = new UsuarioLogin();
        public MenuPrincipalVendedor(UsuarioLogin pUsuario)
        {
            InitializeComponent();
            this.pUsuario = pUsuario;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("¿Seguro que desa cerrar la aplicacion?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                Application.Exit();
            }
        }
        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void panelTop_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }



        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0) { 
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListarProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Vender());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Alerta", buttons, MessageBoxIcon.Exclamation);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes.AgregarClientes());
        }

        private void MenuPrincipalVendedor_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = pUsuario.apellido + " " + pUsuario.nombre;
        }
    
    }
}
