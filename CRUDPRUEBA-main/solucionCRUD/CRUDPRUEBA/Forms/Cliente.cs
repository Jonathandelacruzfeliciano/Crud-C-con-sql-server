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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            

            Agredarcliente cliente = new Agredarcliente();
            cliente.cedula = txtcedula.Text;
            cliente.nombre = txtnombre.Text;
            cliente.apellido = txtapellido.Text;
            cliente.ocupacion = txtocupacion.Text;
            cliente.sexo = comsexo.Text;


          int resultado = agregarcliente.agregar(cliente);
            if( resultado > 0 )
            {
                MessageBox.Show("Datos Guardado correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Guardar los datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            limpiar limpiar = new limpiar();
            limpiar.limiarpampos(this);

        }
       


        private void Cliente_Load(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
        }
        
        private void validarcompos()
        {
            var vr = !string.IsNullOrEmpty(txtcedula.Text) &&
                !string.IsNullOrEmpty(txtnombre.Text) &&
                !string.IsNullOrEmpty(txtapellido.Text)&&
                !string.IsNullOrEmpty(txtocupacion.Text)&&
                !string.IsNullOrEmpty(comsexo.Text);


            btnguardar.Enabled = vr;

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtocupacion_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void comsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            consultar pconsultar = new consultar();
            pconsultar.ShowDialog();
        }
    }
}
