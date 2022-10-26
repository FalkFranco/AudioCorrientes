using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DUsuarios
{
    internal class DRol
    {

        dbAudioCorrientesEntities db;

        public List<Role> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Roles.ToList();
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
