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
            objProducto.CargarGrid(dgvProductos);
            objProducto.OcultarColumnas(dgvProductos);
        }

        int Id;
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (dgvProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                //AGREGAR FORMULARIO PARA EDITAR
                Id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_cliente"].Value.ToString());
                FormEditarCliente FormEdit = new FormEditarCliente(Id);
                FormEdit.ShowDialog();
                objProducto.CargarGrid(dgvProductos);
            }
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_cliente"].Value.ToString());
                result = MessageBox.Show("Desea eliminar el Cliente?\n Se eliminara de forma permanente", "Eliminar Cliente", buttons, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ////Eliminar: Actualizar el estado 
                    //objProducto.EliminarProducto(Id);
                    //MessageBox.Show("Cliente eliminado con Exito", "Eliminar Cliente Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //objProducto.CargarGrid(dgvProductos);
                }
            }
        }
    }
}
