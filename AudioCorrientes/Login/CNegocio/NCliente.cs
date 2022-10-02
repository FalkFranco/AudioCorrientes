using Login.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void ocultarColumnas(DataGridView dgv)
        {
            dgv.Columns["TipoCliente"].Visible = false;
            //dgv.Columns["idTipoCliente"].Visible = false;
        }
    }
}
