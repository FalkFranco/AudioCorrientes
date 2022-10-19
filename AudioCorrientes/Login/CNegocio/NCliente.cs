using Login.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Login.CNegocio
{
    internal class NCliente
    {
        Dclientes datos = new Dclientes();
        DtipoCliente tcDatos = new DtipoCliente();
        Cliente cliente = new Cliente();

        public void CargarGrid(DataGridView dgv)
        {
            var Lst = datos.Read();
            dgv.DataSource = Lst;
            OrdenDgv(dgv);
        }

        public void OrdenDgv(DataGridView dgv)
        {
            dgv.Columns["id_cliente"].DisplayIndex = 0;
            dgv.Columns["dni"].DisplayIndex = 1;
            dgv.Columns["nombre"].DisplayIndex = 2;
            dgv.Columns["apellido"].DisplayIndex = 3;
            dgv.Columns["telefono"].DisplayIndex = 4;
            dgv.Columns["direccion"].DisplayIndex = 5;
            dgv.Columns["email"].DisplayIndex = 6;
            dgv.Columns["id_tipoCliente"].DisplayIndex = 7;
            dgv.Columns["Editar"].DisplayIndex = 8;
            dgv.Columns["Eliminar"].DisplayIndex = 9;
        }


        public void CargarGridDni(DataGridView dgv, String dni)
        {
            var Lst = datos.buscardni(dni);
            dgv.DataSource = Lst;
        }

        public void EliminarCliente(int Id)
        {
            datos.EliminarCliente(Id);
        }

        public void CargarGridNom(DataGridView dgv, String nombre)
        {
            var Lst = datos.buscarNombre(nombre);
            dgv.DataSource = Lst;
        }


        public void ocultarColumnas(DataGridView dgv)
        {
            dgv.Columns["TipoCliente"].Visible = false;
            dgv.Columns["Ventas"].Visible = false;
        }

        public void CargarComboBox(ComboBox cb)
        {
            var Lst = tcDatos.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "tipo"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_tipoCliente"; //El valor que se va almacenar es el id 


                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        public bool AgregarCliente(string dni, string nombre, string apellido, string tel, string direc, string email, int idTipo)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            cliente.dni = dni;
            cliente.nombre = nombre;
            cliente.apellido = apellido;
            cliente.telefono = tel;
            cliente.direccion = direc;
            cliente.email = email;
            cliente.id_tipoCliente = idTipo;

            if (datos.Create(cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CargarFormEditar(int pId,TextBox id, TextBox dni, TextBox nom, TextBox ape, TextBox tel, TextBox direc, TextBox email, ComboBox tipoCliente)
        {
            var Lst = datos.Buscar(pId);
            if (Lst.Count > 0)
            {
                foreach (Cliente cliente in Lst)
                {
                    id.Text = cliente.id_cliente.ToString();
                    dni.Text = cliente.dni;
                    nom.Text = cliente.nombre;
                    ape.Text = cliente.apellido;
                    tel.Text = cliente.telefono;
                    direc.Text = cliente.direccion;
                    email.Text = cliente.email;
                    CargarComboBoxEditar(tipoCliente, cliente.id_tipoCliente);
                }
            }
        }

        public void CargarComboBoxEditar(ComboBox cb, int id)
        {
            var Lst = tcDatos.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "tipo"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_tipoCliente"; //El valor que se va almacenar es el id 
                cb.SelectedValue = id;

                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;

                
            }
        }

        public bool EditarCliente(int id ,string dni, string nombre, string apellido, string tel, string direc, string email, int idTipo)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            cliente.id_cliente = id;
            cliente.dni = dni;
            cliente.nombre = nombre;
            cliente.apellido = apellido;
            cliente.telefono = tel;
            cliente.direccion = direc;
            cliente.email = email;
            cliente.id_tipoCliente = idTipo;

            if (datos.EditarCliente(cliente))
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
