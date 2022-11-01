﻿using Login.CDatos.DProductos;
using Login.CDatos.DVentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CNegocio
{
    internal class NVentas
    {
        DTipoFactura dTipoFactura = new DTipoFactura();



        public void CargarComboBoxTipoFactura(ComboBox cb)
        {
            var Lst = dTipoFactura.Read();
            if (Lst.Count > 0) //Si la lista no esta vacia
            {
                cb.DataSource = Lst;
                cb.DisplayMember = "tipo"; //Aparece el nombre del tipo en las opciones
                cb.ValueMember = "id_tipoFactura"; //El valor que se va almacenar es el id 


                cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
    }
}
