using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class CambiarContrasenia : Form
    {
        public CambiarContrasenia()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasenia.Text) || string.IsNullOrEmpty(txtRepetir.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if(this.txtContrasenia.Text != this.txtRepetir.Text)
            {
                MessageBox.Show("Las contrasenias no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtContrasenia.Text = "";
                txtRepetir.Text = "";
                return;
            }
           
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
