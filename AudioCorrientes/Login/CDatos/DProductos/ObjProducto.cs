using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.CDatos.DProductos
{
    public class ObjProducto
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public bool estado { get; set; }
    }
}
