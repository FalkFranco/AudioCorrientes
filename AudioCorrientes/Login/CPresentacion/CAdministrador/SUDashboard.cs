using Login.CNegocio;
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
    public partial class SUDashboard : Form
    {
        NVentas nVentas = new NVentas();
        NCliente nCliente = new NCliente();
        NProductos nProductos = new NProductos();
        public SUDashboard()
        {
            InitializeComponent();
        }

        private void SUDashboard_Load(object sender, EventArgs e)
        {
            lbTotVentasNro.Text =nVentas.cantVentas().ToString();
            lbCantClientes.Text = nCliente.cantClientes().ToString();
            lbCantProductos.Text = nProductos.cantProductos().ToString();
            nProductos.cargarStockBajo(dgvBajoStock);
        }


    }
}
