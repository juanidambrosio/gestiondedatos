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
    public partial class Login : Form
    {
        public static Login lg;
        public Login()
        {
            InitializeComponent();
            Login.lg = this;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Hide();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtContrasenia.Clear();
            txtUsuario.Clear();
            this.timer1.Stop();
            this.toolStripProgressBar1.Value = 0;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
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
            this.toolStripProgressBar1.Increment(1);
            //this.progressBar1.Increment(1);
            if (this.toolStripProgressBar1.Value == toolStripProgressBar1.Maximum )
            {
                this.toolStripProgressBar1.Value = 0;
                
                Form1.f1.lblUsuario.Text = this.txtUsuario.Text;
                Form1.f1.Show();
                this.timer1.Stop();
                
                this.Hide();
                //MOSTRAR LOS DATOS EN LOS RBUTTON
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.Show();
            this.Hide();
            
        }

        private void cmdCambiarContrasenia_Click(object sender, EventArgs e)
        {
            CambiarContrasenia cambioContrasenia = new CambiarContrasenia();
            cambioContrasenia.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
