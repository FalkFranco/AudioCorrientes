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
    }
}
