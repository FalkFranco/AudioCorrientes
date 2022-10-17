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
        }

        public void CargarGridDni(DataGridView dgv, String dni)
        {
            var Lst = datos.buscardni(dni);
            dgv.DataSource = Lst;
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



    }
}
