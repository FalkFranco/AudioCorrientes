﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CDatos.DProductos
{
    internal class DProductos
    {
        dbAudioCorrientesEntities db;

        public bool Create(Producto pProducto)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    db.Productos.Add(pProducto);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Producto> Read()
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Productos.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //public List<Producto> buscarId(string pId)
        //{
        //    try
        //    {
        //        using (db = new dbAudioCorrientesEntities())
        //        {
        //            //return db.Productos.Where(p => p.id_productos.Contains(pId)).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}
        public List<Producto> BuscarNombre(string pNombre)
        {
            try
            {
                using (db = new dbAudioCorrientesEntities())
                {
                    return db.Productos.Where(p => p.nombre.Contains(pNombre)).ToList();
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
