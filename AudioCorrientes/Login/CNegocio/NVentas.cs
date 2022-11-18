using Login.CDatos;
using Login.CDatos.DProductos;
using Login.CDatos.DVentas;
using Login.CSuAdministrador;
using Login.CSuAdministrador.Productos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        public void cargarVentas(DataGridView dgv, int idEmpleado)
        {
            dVenta.mostrarVentas(dgv, idEmpleado);
        }

        public void cargarVentasFechas(DataGridView dgv, int idEmpleado,DateTime Desde, DateTime Hasta)
        {
            dVenta.mostrarVentasFechas(dgv, idEmpleado,Desde, Hasta);
        }

        public void cargarDetalles(DataGridView dgv,int idVenta)
        {
            dDetalleVenta.mostrarDetalleVentas(dgv, idVenta);
        }

        public int cantVentas()
        {
            return dVenta.cantVentas();
        }

        public ArrayList top5()
        {
            return dDetalleVenta.top5();
        }


        public void cargarVentaHoy(DataGridView dgv)
        {
            dVenta.mostrarVentasHoy(dgv);
        }

        public void cargarVentasSemana(DataGridView dgv)
        {
            dVenta.mostrarVentasSemana(dgv);
        }

        public void cargarVentasMes(DataGridView dgv)
        {
            dVenta.mostrarVentasMes(dgv);
        }

        public void cargarVentasYear(DataGridView dgv)
        {
            dVenta.mostrarVentasYear(dgv);
        }

        public void cargarVentasEntre(DataGridView dgv, DateTime Desde, DateTime Hasta)
        {
            dVenta.mostrarVentasEntre(dgv, Desde, Hasta);

        }


        public ArrayList VentasDia()
        {
            return dVenta.VentasDia();
        }

    }
}


