using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CDatos.DVentas;
using Login.CSuAdministrador;
using Login.CSuAdministrador.Productos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.CNegocio
{
    internal class NVentas
    {
        DVenta dVenta = new DVenta();
        DTipoFactura dTipoFactura = new DTipoFactura();
        DDetalleVenta dDetalleVenta = new DDetalleVenta();
        Venta venta = new Venta();
        DetalleVenta detalleVenta = new DetalleVenta();
        
        

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

        public int UltimaFactura()
        {
            return dVenta.UltimaFactura();
        }

        public bool AgregarFactura(int pIdTipoFactura,int idEmpleado, int idCliente, float total)
        {
            venta.id_tipoFactura = pIdTipoFactura;
            venta.fecha = DateTime.Now;
            venta.id_empleado = idEmpleado;
            venta.id_cliente = idCliente;
            venta.total = total;
            venta.estado = true;

            if (dVenta.Create(venta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarDetalleVenta(int idVenta, int idProducto, float precioVenta, int cantidad)
        {
            detalleVenta.id_ventas = idVenta;
            detalleVenta.id_productos = idProducto;
            detalleVenta.precioVenta = precioVenta;
            detalleVenta.cantidad = cantidad;
            detalleVenta.subtotal = precioVenta * cantidad;

            if (dDetalleVenta.Create(detalleVenta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


