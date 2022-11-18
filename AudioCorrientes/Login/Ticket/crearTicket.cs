using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Login.CDatos;
using DevExpress.Utils.Extensions;
using Login.CPresentacion.CVendedor;

namespace Login.Ticket
{
    internal class crearTicket
    {
        public string empresa { get; set; }
        public string direccion { get; set; }
        public Image logo { get; set; }

        public List<DetallePedido> listaProductos = new List<DetallePedido>();
        public List<CabeceraDetalle> listaCabecera = new List<CabeceraDetalle>();


        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();

        public void imprimir(crearTicket p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimirTicket);
            vista.Document = doc;
            doc.Print();
        }

        public void imprimirTicket(object sender, PrintPageEventArgs e)
        {
            int posX, posY;
            Font fuente = new Font("consola", 9, FontStyle.Bold);
            try
            {
                posX = 10;
                posY = 10;

                e.Graphics.DrawImage(logo,250,15);
                e.Graphics.DrawString(empresa, fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString(direccion, fuente, Brushes.Black, posX, posY);
                posY += 30;
                fuente = new Font("consola", 8, FontStyle.Regular);
                e.Graphics.DrawString("Cliente: "+ listaCabecera[0].Cliente + espaciar(45, 65) + "Empleado que lo atendió: "+ listaCabecera[0].Empleado, fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString("Factura Nro: " + listaCabecera[0].VentaId + espaciar(45,65) + "Fecha: " + listaCabecera[0].Fecha, fuente, Brushes.Black, posX, posY);
                posY += 50;
                
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("CANT.               PRODUCTO                 PRECIO          SUBTOTAL", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 20;
                
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    e.Graphics.DrawString(listaProductos[i].NombreProducto , fuente, Brushes.Black, posX, posY);
                    posY += 15;
                    e.Graphics.DrawString(listaProductos[i].Cantidad + espaciar(listaProductos[i].Cantidad.ToString().Count(), 65) + "$" + listaProductos[i].PrecioUnitario + espaciar(listaProductos[i].PrecioUnitario.ToString().Count(), 22) +"$"+ listaProductos[i].Total + " ", fuente, Brushes.Black, posX, posY);
                    posY += 30;
                }

                //e.Graphics.DrawString(listaProductos[0].NombreProducto + " " + listaProductos[0].Cantidad + " " + listaProductos[0].PrecioUnitario + " " + listaProductos[0].Total + " ", fuente, Brushes.Black, posX, posY);
                //posY += 30;
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("                                                                                                                        TOTAL: $" + listaCabecera[0].Total, fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 30;

                e.Graphics.DrawString("Gracias Por Su Compra....", fuente, Brushes.Black, posX, posY);
                posY += 30;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }

        }

        //public string espacios(int valor)
        //{

        //}

        public string espaciar(int tamam, int valor)
        {
            string espacio = "";
            int subvalor = 0;
            subvalor = valor - tamam;
            for(int i = 0; i < subvalor; i++)
            {
                espacio = espacio + " ";
            }
            return espacio;
        }
    }

}
