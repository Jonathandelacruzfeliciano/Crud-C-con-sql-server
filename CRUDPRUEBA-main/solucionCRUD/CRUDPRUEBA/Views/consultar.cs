using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDPRUEBA
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            conexion.Open();

            string consultar = "Select * From empleado where Cedula= " + txtcedula + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consultar, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            conexion.Open();
                                 
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
           
        }
    }
}
