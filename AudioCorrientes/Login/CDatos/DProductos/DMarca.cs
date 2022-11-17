using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DProductos
{
    internal class DMarca
    {
        dbAudioCorrientesEntities db;

        public List<Marca> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Marcas.ToList();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool mostrarMarca(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Marcas
                                      //where q.estado == true
                                      select new
                                      {
                                          Id = q.id_marcas,
                                          Marca = q.marca_descripcion,
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
        public bool mostrarMarcaNombre(DataGridView dgv, String pNombre)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Marcas
                                      where q.marca_descripcion.Contains(pNombre)
                                      select new
                                      {
                                          Id = q.id_marcas,
                                          Marca = q.marca_descripcion,
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
