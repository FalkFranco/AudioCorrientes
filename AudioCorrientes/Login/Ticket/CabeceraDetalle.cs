using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Ticket
{
    internal class CabeceraDetalle
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public Decimal Total { get; set; }
    }
}
