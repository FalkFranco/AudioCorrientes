using Login.CDatos;
using Login.CNegocio;
using Login.CPresentacion.CVendedor.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.CVendedor.Productos
{
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
        }
        NProductos objProducto = new NProductos();
        Producto producto = new Producto(); 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //validacion txtbox
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                    //Buscar
                    if (chbId.Checked)
                    {
                        MessageBox.Show("Buscando por Id");
                    }
                    else
                    {
                        MessageBox.Show("Buscando por Nombre");
                    }
            }

        }
        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            bool ok = true;
            //Si estan vacios
            if (txtBuscar.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtBuscar, msg);
            }
            return ok;
        }

        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtBuscar, "");
        }

        private void chbNombre_Click(object sender, EventArgs e)
        {
            chbId.Checked = false;
            chbNombre.Checked = true;
        }

        private void chbId_Click(object sender, EventArgs e)
        {
            chbNombre.Checked = false;
            chbId.Checked = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chbId.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            objProducto.cargarProducto(dgvProductos);
            //objProducto.OcultarColumnas(dgvProductos);
        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
