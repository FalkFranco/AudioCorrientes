using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CSuAdministrador.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CNegocio
{
    internal class NProductos
    {
        DProductos dProductos = new DProductos(); 
        readonly DMarca  dMarca = new DMarca();
        readonly DCategoria dCategoria = new DCategoria();   
        Producto Producto = new Producto();

        public void CargarGrid(DataGridView dgv)
        {
            var Lst = dProductos.Read();
            dgv.DataSource = Lst;
            OrdenDgv(dgv);
        }

        public void OrdenDgv(DataGridView dgv)
        {
            dgv.Columns["id_productos"].DisplayIndex = 0;
            dgv.Columns["id_categorias"].DisplayIndex = 1;
            dgv.Columns["id_marcas"].DisplayIndex = 2;
            dgv.Columns["nombre"].DisplayIndex = 3;
            dgv.Columns["descripcion"].DisplayIndex = 4;
            dgv.Columns["precio"].DisplayIndex = 5;
            dgv.Columns["stock"].DisplayIndex = 6;
            dgv.Columns["estado"].DisplayIndex = 7;
            dgv.Columns["Editar"].DisplayIndex = 8;
            dgv.Columns["Eliminar"].DisplayIndex = 9;
        }


        public void CargarGridNom(DataGridView dgv, String nombre)
        {
            var Lst = dProductos.BuscarNombre(nombre);
            dgv.DataSource = Lst;
        }


        public void OcultarColumnas(DataGridView dgv)
        {
            dgv.Columns["Categoria"].Visible = false;
            dgv.Columns["DetalleVentas"].Visible = false;
            dgv.Columns["Marca"].Visible = false;
        }

        public void CargarComboBoxMarca(ComboBox cb)
        {
            var Lst = dMarca.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "marca"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_marcas"; //El valor que se va almacenar es el id 


                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
        public void CargarComboBoxCategoria(ComboBox cb)
        {
            var Lst = dMarca.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "categoria"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_categorias"; //El valor que se va almacenar es el id 


                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        public bool AgregarProducto(int idCat, int idMarca, string nombre, string descripcion, float precio, int stock)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            Producto.id_categorias = idCat;
            Producto.id_marcas = idMarca;
            Producto.nombre = nombre;
            Producto.descripcion = descripcion;
            Producto.precio = precio;
            Producto.stock = stock;

            if (dProductos.Create(Producto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CargarFormEditar(int pId, TextBox id, ComboBox cat, ComboBox marca, TextBox nom, TextBox descripcion, TextBox precio, TextBox stock, CheckBox estado)
        {
            var Lst = dProductos.Buscar(pId);
            if (Lst.Count > 0)
            {
                foreach (Producto producto in Lst)
                {
                    id.Text = producto.id_productos.ToString();
                    CargarComboBoxEditarCat(cat, producto.id_categorias);
                    CargarComboBoxEditarMarca(marca, producto.id_marcas);
                    nom.Text = producto.nombre;
                    descripcion.Text = producto.descripcion;
                    precio.Text = producto.precio.ToString();
                    stock.Text = producto.stock.ToString();
                    estado.Checked = producto.estado;
                    
                }
            }
        }

        public void CargarComboBoxEditarCat(ComboBox cb, int id)
        {
            var Lst =dCategoria.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "marca"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_marcas"; //El valor que se va almacenar es el id 
                cb.SelectedValue = id;

                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;


            }
        }

        public void CargarComboBoxEditarMarca(ComboBox cb, int id)
        {
            var Lst = dMarca.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "categoria"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_categorias"; //El valor que se va almacenar es el id 
                cb.SelectedValue = id;

                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }


        public bool EditarProducto(int id, int idCat, int idMar, string nombre, string descripcion, float precio, int stock, bool estado)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            Producto.id_categorias = idCat;
            Producto.id_marcas = idMar;
            Producto.nombre = nombre;
            Producto.descripcion = descripcion;
            Producto.precio = precio;
            Producto.stock = stock;
            Producto.estado = estado;

            if (dProductos.EditarProducto(Producto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
