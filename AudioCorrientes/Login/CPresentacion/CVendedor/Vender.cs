using Login.CDatos;
using Login.CDatos.DEmpleados;
using Login.CDatos.DProductos;
using Login.CDatos.DUsuarios;
using Login.CNegocio;
using Login.CPresentacion.CSuAdministrador.Usuarios;
using Login.CPresentacion.CVendedor.Clientes;
using Login.CVendedor.Clientes;
using Login.CVendedor.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.CVendedor
{
    public partial class Vender : Form
    {
        UsuarioLogin pUsuario = new UsuarioLogin();
        NProductos nProductos = new NProductos();
        NVentas nVentas = new NVentas();
        NCliente nCliente = new NCliente();

        string idValue = "";
        public Vender(UsuarioLogin pUsuario)
        {
            InitializeComponent();
            this.pUsuario = pUsuario;
        }

        

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            BorrarMensajeProvider();
            if (ValidarCampos())
            {
                //Metodo Agregar al detalle
                AgregarProducto();
                CalcularTotal();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar productos para la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float total = float.Parse(lbTotal.Text);
                int idCliente = Int32.Parse(txtIdCliente.Text);
                int idTipoInt = Int32.Parse(idValue);
                nVentas.AgregarFactura(idTipoInt, pUsuario.id_empleado, idCliente, total);
                int ultimoIdFactura = Int32.Parse(lbNroFactura.Text);
                //Agregar los detalles
                foreach (DataGridViewRow row in dataGridViewDetalle.Rows)
                {

                    int id = Int32.Parse(row.Cells["idArticulo"].Value.ToString());
                    float precio = float.Parse(row.Cells["PrecioProdL"].Value.ToString());
                    int cant = Int32.Parse(row.Cells["CantProL"].Value.ToString());
                    //MessageBox.Show(ultimoIdFactura.ToString() + id.ToString() + ' ' + precio.ToString() + ' ' + cant.ToString());

                    nVentas.AgregarDetalleVenta(ultimoIdFactura, id, precio, cant);

                    //Actualizar stock
                    nProductos.ActualizarStock(id, cant);

                }

                MessageBox.Show("Facturacion realizada con exito");
            }
        }

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
            string msgStock = "No hay stock suficiente";
            bool ok = true;
            //Si estan vacios
            if (txtIdArticulo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdArticulo, msg);
            }
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, msg);
            }
            if (txtPrecio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrecio, msg);
            }
            if (txtCantidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCantidad, msg);
            }
            else
            {
                var cant = Int32.Parse(txtCantidad.Text);
                var stock = Int32.Parse(lbStock.Text);
                if (cant > stock)
                {
                    ok = false;
                    errorProvider1.SetError(txtCantidad, msgStock);
                }
            }

            
                return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtIdArticulo, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtCantidad, "");
        }

        

        private void txtIdArticulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Metodos

        
        private void AgregarProducto()
        {
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            dataGridViewDetalle.Rows.Add(txtIdArticulo.Text, txtNombre.Text, precio, txtCantidad.Text, CalcularSubTotal(precio, cantidad));
           
        }
        private float CalcularSubTotal(float precio,int cantidad)
        {
            float subTotal;
            subTotal = precio * cantidad;
            return subTotal;
        }

        private void CalcularTotal()
        {
            float CostoTotal = 0;
            int Conteo;

            Conteo = dataGridViewDetalle.RowCount; // se cuenta los productos y se utiliza el conteo como limite del for
            for (int i = 0; i < (Conteo); i++)
            {
                //lbTotal.Text = i.ToString();
                CostoTotal += float.Parse(dataGridViewDetalle.Rows[i].Cells[4].Value.ToString());
            }

            lbTotal.Text = CostoTotal.ToString();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarProductos listarProductos = new ListarProductos();
            listarProductos.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes.Clientes agregarClientes = new Clientes.Clientes();
            agregarClientes.ShowDialog();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            cbTipoFactura.SelectedValue = 1;
            dataGridViewDetalle.Rows.Clear();
            dataGridViewDetalle.Refresh();

            //idValue = cbTipoFactura.SelectedValue.ToString();
            dtpFechaActual.Value = DateTime.Now;
            lbNroFactura.Text = nVentas.UltimaFactura().ToString();
            nVentas.CargarComboBoxTipoFactura(cbTipoFactura);
            lbNomVen.Text = pUsuario.apellido + " " + pUsuario.nombre;
            nProductos.cargarProducto(dgvProductos);
            //dProductos.OcultarColumnas(dgvProductos);
            nCliente.cargarClientesVen(dgvClientes);
            //nCliente.ocultarColumnasVen(dgvClientes);

            nVentas.cargarVentas(dgvVentas);
            
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                txtIdArticulo.Text = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                lbStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name == "SeleccionarCliente")
            {
                txtIdCliente.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
                txtdni.Text = dgvClientes.CurrentRow.Cells["Dni"].Value.ToString();
                txtNombreCliente.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString() + ' ' + dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString() ;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            nProductos.cargarPorNombre(dgvProductos, txtBuscarProd.Text);
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            nCliente.cargarPorNombre(dgvClientes, txtBuscarCliente.Text);
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            dataGridViewDetalle.Rows.RemoveAt(dataGridViewDetalle.CurrentRow.Index);
            CalcularTotal();
        }

        private void cbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            idValue = cbTipoFactura.SelectedValue.ToString();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
            if (row != null)
            {
                //En este ejemplo supongo que el nombre de la columna que contendra en Id de la persona se llama columnPersonaId,
                //de no ser asi cambia este valor por el que tengas
                var idVenta = Convert.ToInt32(row.Cells["Id"].Value);

                //En esta linea se supone que tienes una funcion que recibe un parametro de entrada que corresponde al Id de la persona
                //y que esta funcion devuelve una coleccion de obejetos (una lista generica o un DataTable)
                nVentas.cargarDetalles(dgvDetalles, idVenta);
            }


        }
        //Listado de ventas


    }
}
