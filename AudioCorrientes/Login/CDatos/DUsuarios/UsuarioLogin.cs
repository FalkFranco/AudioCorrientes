using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.CDatos.DUsuarios
{
    public class UsuarioLogin
    {

        public int id_usuario { get; set; }
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int rol { get; set; }
        public bool activo { get; set; }
    }
}
