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
        dbAudioCorrientesEntities1 db;

        public List<TipoCliente> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities1())
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
        //public void LlenarCombo(ComboBox comboBox)
        //{
        //    using(db = new AudioCorrientesEntities())
        //    {
        //        var Lst = db.TipoClientes.ToList();
        //        if (Lst.Count > 0)
        //        {
        //            comboBox.DisplayMember = "tipo";
        //            comboBox.ValueMember = "id_tipoCliente";
        //            comboBox.DataSource = Lst;

        //            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        //            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        //        }
        //    }
            
        //}

    }
}
