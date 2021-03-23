using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class RegistroDeEmpleados : Form
    {
        public RegistroDeEmpleados()
        {
            InitializeComponent();
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtTelefono.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            //limpieza
            txtNombre2.Text = "";
            txtContra2.Text = "";
            txtConfirmacion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

        private void BtSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMini3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            InicioDeSeccion FormRegister = new InicioDeSeccion();
            FormRegister.Show();
            this.Hide();
        }

        private void btIngresar2_Click(object sender, EventArgs e)
        {
            MenuTotal FormRegister = new MenuTotal();
            FormRegister.Show();
            this.Hide();
        }
    }
}
