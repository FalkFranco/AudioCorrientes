using Login.CDatos;
using Login.CDatos.DUsuarios;
using Login.CNegocio;
using Login.CVendedor.Clientes;
using Login.CVendedor.Productos;
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

namespace Login.CVendedor
{
    public partial class Vender : Form
    {
        UsuarioLogin pUsuario = new UsuarioLogin();
        NProductos dProductos = new NProductos();
        NVentas nVentas = new NVentas();
        NCliente nCliente = new NCliente();
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

        private bool ValidarCampos()
        {
            string msg = "No puede estar vacio";
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
            return ok;
        }
        private void BorrarMensajeProvider()
        {
            errorProvider1.SetError(txtIdArticulo, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtCantidad, "");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(dataGridViewDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar productos para la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                if(float.Parse(lbTotal.Text) < 0)
                {
                    MessageBox.Show("Ingrese el monto correcto del pago en efectivo, mayor al total a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Generando Ticket...");
                } 
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
            dataGridViewDetalle.Rows.Add(txtIdArticulo.Text,txtNombre.Text,precio,txtCantidad.Text,CalcularSubTotal(precio,cantidad));
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

            Conteo = dataGridViewDetalle.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < (Conteo - 1); i++)
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
            nVentas.CargarComboBoxTipoFactura(cbTipoFactura);
            lbNomVen.Text = pUsuario.apellido + " " + pUsuario.nombre;
            dProductos.CargarGridVen(dgvProductos);
            dProductos.OcultarColumnas(dgvProductos);
            nCliente.CargarGridven(dgvClientes);
            nCliente.ocultarColumnasVen(dgvClientes);
        }

    }
}
