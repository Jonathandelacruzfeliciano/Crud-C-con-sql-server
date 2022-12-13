using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUDPRUEBA
{
    class UsuarioRegis
    {
        public static int CrerRegistro(string pusuario, string pcontraseña)
        {
            int resultado = 0;
            SqlConnection Conexion = BDComun.ObtnerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into usuario (usuario, contraseña) values ('{0}', '{1}')", pusuario, pcontraseña), Conexion);

            resultado = Comando.ExecuteNonQuery();
            Conexion.Close();

            return resultado;
        }

        public static int Autenticar(String pusuario, String pcontraseña)
        {
            int resultado = -1;

            SqlConnection conexion = BDComun.ObtnerConexion();

            SqlCommand comando = new SqlCommand(string.Format(
                "Select * From usuario Where usuario = '{0}' and contraseña = '{1}'", pusuario, pcontraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }

            conexion.Close();
            return resultado;
        }
    }
}
