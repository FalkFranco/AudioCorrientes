using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DEmpleados
{
    internal class DEmpleados
    {
        dbAudioCorrientesEntities db;


        public bool Create(Empleado pEmpleado)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Empleados.Add(pEmpleado);
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

        public bool EditarEmpleado(Empleado pEmpleado)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Entry(pEmpleado).State = System.Data.Entity.EntityState.Modified;
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

        public List<Empleado> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Empleados.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Empleado> Buscardni(string pDni)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Empleados.Where(p => p.dni.Contains(pDni)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Empleado> BuscarNombre(string pNombre)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Empleados.Where(p => p.nombre.Contains(pNombre)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Empleado> Buscar(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Empleados.Where(p => p.id_empleado == pId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool mostrarEmpleados(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Empleados
                                      where q.activo == true
                                      select new
                                      {
                                          Nombre = q.nombre,
                                          //Nombre = q.Empleado.apellido + ' ' + q.Empleado.nombre,
                                          Apellido = q.apellido,
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
