using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DVentas
{
    internal class DVenta
    {
        dbAudioCorrientesEntities db;

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


        public bool mostrarVentas(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Ventas
                                      where q.estado == true
                                      select new
                                      {
                                          Id = q.id_ventas,
                                          //TipoFacura = q.TipoFactura.tipo,
                                          Fecha = q.fecha,
                                          Cliente = q.Cliente.apellido,
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
    }
}
