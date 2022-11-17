using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DUsuarios
{
    internal class DUsuarios
    {
        dbAudioCorrientesEntities db;

        public bool Create(Usuario pUsuario)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Usuarios.Add(pUsuario);
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

        public bool EditarUsuario(Usuario pUsuario)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Entry(pUsuario).State = System.Data.Entity.EntityState.Modified;
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

        public List<Usuario> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Usuarios.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Usuario> BuscarUsuario(string pUsuario)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Usuarios.Where(p => p.usuario1.Contains(pUsuario)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public List<Usuario> Buscar(int pId)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Usuarios.Where(p => p.id_usuario == pId).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Usuario> ValidarUsuario(string pNombreUsuario, string pPass)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Usuarios.Where(p => p.usuario1 == pNombreUsuario && p.contrasena == pPass).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        
        public bool mostrarUsuarios(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Usuarios
                                      where q.activo == true 
                                      select new
                                      {
                                          IdEmpleado = q.empleado_id,
                                          Id = q.id_usuario,
                                          Nombre = q.Empleado.nombre,
                                          Apellido = q.Empleado.apellido,
                                          Usuario = q.usuario1,
                                          Password = q.contrasena,
                                          Rol = q.Role.rol,
                                          Activo = q.activo
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

        public bool mostrarUsuariosEliminados(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Usuarios
                                      where q.activo != true && q.Empleado.activo == true
                                      select new
                                      {
                                          IdEmpleado = q.empleado_id,
                                          Id = q.id_usuario,
                                          Nombre = q.Empleado.nombre,
                                          Apellido = q.Empleado.apellido,
                                          Usuario = q.usuario1,
                                          Password = q.contrasena,
                                          Rol = q.Role.rol,
                                          Activo = q.activo
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
