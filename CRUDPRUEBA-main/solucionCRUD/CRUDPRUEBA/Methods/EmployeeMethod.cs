using CRUDPRUEBA.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPRUEBA.Methods
{
    public class EmployeeMethod
    {
        public static List<Employee> GetAllEmployee()
        {
            SqlConnection conexion = BDComun.ObtnerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Select * From empleado"), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = int.Parse(reader["idempleado"].ToString());
                employee.IdUser = string.IsNullOrEmpty(reader["iduser"].ToString()) ? 0 : int.Parse(reader["iduser"].ToString());
                employee.Cedula = reader["cedula"].ToString();
                employee.Nombre = reader["nombre"].ToString();
                employee.Apellido = reader["apellido"].ToString();
                employee.Cargo = reader["cargo"].ToString();
                employee.TipoSangre = reader["tiposamgre"].ToString();

                employees.Add(employee);
            }

            conexion.Close();

            return employees;
        }

        public static int SaveEmployee(Employee employee)
        {
            int result = 0;
            using (SqlConnection Conexion = BDComun.ObtnerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert into empleado (nombre, apellido,cedula, cargo, sexo) values ('{0}', '{1}', '{2}', '{3}','{4}')",
                    employee.Nombre, employee.Apellido, employee.Cedula, employee.Cargo, employee.Sexo), Conexion);

                result = Comando.ExecuteNonQuery();
            }

            return result;
        }
    }
}
