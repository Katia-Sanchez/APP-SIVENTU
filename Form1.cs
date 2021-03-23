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
    public partial class presentacion : Form
    {
        public presentacion()
        {
            InitializeComponent();
        }

        private void btAcces_Click(object sender, EventArgs e)
        {
            InicioDeSeccion FormRegister = new InicioDeSeccion();
            FormRegister.Show();
            this.Hide();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
