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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (txtcontraseña.Text == txtcontraseña.Text)
            {
                if (UsuarioRegis.CrerRegistro(txtusuario.Text, txtcontraseña.Text) > 0)
                {
                    MessageBox.Show("Registro Creado con exito");
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("No se pude crear un Registro");


            }

        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            btncrearregistro.Enabled = false;
        }

        private void validarcompos()
        {
            var vr = !string.IsNullOrEmpty(txtusuario.Text) &&
                !string.IsNullOrEmpty(txtconfcontraseña.Text) &&
                !string.IsNullOrEmpty(txtcontraseña.Text);


            btncrearregistro.Enabled = vr;

        }
        
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtconfcontraseña_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
