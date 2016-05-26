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
    public partial class ModificacionUsuario : Form
    {
        public ModificacionUsuario()
        {
            InitializeComponent();
        }

        private void ModificacionUsuario_Load(object sender, EventArgs e)
        {
            
            rbNombreCliente.Visible = false;
            rbApellidoCliente.Visible = false;
            rbMailCliente.Visible = false;
            rbDNI.Visible = false;        
                          
            rbRazonEmpresa.Visible = false;
            rbCUITEmpresa.Visible = false;
            rbEmail.Visible = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cboSeleccion.SelectedItem.ToString() == "Cliente")
            {
                rbNombreCliente.Visible = true;
                rbApellidoCliente.Visible = true;
                rbMailCliente.Visible = true;
                rbDNI.Visible = true;

                rbRazonEmpresa.Visible = false;
                rbCUITEmpresa.Visible = false;
                rbEmail.Visible = false;
            }
            if(cboSeleccion.SelectedItem.ToString() == "Empresa")
            {
                rbRazonEmpresa.Visible = true;
                rbCUITEmpresa.Visible = true;
                rbEmail.Visible = true;

                rbNombreCliente.Visible = false;
                rbApellidoCliente.Visible = false;
                rbMailCliente.Visible = false;
                rbDNI.Visible = false;
            }
            //FALTA EL FILTRADO
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            
            this.Hide();
            
        }

        private void cboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
