using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos
{
    internal class DtipoCliente
    {
        AudioCorrientesEntities db;

        public List<TipoCliente> Read()
        {
            try
            {
                using (db = new AudioCorrientesEntities())
                {
                    return db.TipoClientes.ToList();
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
