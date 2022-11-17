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
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }


        public void GetTopProductosEntre(DateTime Desde, DateTime Hasta)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlParameter param = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("GetTopProductosEntre", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            param.ParameterName = "@Desde";
            param.Value = Desde;
            param2.ParameterName = "@Hasta";
            param2.Value = Hasta;
            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            chartTop5.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }
        public void GetTopMarcasEntre(DateTime Desde, DateTime Hasta)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlParameter param = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("GetTopMarcasEntre", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            param.ParameterName = "@Desde";
            param.Value = Desde;
            param2.ParameterName = "@Hasta";
            param2.Value = Hasta;
            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            ChatTopMarcas.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }
        public void GetTopCategoriasEntre(DateTime Desde, DateTime Hasta)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlParameter param = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("GetTopCategoriasEntre", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            param.ParameterName = "@Desde";
            param.Value = Desde;
            param2.ParameterName = "@Hasta";
            param2.Value = Hasta;
            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            ChatTopCat.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }
        public void GetTopProductosYear()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("GetProductosAño", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            chartTop5.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }
        public void GetTopCategoriasYear()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("GetCategoriasAño", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            ChatTopCat.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }
        public void GetTopMarcasYear()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("GetMarcasAño", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            ChatTopMarcas.Series[0].Points.DataBindXY(Nombre, Cant);
            dr.Close();
            conexion.Close();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            dtpDesde.MaxDate = DateTime.Now.AddDays(-1);
            dtpHasta.MaxDate = DateTime.Now;
            GetTopProductosEntre(DateTime.Now.AddDays(-1), DateTime.Now);
            GetTopMarcasEntre(DateTime.Now.AddDays(-1), DateTime.Now);
            GetTopCategoriasEntre(DateTime.Now.AddDays(-1), DateTime.Now);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            GetTopProductosEntre(dtpDesde.Value, dtpHasta.Value);
            GetTopMarcasEntre(dtpDesde.Value, dtpHasta.Value);
            GetTopCategoriasEntre(dtpDesde.Value, dtpHasta.Value);
        }
        private void btnSemana_Click(object sender, EventArgs e)
        {
            GetTopProductosEntre(DateTime.Now.AddDays(-7), DateTime.Now);
            GetTopMarcasEntre(DateTime.Now.AddDays(-7), DateTime.Now);
            GetTopCategoriasEntre(DateTime.Now.AddDays(-7), DateTime.Now);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            GetTopProductosEntre(DateTime.Now.AddDays(-30), DateTime.Now);
            GetTopMarcasEntre(DateTime.Now.AddDays(-30), DateTime.Now);
            GetTopCategoriasEntre(DateTime.Now.AddDays(-30), DateTime.Now);
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            GetTopProductosYear();
            GetTopCategoriasYear();
            GetTopMarcasYear();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            GetTopProductosEntre(DateTime.Now.AddDays(-1), DateTime.Now);
            GetTopMarcasEntre(DateTime.Now.AddDays(-1), DateTime.Now);
            GetTopCategoriasEntre(DateTime.Now.AddDays(-1), DateTime.Now);
        }
    }
}
