using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                MessageBox.Show("Realizando busqueda...");
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtBusqueda.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtBusqueda, "No puede estar vacio al realizar una busqueda");
            }
            if (txtBusqueda.Text.Length <= 4)
            {
                ok = false;
                errorProvider1.SetError(txtBusqueda, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtBusqueda, "");
        }
    }
}
