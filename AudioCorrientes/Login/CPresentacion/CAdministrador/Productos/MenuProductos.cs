using Login.CDatos;
using Login.CNegocio;
using Login.CPresentacion.CVendedor.Clientes;
using Login.CSuAdministrador.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CSuAdministrador
{
    public partial class MenuProductos : Form
    {
        NProductos objProducto = new NProductos();  
        public MenuProductos()
        {
            InitializeComponent();
        }
        //Eventos para abrir formularios
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProductos formAgregarProd = new AgregarProductos();
            formAgregarProd.ShowDialog();
            objProducto.cargarProducto(dgvProductos);
        }


        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            AgregarCategoria formAddCat = new AgregarCategoria();
            formAddCat.ShowDialog();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca formAddMarca = new AgregarMarca();
            formAddMarca.ShowDialog();
        }

       

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex >= 0 && this.dgvProductos.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell cellBoton = this.dgvProductos.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

            }
        }


        //Listar Categorias
        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            BorrarMensajeProviderCM(txtBuscarC);
            if (ValidarCamposCM(txtBuscarC))
            {
                MessageBox.Show("Buscando Categoria");
            }
        }

        private bool ValidarCamposCM(TextBox textBox)
        {
            bool ok = true;
            if (textBox.Text == "")
            {
                ok = false;
                errorProviderBuscar.SetError(textBox, "No puede estar vacio");
            }
            if (textBox.Text.Length <= 4)
            {
                ok = false;
                errorProviderBuscar.SetError(textBox, "Ingrese mas de 4 caracteres");
            }
            return ok;
        }
        
        //Listar Marca
        private void BorrarMensajeProviderCM(TextBox textBox)
        {
            errorProviderBuscar.SetError(textBox, "");
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            BorrarMensajeProviderCM(txtBuscarM);
            if (ValidarCamposCM(txtBuscarM))
            {
                MessageBox.Show("Buscando Marca");
            }
        }

        int Id;

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvProductos.Columns.Count)
            {
                if (dgvProductos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value.ToString());
                    EditarProducto FormEdit = new EditarProducto(Id);
                    FormEdit.ShowDialog();
                    objProducto.cargarProducto(dgvProductos);
                }
                if (dgvProductos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value.ToString());
                    result = MessageBox.Show("Desea eliminar el Producto?", "Eliminar Producto", buttons, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        eliminarProducto(Id);
                        MessageBox.Show("Producto eliminado con Exito", "Eliminar Producto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        objProducto.cargarProducto(dgvProductos);
                        objProducto.cargarProductoNoListados(dgvProdNoListado);
                    }
                }

            }

        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {
            objProducto.cargarProducto(dgvProductos);
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            objProducto.mostrarMarca(dgvMarca);
            objProducto.mostrarCategorias(dgvCat);
            
            dgvMarca.Columns["Id"].Visible = false;
            dgvCat.Columns["Id"].Visible = false;
            objProducto.cargarProductoNoListados(dgvProdNoListado);
            dgvProdNoListado.Columns["Id"].Visible = false;
            dgvProdNoListado.Columns["Estado"].Visible = false;
            //objProducto.OcultarColumnas(dgvProductos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            objProducto.cargarProducto(dgvProductos);
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            objProducto.cargarProductoNoListados(dgvProdNoListado);
            dgvProdNoListado.Columns["Id"].Visible = false;
            dgvProdNoListado.Columns["Estado"].Visible = false;
        }

        private void eliminarProducto(int id)
        {

            SqlCommand cmd;
            SqlParameter param = new SqlParameter();
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("UPDATE Productos SET estado = 0 Where id_productos = @id", conexion);

            param.ParameterName = "@id";
            param.Value = id;

            cmd.Parameters.Add(param);

            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();  
        }
        private void ListarProducto(int id)
        {

            SqlCommand cmd;
            SqlParameter param = new SqlParameter();
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("UPDATE Productos SET estado = 1 Where id_productos = @id", conexion);

            param.ParameterName = "@id";
            param.Value = id;

            cmd.Parameters.Add(param);

            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void dgvProdNoListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvProductos.Columns.Count)
            {
                if (dgvProdNoListado.Columns[e.ColumnIndex].Name == "Listar")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    Id = Convert.ToInt32(dgvProdNoListado.CurrentRow.Cells["Id"].Value.ToString());
                    result = MessageBox.Show("Desea listar el Producto?", "Listar Producto", buttons, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ListarProducto(Id);
                        MessageBox.Show("Producto Listado con Exito", "Listar Producto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        objProducto.cargarProducto(dgvProductos);
                        objProducto.cargarProductoNoListados(dgvProdNoListado);
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            objProducto.cargarPorNombre(dgvProductos, txtBuscar.Text);
        }

        private void txtBuscarC_TextChanged(object sender, EventArgs e)
        {
            objProducto.mostrarCategoriasNombre(dgvCat, txtBuscarC.Text);
        }

        private void txtBuscarM_TextChanged(object sender, EventArgs e)
        {
            objProducto.mostrarMarcasNombre(dgvMarca, txtBuscarM.Text);
        }


    }
}
