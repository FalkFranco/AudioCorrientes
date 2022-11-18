using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.CDatos.DProductos
{
    public class Ventas
    {
        public int VentaId { get; set; }
        public string ClienteName { get; set; }
        public string VendedorName { get; set; }
        public DateTime fechaVenta { get; set; }
        public Decimal Total { get; set; }
    }
}
