using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos
{
    internal class SQLConexion
    {
        string connetionString = "Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True";
        SqlConnection con = new SqlConnection();

        //string cadenaConexion = "Data Source=" + servidor + "," + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";


        public SqlConnection abrir()
        {

            try
            {
                con.ConnectionString = connetionString;
                con.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");

            }
            catch (SqlException e)
            {

                MessageBox.Show("No se logró conectar a la Base de Datos" + e.ToString());
            }

            return con;
        }
    }
}
