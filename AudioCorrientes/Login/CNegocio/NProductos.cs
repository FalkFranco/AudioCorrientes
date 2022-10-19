using Login.CDatos;
using Login.CDatos.DProductos;
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
        Producto producto = new Producto();

        public void CargarGrid(DataGridView dgv)
        {
            var Lst = dProductos.Read();
            dgv.DataSource = Lst;
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
            producto.id_categorias = idCat;
            producto.id_marcas = idMarca;
            producto.nombre = nombre;
            producto.descripcion = descripcion;
            producto.precio = precio;
            producto.stock = stock;

            if (dProductos.Create(producto))
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
