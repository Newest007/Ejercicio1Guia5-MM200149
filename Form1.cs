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

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtapellido, "");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if(validarCampos())
            {
                if (dateTimePicker1.Value.Year > System.DateTime.Now.Year)
                {
                    MessageBox.Show("Prueba con un año anterior al presente", "Al parecer vienes del futuro :O");
                    //Application.Restart();
                }
                else
                {
                    MessageBox.Show("Sus datos se han ingresado correctamente", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

            DateTime fechanacimiento = dateTimePicker1.Value;
            int años = System.DateTime.Now.Year - fechanacimiento.Year;

            if (System.DateTime.Now.Subtract(fechanacimiento.AddYears(años)).TotalDays < 0)
                txtedad.Text = Convert.ToString(años - 1);
            else
                txtedad.Text = Convert.ToString(años);

            if (años < 0)
            {
                txtedad.Clear();

            }

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtnombre, "Debe de ingresar su nombre, no un Nick");
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtapellido, "Debe de ingresar su apellido, no un Nick");
            }
        }
    }
}
