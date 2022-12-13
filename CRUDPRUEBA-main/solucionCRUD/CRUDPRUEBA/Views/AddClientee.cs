using CRUDPRUEBA.Methods;
using CRUDPRUEBA.Models;
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
            Clientee clientee = new Clientee();

            clientee.Cedula = txtcedula.Text;
            clientee.Nombre = txtnombre.Text;
            clientee.Apellido = txtapellido.Text;
            clientee.Ocupacion = txtocupacion.Text;
            clientee.Sexo = comsexo.SelectedIndex == 0 ? "M" : "F";

            var res = ClienteeMethod.SaveClientee(clientee);

            if (res > 0)
            {
                MessageBox.Show("Cliente registrado con exito!!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lo siento no fue registrado con exito!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.OK;
            }
            

        }



        private void Cliente_Load(object sender, EventArgs e)
        {


            btnguardar.Enabled = false;
        }

        private void validarcompos()
        {
            var vr = !string.IsNullOrEmpty(txtcedula.Text) &&
                !string.IsNullOrEmpty(txtnombre.Text) &&
                !string.IsNullOrEmpty(txtapellido.Text) &&
                !string.IsNullOrEmpty(txtocupacion.Text) &&
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
