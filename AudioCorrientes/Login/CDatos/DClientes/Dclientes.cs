using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login.CDatos
{
    internal class Dclientes
    {

        dbAudioCorrientesEntities db;

        public bool Create(Cliente pCliente)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Clientes.Add(pCliente);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EditarCliente(Cliente pCliente)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Entry(pCliente).State = System.Data.Entity.EntityState.Modified;
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

        public bool EliminarCliente(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    
                    db.Clientes.Remove(db.Clientes.Single(p => p.id_cliente == pId));
                    //db.Clientes.Remove(db.Clientes.Single(p => p.id_tipoCliente == pId));
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

        public List<Cliente> Read()
        {
            try
            {
                using(db = new dbAudioCorrientesEntities())
                {
                    return db.Clientes.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Cliente> buscardni(string pDni)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Clientes.Where(p=>p.dni.Contains(pDni)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Cliente> buscarNombre(string pNombre)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Clientes.Where(p=>p.nombre.Contains(pNombre)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Cliente> Buscar(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Clientes.Where(p => p.id_cliente == pId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool mostrarClientes(DataGridView dgv, bool estado)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Clientes
                                      where q.estado == estado
                                      select new
                                      {
                                          Id = q.id_cliente,
                                          Dni = q.dni,
                                          Nombre = q.nombre,
                                          Apellido = q.apellido,
                                          Telefono = q.telefono,
                                          Direccion = q.direccion,
                                          Email = q.email,
                                          TipoCliente = q.TipoCliente.tipo,
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

        public bool mostrarClientesNombre(DataGridView dgv, String pBuscador, bool estado)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Clientes
                                      where q.apellido.Contains(pBuscador) && q.estado == estado
                                      select new
                                      {
                                          Id = q.id_cliente,
                                          Dni = q.dni,
                                          Nombre = q.nombre,
                                          Apellido = q.apellido,
                                          Telefono = q.telefono,
                                          Direccion = q.direccion,
                                          Email = q.email,
                                          TipoCliente = q.TipoCliente.tipo
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

        public bool mostrarClientesDni(DataGridView dgv, String pBuscador, bool estado)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Clientes
                                      where q.dni.Contains(pBuscador) && q.estado == estado
                                      select new
                                      {
                                          Id = q.id_cliente,
                                          Dni = q.dni,
                                          Nombre = q.nombre,
                                          Apellido = q.apellido,
                                          Telefono = q.telefono,
                                          Direccion = q.direccion,
                                          Email = q.email,
                                          TipoCliente = q.TipoCliente.tipo
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

        public int cantClientes()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Clientes select q.id_cliente);
                    return objMostrar.Count();
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
