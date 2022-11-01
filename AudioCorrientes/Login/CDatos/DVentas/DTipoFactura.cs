using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DVentas
{
    internal class DTipoFactura
    {
        dbAudioCorrientesEntities db;

        public List<TipoFactura> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.TipoFacturas.ToList();
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
