using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.CDatos
{
    public abstract class ConexionSQL
    {
        protected SqlConnection GetConnection()
        {
            return new SqlConnection("Server=(local); Database=AudioCorientes; integrated security=true");
        }
    }
}
