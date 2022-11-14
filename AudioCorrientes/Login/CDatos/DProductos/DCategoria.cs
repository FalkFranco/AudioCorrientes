using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DProductos
{
    internal class DCategoria
    {
        dbAudioCorrientesEntities db;

        public List<Categoria> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Categorias.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool mostrarCategorias(DataGridView dgv)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    var objMostrar = (from q in db.Categorias
                                          //where q.estado == true
                                      select new
                                      {
                                          Id = q.id_categorias,
                                          Marca = q.categoria_descripcion,
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
