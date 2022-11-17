using Login.CDatos.DProductos;
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
    public partial class Ventas : Form
    {
        NVentas nVentas = new NVentas();
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
           
            return ok;
        }
        private void BorrarMensajeProvider()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nVentas.cargarVentaHoy(dgvVentas);
            dgvVentas.Columns["IdEmpleado"].Visible = false;
            dgvVentas.Columns["Estado"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nVentas.cargarVentasSemana(dgvVentas);
            dgvVentas.Columns["IdEmpleado"].Visible = false;
            dgvVentas.Columns["Estado"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nVentas.cargarVentasMes(dgvVentas);
            dgvVentas.Columns["IdEmpleado"].Visible = false;
            dgvVentas.Columns["Estado"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nVentas.cargarVentasYear(dgvVentas);
            dgvVentas.Columns["IdEmpleado"].Visible = false;
            dgvVentas.Columns["Estado"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("Selecciona un fecha correcta");
            }
            else
            {
                nVentas.cargarVentasEntre(dgvVentas, dtpDesde.Value, dtpHasta.Value);
                dgvVentas.Columns["IdEmpleado"].Visible = false;
                dgvVentas.Columns["Estado"].Visible = false;
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            dtpHasta.MaxDate = fechaHoy;
            dtpDesde.Value = fechaHoy.AddDays(-1);
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
            if (row != null)
            {
                //En este ejemplo supongo que el nombre de la columna que contendra en Id de la persona se llama columnPersonaId,
                //de no ser asi cambia este valor por el que tengas
                var idVenta = Convert.ToInt32(row.Cells["NroFactura"].Value);

                //En esta linea se supone que tienes una funcion que recibe un parametro de entrada que corresponde al Id de la persona
                //y que esta funcion devuelve una coleccion de obejetos (una lista generica o un DataTable)
                nVentas.cargarDetalles(dgvDetalle, idVenta);
                dgvDetalle.Columns["IdVenta"].Visible = false;
                dgvDetalle.Columns["IdProducto"].Visible = false;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
