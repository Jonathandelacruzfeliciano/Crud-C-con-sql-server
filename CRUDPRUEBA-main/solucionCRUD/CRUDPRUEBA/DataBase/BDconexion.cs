using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUDPRUEBA
{
    public class BDComun
    {
        public static SqlConnection ObtnerConexion()
        {
            SqlConnection Conexion = new SqlConnection("server=LAPTOP-KQH2TR9E; database=CRUDVENTA; integrated security=true");
            Conexion.Open();

            return Conexion;

        }
    }
}
