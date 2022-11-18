using Dapper;
using DevExpress.XtraEditors;
using Login.CDatos.DVentas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CPresentacion.CVendedor
{
    public partial class Facturaciones : XtraForm
    {
        DVenta dVenta = new DVenta();
        DDetalleVenta dDetalle = new DDetalleVenta();
        public Facturaciones()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)

                    db.Open();
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Desde";
                param.Value = dtDesde.EditValue;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Hasta";
                param2.Value = dtHasta.EditValue;


                string query = "SELECT dv.id_ventas, CONCAT(cl.apellido, ' ' , cl.nombre) AS Cliente, CONCAT(em.apellido, ' ' , em.nombre)" +
                             " AS Vendedor,vn.fecha,vn.total FROM DetalleVenta dv INNER JOIN Ventas vn ON dv.id_ventas = vn.id_ventas  INNER JOIN Empleados " +
                            "em ON vn.id_empleado = em.id_empleado INNER JOIN Clientes cl ON vn.id_cliente = cl.id_cliente where vn.fecha BETWEEN convert(varchar(25)," + dtDesde.EditValue.ToString() + ",110) and convert(varchar(25)," + dtHasta.EditValue.ToString() + ",110) " +
                            " group by dv.id_ventas, CONCAT(cl.apellido, ' ' , cl.nombre), CONCAT(em.apellido, ' ' , em.nombre),vn.fecha,vn.total";

                objVentaBindingSource.DataSource = db.Query<ObjVenta>(query, commandType: CommandType.Text);
            }
        }

        private void btnCargar_Click1(object sender, EventArgs e)
        {
            dVenta.mostrarVentasIMP(gridControl1);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)

                    db.Open();
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Desde";
                param.Value = dtDesde.EditValue;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Hasta";
                param2.Value = dtHasta.EditValue;


                string query = "SELECT dv.id_ventas, pr.nombre, dv.cantidad,dv.precioVenta,CONVERT(DECIMAL,dv.subtotal) FROM DetalleVenta dv" +
                    "INNER JOIN Ventas vn ON dv.id_ventas = vn.id_ventas INNER JOIN Productos pr ON dv.id_productos = pr.id_productos where dv.id_ventas = 17";
                List<DetallePedido> list = db.Query<DetallePedido>(query, commandType: CommandType.Text).ToList();
                using (Factura factura = new Factura())
                {
                    //factura.PrintInvoice.()
                }
            }
        }
    }
}
