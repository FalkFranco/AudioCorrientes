using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DVentas
{
    internal class DDetalleVenta
    {
        dbAudioCorrientesEntities db;

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

        public bool mostrarDetalleVentas(DataGridView dgv ,int id)
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
    }

}
