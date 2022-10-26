using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CDatos.DUsuarios;
using Login.CSuAdministrador.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CNegocio
{
    internal class NUsuario
    {
        DUsuarios datos = new DUsuarios();
        DRol roldatos = new DRol();
        Usuario usuario = new Usuario();

        public void CargarGrid(DataGridView dgv)
        {
            var Lst = datos.Read();
            dgv.DataSource = Lst;
            OrdenDgv(dgv);
        }

        public void OrdenDgv(DataGridView dgv)
        {
            dgv.Columns["id_usuario"].DisplayIndex = 0;
            dgv.Columns["empleado_id"].DisplayIndex = 1;
            dgv.Columns["usuario1"].DisplayIndex = 2;
            dgv.Columns["contrasena"].DisplayIndex = 3;
            dgv.Columns["rol_id"].DisplayIndex = 4;
            dgv.Columns["activo"].DisplayIndex = 5;
            //dgv.Columns["Editar"].DisplayIndex = 6;
            //dgv.Columns["Eliminar"].DisplayIndex = 7;
        }

        public void OcultarColumnas(DataGridView dgv)
        {
            dgv.Columns["Empleado"].Visible = false;
            dgv.Columns["Role"].Visible = false;
        }

        public void CargarGridUsuario(DataGridView dgv, String usuario)
        {
            var Lst = datos.BuscarUsuario(usuario);
            dgv.DataSource = Lst;
        }

        public bool AgregarUsuario(int id_empleado, string nombreUsuario, string password, int rol)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            usuario.empleado_id = id_empleado;
            usuario.usuario1 = nombreUsuario;
            usuario.contrasena = password;
            usuario.rol_id = rol;
            usuario.activo = true;
            
            if (datos.Create(usuario))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CargarFormEditar(int pId, TextBox id, TextBox id_empleado, TextBox nombreUsuario, TextBox password, ComboBox rol, CheckBox activo)
        {
            var Lst = datos.Buscar(pId);
            if (Lst.Count > 0)
            {
                foreach (Usuario usuario in Lst)
                {
                    id.Text = usuario.id_usuario.ToString();
                    id_empleado.Text = usuario.empleado_id.ToString();
                    nombreUsuario.Text = usuario.usuario1;
                    password.Text = usuario.contrasena;
                    CargarComboBoxEditar(rol, usuario.rol_id);
                    activo.Checked = (bool)usuario.activo;
                }
            }
        }
        public void CargarComboBoxRol(ComboBox cb)
        {
            var Lst = roldatos.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "rol"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_rol"; //El valor que se va almacenar es el id 


                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        public void CargarComboBoxEditar(ComboBox cb, int id)
        {
            var Lst = roldatos.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "rol"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_rol"; //El valor que se va almacenar es el id 
                cb.SelectedValue = id;

                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        public bool EditarUsuario(int id, int id_empleado, string nombreUsuario, string password, int rol, bool activo)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            usuario.id_usuario = id;
            usuario.empleado_id = id_empleado;
            usuario.usuario1 = nombreUsuario;
            usuario.contrasena = password;
            usuario.rol_id = rol;
            usuario.activo = activo;

            if (datos.EditarUsuario(usuario))
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
