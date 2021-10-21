using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1___Guía5_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validarCampos()
        {
            bool validado = true;
            if(txtnombre.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtnombre, "Ingresar Nombre");
            }

            if(txtapellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtapellido, "Ingresar Apellido");
            }

            return validado;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
