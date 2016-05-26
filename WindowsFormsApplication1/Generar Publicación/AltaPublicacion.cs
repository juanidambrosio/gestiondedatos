using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class AltaPublicacion : Form
    {
        public static AltaPublicacion ap1;
        public AltaPublicacion()
        {
            InitializeComponent();
            AltaPublicacion.ap1 = this;
        }

        private void lblValorSubasta_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdRubro_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rubro.AltaRubro arubro = new WindowsFormsApplication1.ABM_Rubro.AltaRubro();
            arubro.Show();
            this.Hide();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AltaPublicacion_Load(object sender, EventArgs e)
        {
            lblDescripcion.Visible = false;
            lblRubro.Visible = false;
            lblRubroSe.Visible = false;
            chkPreguntas.Visible = false;
            dtpFin.Visible = false;          
            cmdRubro.Visible = false;
            txtDescripcion.Visible = false;
            lblFin.Visible = false;

            lblValorSubasta.Visible = false;
            txtValorSubasta.Visible = false;

            lblStockInmediata.Visible = false;
            txtStockInmediata.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem.ToString() == "Subasta")
            {
                lblDescripcion.Visible = true;
                lblRubro.Visible = true;
                lblRubroSe.Visible = true;
                chkPreguntas.Visible = true;
                dtpFin.Visible = true;
                cmdRubro.Visible = true;
                txtDescripcion.Visible = true;
                lblFin.Visible = true;

                lblValorSubasta.Visible = true;
                txtValorSubasta.Visible = true;

                lblStockInmediata.Visible = false;
                txtStockInmediata.Visible = false;

            }

            if (cboTipo.SelectedItem.ToString() == "Compra inmediata")
            {
                lblDescripcion.Visible = true;
                lblRubro.Visible = true;
                lblRubroSe.Visible = true;
                chkPreguntas.Visible = true;
                dtpFin.Visible = true;
                cmdRubro.Visible = true;
                txtDescripcion.Visible = true;
                lblFin.Visible = true;

                lblValorSubasta.Visible = false;
                txtValorSubasta.Visible = false;

                lblStockInmediata.Visible = true;
                txtStockInmediata.Visible = true;
            }

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }
    }
}
