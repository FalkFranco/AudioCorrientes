using Login.CDatos;
using Login.CDatos.DEmpleados;
using Login.CSuAdministrador.Clientes;
using Login.CSuAdministrador.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login.CNegocio
{
    internal class NEmpleado
    {
        DEmpleados datos = new DEmpleados();
        Empleado empleado = new Empleado();

        public void CargarGrid(DataGridView dgv)
        {
            var Lst = datos.Read();
            dgv.DataSource = Lst;
            OrdenDgv(dgv);
        }

        public void OrdenDgv(DataGridView dgv)
        {
            dgv.Columns["Id"].DisplayIndex = 0;
            dgv.Columns["DNI"].DisplayIndex = 1;
            dgv.Columns["Nombre"].DisplayIndex = 2;
            dgv.Columns["Apellido"].DisplayIndex = 3;
            dgv.Columns["FechaIngreso"].DisplayIndex = 4;
            dgv.Columns["Editar"].DisplayIndex = 5;
            dgv.Columns["Eliminar"].DisplayIndex = 6;
            dgv.Columns["Activar"].DisplayIndex = 7;
        }
        public void OcultarColumnas(DataGridView dgv)
        {
            dgv.Columns["Activar"].Visible = false;
            dgv.Columns["Usuarios"].Visible = false;
            dgv.Columns["Ventas"].Visible = false;
        }
        public void OcultarColumnasSuAdmin(DataGridView dgv)
        {
            dgv.Columns["telefono"].Visible = false;
            dgv.Columns["direccion"].Visible = false;
            dgv.Columns["activo"].Visible = false;
            dgv.Columns["fechaIngreso"].Visible = false;
            dgv.Columns["fechaNac"].Visible = false;
            dgv.Columns["email"].Visible = false;
            dgv.Columns["Editar"].Visible = false;
            dgv.Columns["Eliminar"].Visible = false;
            dgv.Columns["Usuarios"].Visible = false;
            dgv.Columns["Ventas"].Visible = false;
        }
        public void CargarGridDni(DataGridView dgv, String dni)
        {
            var Lst = datos.Buscardni(dni);
            dgv.DataSource = Lst;
        }

        public void CargarGridNom(DataGridView dgv, String nombre)
        {
            var Lst = datos.BuscarNombre(nombre);
            dgv.DataSource = Lst;
        }

        public bool AgregarEmpleado(string dni, string nombre, string apellido, string tel, string direc, string email, DateTime fechaIngreso, DateTime fechaNac)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            empleado.dni = dni;
            empleado.nombre = nombre;
            empleado.apellido = apellido;
            empleado.telefono = tel;
            empleado.direccion = direc;
            empleado.activo = true;
            empleado.fechaIngreso = fechaIngreso;
            empleado.fechaNac = fechaNac;
            empleado.email = email;

            if (datos.Create(empleado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void CargarFormEditar(int pId, TextBox id, TextBox dni, TextBox nom, TextBox ape, TextBox tel, TextBox direc, TextBox email, DateTimePicker fechaIngreso, DateTimePicker fechaNac, CheckBox activo)
        {
            var Lst = datos.Buscar(pId);
            if (Lst.Count > 0)
            {
                foreach (Empleado empleado in Lst)
                {
                    id.Text = empleado.id_empleado.ToString();
                    dni.Text = empleado.dni;
                    nom.Text = empleado.nombre;
                    ape.Text = empleado.apellido;
                    tel.Text = empleado.telefono;
                    direc.Text = empleado.direccion;
                    fechaIngreso.Value = empleado.fechaIngreso;
                    fechaNac.Value = empleado.fechaNac;
                    email.Text = empleado.email;
                    activo.Checked = empleado.activo;
                }
            }
        }

        public void CargarFormUsuario(int pId, TextBox id, TextBox dni, TextBox nom, TextBox ape, TextBox email)
        {
            var Lst = datos.Buscar(pId);
            if (Lst.Count > 0)
            {
                foreach (Empleado empleado in Lst)
                {
                    id.Text = empleado.id_empleado.ToString();
                    dni.Text = empleado.dni;
                    nom.Text = empleado.nombre;
                    ape.Text = empleado.apellido;
                    email.Text = empleado.email;
                }
            }
        }

        public bool EditarEmpleado(int id, string dni, string nombre, string apellido, string tel, string direc, string email, DateTime fechaIngreso, DateTime fechaNac, bool activo)
        {
            //int idTipoInt = Int32.Parse(idTipo);//De string a int para poder almacenar en la base de datos
            empleado.id_empleado = id;
            empleado.dni = dni;
            empleado.nombre = nombre;
            empleado.apellido = apellido;
            empleado.telefono = tel;
            empleado.direccion = direc;
            empleado.fechaIngreso = fechaIngreso;
            empleado.fechaNac = fechaNac;
            empleado.email = email;
            empleado.activo = activo;
            

            if (datos.EditarEmpleado(empleado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cargarDtosEmpleados(DataGridView dgv)
        {
            datos.mostrarEmpleados(dgv);
            dgv.Columns["Id"].Visible = false;
            OrdenDgv(dgv);
        }
        public void cargarDtosEmpleadosA(DataGridView dgv)
        {
            datos.mostrarEmpleadosA(dgv);
            dgv.Columns["Id"].Visible = false;
            OrdenDgv(dgv);
        }
        public void cargarDtosEmpleadosEliminados(DataGridView dgv)
        {
            datos.mostrarEmpleadosEliminados(dgv);
            dgv.Columns["Id"].Visible = false;
            //OrdenDgv(dgv);
        }
        public void cargarDtosEmpleadosEliminadosA(DataGridView dgv)
        {
            datos.mostrarEmpleadosEliminadosA(dgv);
            dgv.Columns["Id"].Visible = false;
            //OrdenDgv(dgv);
        }

        public void cargarDatosEmpleadosDNI(DataGridView dgv,String pDni, bool estado)
        {
            datos.mostrarEmpleadosDni(dgv, pDni,estado);
            dgv.Columns["Id"].Visible = false;
            OrdenDgv(dgv);
        }
        public void cargarDatosEmpleadosNombre(DataGridView dgv, String pNombre, bool estado)
        {
            datos.mostrarEmpleadosNombre(dgv, pNombre,estado);
            dgv.Columns["Id"].Visible = false;
            OrdenDgv(dgv);
        }

        public void cargarDatosEmpleadosDNIA(DataGridView dgv, String pDni)
        {
            datos.mostrarEmpleadosDniA(dgv, pDni);
            dgv.Columns["Id"].Visible = false;
            OrdenDgv(dgv);
        }
        public void cargarDatosEmpleadosNombreA(DataGridView dgv, String pNombre)
        {
            datos.mostrarEmpleadosNombreA(dgv, pNombre);
            dgv.Columns["Id"].Visible = false;
            OrdenDgv(dgv);
        }


    }
}
