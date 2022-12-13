using CRUDPRUEBA.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDPRUEBA.Methods
{
    public class ClienteeMethod
    { 

    public static List<Clientee> GetAllClientee()
    {
        SqlConnection conexion = BDComun.ObtnerConexion();

        SqlCommand comando = new SqlCommand(string.Format("Select * From cliente"), conexion);

        SqlDataReader reader = comando.ExecuteReader();

        List<Clientee> clientes = new List<Clientee>();

        while (reader.Read())
        {
            Clientee clientee = new Clientee();
            clientee.ClienteID = int.Parse(reader["idcliente"].ToString());
            clientee.IdUser = string.IsNullOrEmpty(reader["iduser"].ToString()) ? 0 : int.Parse(reader["iduser"].ToString());
            clientee.Cedula = reader["cedula"].ToString();
            clientee.Nombre = reader["nombre"].ToString();
            clientee.Apellido = reader["apellido"].ToString();
            clientee.Ocupacion = reader["ocupacion"].ToString();
            clientee.Sexo = reader["sexo"].ToString();

            clientes.Add(clientee);
        }

        conexion.Close();

        return clientes;
      }

        public static int SaveClientee(Clientee clientee)
        {
                 int result = 0;
             using (SqlConnection Conexion = BDComun.ObtnerConexion())
             {
                 SqlCommand Comando = new SqlCommand(string.Format("Insert into cliente (cedula, nombre, apellido, ocupacion, sexo) values ('{0}', '{1}', '{2}', '{3}','{4}')",
                     clientee.Cedula, clientee.Nombre, clientee.Apellido, clientee.Ocupacion, clientee.Sexo), Conexion);

                 result = Comando.ExecuteNonQuery();
             }

              return result;

        }

    }
}



