using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DProductos
{
    internal class DProductos
    {
        dbAudioCorrientesEntities db;

        public bool Create(Producto pProducto)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Productos.Add(pProducto);
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

        public bool EditarProducto(Producto pProducto)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Entry(pProducto).State = System.Data.Entity.EntityState.Modified;
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

        public List<Producto> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Productos.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Producto> BuscarNombre(string pNombre)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Productos.Where(p => p.nombre.Contains(pNombre)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Producto> Buscar(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Productos.Where(p => p.id_productos == pId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public bool mostrarProductos(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Productos
                                      where q.estado == true
                                      select new
                                      {
                                          Id = q.id_productos,
                                          Categoria = q.Categoria.categoria_descripcion,
                                          Marca = q.Marca.marca_descripcion,
                                          Nombre = q.nombre,
                                          Descripcion = q.descripcion,
                                          Precio = q.precio,
                                          Stock = q.stock,
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
                    var objMostrar = (from q in db.Productos
                                      where q.estado != true
                                      select new
                                      {
                                          Id = q.id_productos,
                                          Categoria = q.Categoria.categoria_descripcion,
                                          Marca = q.Marca.marca_descripcion,
                                          Nombre = q.nombre,
                                          Descripcion = q.descripcion,
                                          Precio = q.precio,
                                          Stock = q.stock,
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

        public bool mostrarProductosNombre(DataGridView dgv, String pNombre)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Productos
                                      where q.nombre.Contains(pNombre)
                                      select new
                                      {
                                          Id = q.id_productos,
                                          Categoria = q.Categoria.categoria_descripcion,
                                          Marca = q.Marca.marca_descripcion,
                                          Nombre = q.nombre,
                                          Descripcion = q.descripcion,
                                          Precio = q.precio,
                                          Stock = q.stock,
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


        public bool ActualizarStock(int idProducto, int cantidad)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var producto = (from q in db.Productos
                                    where q.id_productos == idProducto
                                    select q).First();
                    var nuevo = producto.stock - cantidad;
                    producto.stock = nuevo;
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

        public int cantProductos()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Productos select q.id_productos);
                    return objMostrar.Count();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        public bool mostrarProductosStockBajo(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Productos
                                      where q.stock < 5
                                      select new
                                      {
                                          Id = q.id_productos,
                                          Categoria = q.Categoria.categoria_descripcion,
                                          Marca = q.Marca.marca_descripcion,
                                          Nombre = q.nombre,
                                          Descripcion = q.descripcion,
                                          Precio = q.precio,
                                          Stock = q.stock,
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
    }
}

