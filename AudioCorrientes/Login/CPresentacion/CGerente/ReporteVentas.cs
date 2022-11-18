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
            lbdias.Text = "Días";
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
                Fecha.Add(DateTime.Now.Day);
                Total.Add(dr.GetDouble(1));
            }
            //chartVentas.Series[0].Points.DataBindXY(Total, Fecha);
            chartVentas.Series[0].Points.DataBindXY(Fecha, Total);
            dr.Close();
            conexion.Close();
        }
        public void semestres(String semestre)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Meses = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand(semestre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Meses.Add(dr.GetInt32(0));
                Cant.Add(dr.GetDecimal(1));
            }
            chartVentas.Series[0].Points.DataBindXY(Meses, Cant);
            dr.Close();
            conexion.Close();
        }

        public void GetVentasMeses(DateTime Fecha)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlParameter param = new SqlParameter();
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("VentaMesesCustom", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            param.ParameterName = "@Fecha";
            param.Value = Fecha;
           
            cmd.Parameters.Add(param);


            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetInt32(0));
                Cant.Add(dr.GetDecimal(1));
            }
            chartVentas.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            semestres("GetVentasS1");
            lbdias.Text = "Meses";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetVentasMeses(DateTime.Now);
            lbdias.Text = "Días";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            semestres("GetVentasYear");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetVentasMeses(dateTimePicker1.Value);
            //MessageBox.Show(dateTimePicker1.Value.ToString());
            lbdias.Text = "Días";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            semestres("GetVentasS2");
            lbdias.Text = "Meses";
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            VentasDia("GetVentasDia");
            lbFecha.Text= (DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
        }

    }
}
