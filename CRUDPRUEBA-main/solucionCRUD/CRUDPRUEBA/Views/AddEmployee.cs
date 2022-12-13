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

namespace CRUDPRUEBA.Views
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)

        {
            
            Employee employee = new Employee();

            employee.Nombre = txtnombre.Text;
            employee.Apellido = txtapellido.Text;
            employee.Cedula= txtcedula.Text;
            employee.Cargo = txtCargo.Text;
            employee.Sexo = comsexo.SelectedIndex == 0 ? "Masculino" : "Femenino";

            var res = EmployeeMethod.SaveEmployee(employee);

            if (res > 0)
            {
                MessageBox.Show("Empleado registrado con exito!!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
        }

        private void validarcompos()
        {
            var vr = !string.IsNullOrEmpty(txtcedula.Text) &&
                !string.IsNullOrEmpty(txtnombre.Text) &&
                !string.IsNullOrEmpty(txtapellido.Text) &&
                !string.IsNullOrEmpty(txtCargo.Text) &&
                !string.IsNullOrEmpty(comsexo.Text);


            btnguardar.Enabled = vr;

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            validarcompos();
        }

        private void comsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcompos();
        }
    }
}
