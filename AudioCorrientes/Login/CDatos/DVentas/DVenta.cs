using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace Login.CDatos.DVentas
{
    internal class DVenta
    {
        dbAudioCorrientesEntities db;
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-1DB3D6E\\SQLEXPRESS_INST2;Initial Catalog=AudioCorrientes;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public bool Create(Venta pventa)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Ventas.Add(pventa);
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

        public bool EditarProducto(Venta pVenta)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Entry(pVenta).State = System.Data.Entity.EntityState.Modified;
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

        public List<Venta> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Ventas.ToList();
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

        public List<Venta> Buscar(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Ventas.Where(p => p.id_ventas == pId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public bool mostrarVentas(DataGridView dgv, int idEmpleado)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Ventas
                                      where q.estado == true && q.Empleado.id_empleado == idEmpleado
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
                                          IdEmpleado = q.Empleado.id_empleado,
                                          Empleado = q.Empleado.apellido,
                                          Total = q.total,
                                          Estado = q.estado
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

        public bool mostrarVentasIMP(GridControl dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Ventas
                                      where q.estado == true 
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          Cliente = q.Cliente.apellido,
                                          Empleado = q.Empleado.apellido,
                                          Fecha = q.fecha,
                                          Total = q.total,
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

        public bool mostrarProductosNoListados(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Ventas
                                      where q.estado == false
                                      select new
                                      {
                                          Id = q.id_ventas,
                                          TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido + ' ' + q.Cliente.nombre,
                                          Empleado = q.Empleado.apellido + ' ' + q.Empleado.nombre,
                                          Total = q.total,
                                          Estado = q.estado
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

        public int UltimaFactura()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {

                    var qUltimo = (from q in db.Ventas select q.id_ventas).Max();
                    if(qUltimo < 1)
                    {
                        return 1;
                    }else
                    return qUltimo + 1;

                    //if (contador == 0)
                    //{
                    //    return 0;
                    //}
                    //else
                    //{
                    //    return qUltimo[contador - 1].id_tipoFactura;
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int cantVentas()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Ventas select q.id_ventas);
                    return objMostrar.Count();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }


        //public ArrayList top5()
        //{
        //    cmd = new SqlCommand("Top5Prod", conexion);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    conexion.Open();
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Nombre.Add(dr.GetString(0));
        //        Cant.Add(dr.GetInt32(1));
        //    }
        //    graf.Add(Nombre);
        //    graf.Add(Cant);
        //    dr.Close();
        //    conexion.Close();
        //    return graf;
        //}

        public bool mostrarVentasHoy(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Ventas
                                      where q.fecha == DateTime.Now
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
                                          IdEmpleado = q.Empleado.id_empleado,
                                          Empleado = q.Empleado.apellido,
                                          Total = q.total,
                                          Estado = q.estado
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

        public bool mostrarVentasSemana(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    DateTime FechaActual = DateTime.Now;
                    DateTime unaSemanaAntes = FechaActual.AddDays(-7);
                    var objMostrar = (from q in db.Ventas
                                      where q.fecha > unaSemanaAntes && q.fecha < FechaActual
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
                                          IdEmpleado = q.Empleado.id_empleado,
                                          Empleado = q.Empleado.apellido,
                                          Total = q.total,
                                          Estado = q.estado
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

        public bool mostrarVentasMes(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    DateTime FechaActual = DateTime.Now;
                    DateTime unaMesAntes = FechaActual.AddDays(-30);
                    var objMostrar = (from q in db.Ventas
                                      where q.fecha > unaMesAntes && q.fecha < FechaActual
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
                                          IdEmpleado = q.Empleado.id_empleado,
                                          Empleado = q.Empleado.apellido,
                                          Total = q.total,
                                          Estado = q.estado
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
        public bool mostrarVentasYear(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    int AñoActual = DateTime.Now.Year;
                    var objMostrar = (from q in db.Ventas
                                      where q.fecha.Year == AñoActual
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
                                          IdEmpleado = q.Empleado.id_empleado,
                                          Empleado = q.Empleado.apellido,
                                          Total = q.total,
                                          Estado = q.estado
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


        public bool mostrarVentasEntre(DataGridView dgv,DateTime Desde, DateTime Hasta)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    DateTime FechaActual = DateTime.Now;
                    DateTime unaMesAntes = FechaActual.AddDays(-30);
                    var objMostrar = (from q in db.Ventas
                                      where q.fecha >= Desde && q.fecha <= Hasta
                                      select new
                                      {
                                          NroFactura = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
                                          IdEmpleado = q.Empleado.id_empleado,
                                          Empleado = q.Empleado.apellido,
                                          Total = q.total,
                                          Estado = q.estado
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

        ArrayList graf = new ArrayList();
        ArrayList fecha = new ArrayList();
        ArrayList total = new ArrayList();

        public ArrayList VentasDia()
        {
            cmd = new SqlCommand("GetVentasDia", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fecha.Add(dr.GetString(0));
                total.Add(dr.GetInt32(1));
            }
            graf.Add(fecha);
            graf.Add(total);
            dr.Close();
            conexion.Close();
            return graf;
        }


    }
}
