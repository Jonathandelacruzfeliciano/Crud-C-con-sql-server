using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPRUEBA.Models
{
    public class Clientee
    {
        public int ClienteID { get; set; }
        public int IdUser { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ocupacion { get; set; }
        public string Sexo { get; set; }
    }
}
