using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdIngresarUsuario_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Usuario.Login login = new WindowsFormsApplication1.ABM_Usuario.Login();
            login.Show();
            this.Hide();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdModificarUsuario_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario mdUsuario = new WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario();
            mdUsuario.Show();
            this.Hide();
        }
    }
}
