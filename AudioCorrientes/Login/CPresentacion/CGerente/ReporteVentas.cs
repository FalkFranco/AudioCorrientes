using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CGerente
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentasDia("GetVentasDia");
        }

        public void VentasDia(String nomProc)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Fecha = new ArrayList();
            ArrayList Total = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand(nomProc, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Fecha.Add(dr.GetDateTime(0));
                Total.Add(dr.GetDouble(1));
            }
            //chartVentas.Series[0].Points.DataBindXY(Total, Fecha);
            chartVentas.Series[0].Points.DataBindXY(Fecha, Total);
            dr.Close();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentasDia("GetVentasSemana");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentasDia("GetVentasMes");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentasDia("GetVentasAño");
        }
    }
}
