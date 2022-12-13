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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btniniciarsesion.Enabled = false;
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (UsuarioRegis.Autenticar(txtusuario.Text, txtcontraseña.Text) > 0)
            {
                this.Hide();
                Menu f = new Menu();
                f.ShowDialog();
            }
            else
                MessageBox.Show("¡Usuario/Contraseña Incorrecto!"); Clean();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrar f = new Registrar();
            f.ShowDialog();
        }

        private void validarCampos()
        {
            var vr = !string.IsNullOrEmpty(txtusuario.Text) &&
                !string.IsNullOrEmpty(txtcontraseña.Text);
            btniniciarsesion.Enabled = vr;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clean()
        {
            txtusuario.Text = txtcontraseña.Text = String.Empty;
            txtusuario.Focus();
        }
    }
}