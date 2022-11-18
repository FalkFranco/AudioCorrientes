using System;

namespace Login
{
    public class ObjVenta
    {
        public int VentaId { get; set; }
        public string ClienteName { get; set; }
        public string VendedorName { get; set; }
        public DateTime fechaVenta { get; set; }
        
        public Decimal Total { get; set; }
    }
}
