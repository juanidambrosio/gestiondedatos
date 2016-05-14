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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtContrasenia.Clear();
            txtUsuario.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || 
                string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Debe completar la informacion","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                
            
             return;
            }
            //if (txtUsuario.Text ESTA EN LA BDD && txtContrasenia.Text ESTA EN LA BDD){

            this.timer1.Start();   
             
             // }
             // else
             //{
            // MessageBox.Show("Informacion incorrecta del usuario","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);   
             //}
             //
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                this.timer1.Stop();
                //MOSTRAR LOS DATOS EN LOS RBUTTON
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }

    }
}