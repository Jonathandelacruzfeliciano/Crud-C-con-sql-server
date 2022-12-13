using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDPRUEBA
{
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = agregarcliente.BuscarCliente(txtcedula.Text, txtnombre.Text);
        }
    }
}
