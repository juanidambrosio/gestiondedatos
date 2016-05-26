﻿using System;
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
            Login.lg.Show();
            this.Hide();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";
            string cadenaDeErrorContrasenias = "Las contrasenias no coinciden";
            int huboError = 0;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                cadenaDeErrores += " Usuario \r";
                huboError++;
            }
            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                cadenaDeErrores += " Contrasenia \r";
                huboError++;
            }


            if(string.IsNullOrEmpty(txtRepetir.Text))
            {
                cadenaDeErrores += " Repetir la contrasenia \r";
                huboError++;
            }
          
            if (huboError != 0)
            {
                MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                huboError = 0;
                return;
            }
           
            if(this.txtContrasenia.Text != this.txtRepetir.Text)
            {
                MessageBox.Show(cadenaDeErrorContrasenias, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtContrasenia.Text = "";
                txtRepetir.Text = "";
                return;
            }

            Login.lg.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
