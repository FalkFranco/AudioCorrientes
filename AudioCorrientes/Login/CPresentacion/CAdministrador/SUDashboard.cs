using Login.CDatos;
using Login.CNegocio;
using Login.CPresentacion;
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

namespace Login.CSuAdministrador
{
    public partial class SUDashboard : Form
    {
        NVentas nVentas = new NVentas();
        NCliente nCliente = new NCliente();
        NProductos nProductos = new NProductos();
        public SUDashboard()
        {
            InitializeComponent();
        }

        private void SUDashboard_Load(object sender, EventArgs e)
        {
            lbTotVentasNro.Text =nVentas.cantVentas().ToString();
            lbCantClientes.Text = nCliente.cantClientes().ToString();
            lbCantProductos.Text = nProductos.cantProductos().ToString();
            nProductos.cargarStockBajo(dgvBajoStock);
            top5();
            topCategorias();
            //lbtotven.Text = GanTot().ToString();
            lbtotven.Text= GanTot();
        }




        

        public void top5()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Nombre = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("Top5Prod", conexion);
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

        public void topCategorias()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Cat = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("TopCat", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cat.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            chartCategorias.Series[0].Points.DataBindXY(Cat, Cant);
            dr.Close();
            conexion.Close();
        }

        public String GanTot()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            ArrayList Tot = new ArrayList();
            ArrayList Cant = new ArrayList();

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
            cmd = new SqlCommand("SELECT Convert(Decimal,SUM(subtotal)) FROM DetalleVenta dv\r\n\tINNER JOIN Ventas vn\r\n\tON dv.id_ventas = vn.id_ventas", conexion);
            //cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            String tot = cmd.ExecuteScalar().ToString();
            //String Total = cmd.ExecuteReader()[0].ToString();
            //String tot = cmd.ExecuteReader();


            conexion.Close();
            return tot;
        }

    }
}
