using System;
using System.Collections.Generic;
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


    }
}
