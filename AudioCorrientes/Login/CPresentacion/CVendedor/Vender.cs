using Login.CDatos;
using Login.CDatos.DEmpleados;
using Login.CDatos.DProductos;
using Login.CDatos.DUsuarios;
using Login.CNegocio;
using Login.CPresentacion.CSuAdministrador.Usuarios;
using Login.CPresentacion.CVendedor;
using Login.CPresentacion.CVendedor.Clientes;
using Login.CVendedor.Clientes;
using Login.CVendedor.Productos;
using Login.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static DevExpress.XtraReports.Design.View.Office2003PaintHelper;
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
                ////Metodo Agregar al detalle
                //AgregarProducto();
                //CalcularTotal();
                controlarPruductoLista(txtIdArticulo.Text);
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
                if (ValidarVenta())
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
                        nVentas.cargarVentas(dgvVentas, pUsuario.id_empleado);

                        //ACTIVAR DESPUES
                        dgvVentas.Columns["IdEmpleado"].Visible = false;

                    }

                    //Limpiar formulario
                    limpiarFormulario();

                    MessageBox.Show("Facturacion realizada con exito");
                }
            }
        }

        private void limpiarFormulario()
        {
            txtIdCliente.Text = "";
            txtdni.Text = "";
            txtNombre.Text = "";
            txtIdArticulo.Text = "";
            txtNombreCliente.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }
        private bool ValidarVenta()
        {
            string msg = "No puede estar vacio";
            bool ok = true;
            if (txtIdCliente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdCliente, msg);
            }

            return ok;
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
            txtCantidad.Text = "";
            txtNombre.Text = "";
            txtIdArticulo.Text = "";
            txtPrecio.Text = "";
            lbStock.Text = "0";
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
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            //dProductos.OcultarColumnas(dgvProductos);
            nCliente.cargarClientesVen(dgvClientes,true);
            dgvClientes.Columns["Id"].Visible = false;
            //nCliente.ocultarColumnasVen(dgvClientes);

            nVentas.cargarVentas(dgvVentas, pUsuario.id_empleado);

            //ACTIVAR DESPUES --------------------------------------
            dgvVentas.Columns["IdEmpleado"].Visible = false;
            dgvVentas.Columns["Estado"].Visible = false;

            dtpDesde.MaxDate = DateTime.Now.AddDays(-1);
            dtpHasta.MaxDate = DateTime.Now;

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
            nCliente.cargarPorNombre(dgvClientes, txtBuscarCliente.Text, true);
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
        DataGridViewRow ColumnaVenta;
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
            //rowVenta = dgvVentas.Rows[e.RowIndex]; 
            if (row != null)
            {
                //En este ejemplo supongo que el nombre de la columna que contendra en Id de la persona se llama columnPersonaId,
                //de no ser asi cambia este valor por el que tengas
                var idVenta = Convert.ToInt32(row.Cells["NroFactura"].Value);

                //En esta linea se supone que tienes una funcion que recibe un parametro de entrada que corresponde al Id de la persona
                //y que esta funcion devuelve una coleccion de obejetos (una lista generica o un DataTable)
                nVentas.cargarDetalles(dgvDetalles, idVenta);

                //ACTIVAR DESPUES-------------------------------------------------------

                dgvDetalles.Columns["IdVenta"].Visible = false;
                dgvDetalles.Columns["IdProducto"].Visible = false;
                dgvDetalles.Columns["DetalleNro"].Visible = false;
                
                ColumnaVenta = row;
            }
        }
        //Listado de ventas

        private void controlarPruductoLista(string pId)
        {
            if (dataGridViewDetalle.RowCount > 0)
            {
                // Primero averigua si el registro existe:
                bool existe = false;
                for (int i = 0; i < dataGridViewDetalle.RowCount; i++)
                {
                    if (Int32.Parse(dataGridViewDetalle.Rows[i].Cells["IdArticulo"].Value.ToString()) == Int32.Parse(pId))
                    {
                        MessageBox.Show("El producto ya ha sido ingresado");
                        existe = true;
                        int cant = Int32.Parse(dataGridViewDetalle.Rows[i].Cells["CantProL"].Value.ToString());
                        float subTotal = float.Parse(dataGridViewDetalle.Rows[i].Cells["SubTotL"].Value.ToString());
                        cant += Int32.Parse(txtCantidad.Text);
                        dataGridViewDetalle.Rows[i].Cells["CantProL"].Value = cant;
                        dataGridViewDetalle.Rows[i].Cells["SubTotL"].Value = subTotal + float.Parse(txtPrecio.Text);
                        CalcularTotal();
                        txtCantidad.Text = "";
                        txtNombre.Text = "";
                        txtIdArticulo.Text = "";
                        txtPrecio.Text = "";
                        lbStock.Text = "0";

                        break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                    }
                }

                // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:
                if (existe == false)
                {
                    AgregarProducto();
                    CalcularTotal();
                }
            }
            else
            {
                AgregarProducto();
                CalcularTotal();
            }
        }

        
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        
        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            Image newImage = Image.FromFile("C:\\Users\\colo5\\Desktop\\AudioCorrientes\\AudioCorrientes\\Login\\Resources\\logoM (2).png");
            
            DetallePedido d = new DetallePedido();
            CabeceraDetalle c = new CabeceraDetalle();
            crearTicket ticket = new crearTicket();
            ticket.empresa = "AudioCorrientes";
            ticket.direccion = "Junin 283";
            ticket.logo = newImage;
            int row = dgvVentas.CurrentRow.Index;
            //MessageBox.Show(dgvVentas.Rows[row].Cells[0].Value.ToString());
            c = new CabeceraDetalle();
            c.VentaId = Convert.ToInt32(dgvVentas.Rows[row].Cells[0].Value);
            c.Fecha = DateTime.Parse(dgvVentas.Rows[row].Cells[1].Value.ToString(), new CultureInfo("en-CA"));
            c.Cliente = dgvVentas.Rows[row].Cells[2].Value.ToString();
            c.Empleado = dgvVentas.Rows[row].Cells[4].Value.ToString();
            c.Total = Convert.ToDecimal(dgvVentas.Rows[row].Cells[5].Value);
            ticket.listaCabecera.Add(c);


            for (int i = 0; i < dgvDetalles.Rows.Count; i++)
            {
                d = new DetallePedido();
                d.NombreProducto = Convert.ToString(dgvDetalles.Rows[i].Cells[3].Value);
                d.PrecioUnitario = Convert.ToDecimal(dgvDetalles.Rows[i].Cells[4].Value);
                d.Cantidad = Convert.ToInt32(dgvDetalles.Rows[i].Cells[5].Value);
                d.Total = Convert.ToDecimal(dgvDetalles.Rows[i].Cells[6].Value);
                ticket.listaProductos.Add(d);
            }
            ticket.imprimir(ticket);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            nVentas.cargarVentasFechas(dgvVentas, pUsuario.id_empleado, dtpDesde.Value, dtpHasta.Value);
            dgvVentas.Columns["IdEmpleado"].Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nVentas.cargarVentas(dgvVentas, pUsuario.id_empleado);
            dgvVentas.Columns["IdEmpleado"].Visible = false;
            dgvVentas.Columns["Estado"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
