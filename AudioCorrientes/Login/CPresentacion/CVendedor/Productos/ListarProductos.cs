using Login.CDatos;
using Login.CDatos.DEmpleados;
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

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            objProducto.cargarProducto(dgvProductos);
            dgvProductos.Columns["Id"].Visible = false;
            //objProducto.OcultarColumnas(dgvProductos);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            objProducto.cargarPorNombre(dgvProductos, txtBuscar.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objProducto.cargarProducto(dgvProductos);
        }
    }
}
