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
    }
}
