using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using Login.CPresentacion.CVendedor;

namespace Login.CDatos.DVentas
{
    internal class DDetalleVenta
    {
        dbAudioCorrientesEntities db;
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        public bool Create(DetalleVenta pDetalleVenta)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.DetalleVentas.Add(pDetalleVenta);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EditarProducto(DetalleVenta pDetalleVenta)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Entry(pDetalleVenta).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Eliminar Producto

        public List<DetalleVenta> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.DetalleVentas.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //public List<Venta> BuscarFecha(string pNombre)
        //{
        //    try
        //    {
        //        using (db = new dbAudioCorrientesEntities())
        //        {
        //            return db.Productos.Where(p => p.nombre.Contains(pNombre)).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}

        public List<DetalleVenta> Buscar(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.DetalleVentas.Where(p => p.id_ventas == pId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public bool mostrarDetalleVentas(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.DetalleVentas
                                      select new
                                      {
                                          DetalleNro = q.id_detalleVenta,
                                          IdVenta = q.id_ventas,
                                          IdProducto = q.id_productos,
                                          Producto = q.Producto.nombre,
                                          PrecioVenta = q.Producto.precio,
                                          Cantidad = q.cantidad,
                                          Subtotal = q.subtotal
                                      }).ToList();
                    dgv.DataSource = objMostrar;

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //public List<T> mostrarDetallesIMP()
        //{
        //    try
        //    {
        //        using (db = new dbAudioCorrientesEntities())
        //        {
        //            var objMostrar = (from q in db.DetalleVentas
        //                              select new
        //                              {
        //                                  IdVenta = q.id_ventas,
        //                                  Producto = q.Producto.nombre,
        //                                  Cantidad = q.cantidad,
        //                                  PrecioVenta = q.Producto.precio,
        //                                  Subtotal = q.subtotal
        //                              }).ToList();

        //            DetallePedido detallePedido = new DetallePedido();

        //            foreach(var i in objMostrar)
        //            {
        //                detallePedido.VentaId = i.IdVenta;
        //                detallePedido.NombreProducto = i.Producto;
        //                detallePedido.Cantidad = i.Cantidad;
        //                detallePedido.PrecioUnitario = Convert.ToDecimal(i.PrecioVenta);
        //                detallePedido.Total = Convert.ToDecimal(i.Subtotal);
        //            }
                    
        //            return objMostrar;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }

        //}

        //public bool mostrarProductosNoListados(DataGridView dgv)
        //{
        //    try
        //    {
        //        using (db = new dbAudioCorrientesEntities())
        //        {
        //            var objMostrar = (from q in db.Ventas
        //                              where q.estado == false
        //                              select new
        //                              {
        //                                  Id = q.id_ventas,
        //                                  TipoFacura = q.TipoFactura.tipo,
        //                                  Fecha = q.fecha,
        //                                  Cliente = q.Cliente.apellido + ' ' + q.Cliente.nombre,
        //                                  Empleado = q.Empleado.apellido + ' ' + q.Empleado.nombre,
        //                                  Total = q.total,
        //                                  Estado = q.estado
        //                              }).ToList();
        //            dgv.DataSource = objMostrar;

        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }

        //}

        //public bool mostrarProductosFecha(DataGridView dgv, DateTime fecha)
        //{
        //    try
        //    {
        //        using (db = new dbAudioCorrientesEntities())
        //        {
        //            var objMostrar = (from q in db.Ventas
        //                              where q.fecha.Contains(fecha)
        //                              select new
        //                              {
        //                                  Id = q.id_productos,
        //                                  Categoria = q.Categoria.categoria_descripcion,
        //                                  Marca = q.Marca.marca_descripcion,
        //                                  Nombre = q.nombre,
        //                                  Descripcion = q.descripcion,
        //                                  Precio = q.precio,
        //                                  Stock = q.stock,
        //                                  Estado = q.estado
        //                              }).ToList();
        //            dgv.DataSource = objMostrar;

        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }

        //}

        public bool mostrarDetalleVentas(DataGridView dgv, int id)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.DetalleVentas
                                      where q.id_ventas == id
                                      select new
                                      {
                                          DetalleNro = q.id_detalleVenta,
                                          IdVenta = q.id_ventas,
                                          IdProducto = q.id_productos,
                                          Producto = q.Producto.nombre,
                                          PrecioVenta = q.Producto.precio,
                                          Cantidad = q.cantidad,
                                          Subtotal = q.subtotal
                                      }).ToList();
                    dgv.DataSource = objMostrar;

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //public DataSet top5()
        //{
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        using (conexion)
        //        {
        //            conexion.Open();
        //            Console.WriteLine("The database has been opened!");
        //            using (var command = new SqlCommand())
        //            {
        //                command.Connection = con;
        //                command.CommandText = @"SELECT * from Top5";
        //                //var top = command.ExecuteReader();
        //                var adapter = new SqlDataAdapter(command);
        //                adapter.Fill(ds);
        //            }


        //            return ds;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return ds;
        //    }

        //}
        ArrayList graf = new ArrayList();
        ArrayList Nombre = new ArrayList();
        ArrayList Cant = new ArrayList();
        public ArrayList top5()
        {
            cmd = new SqlCommand("Top5Prod", conexion);
            cmd.CommandType= CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            graf.Add(Nombre);
            graf.Add(Cant);
            dr.Close();
            conexion.Close();
            return graf;
        }


    }

}
