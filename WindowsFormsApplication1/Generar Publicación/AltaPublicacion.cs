﻿using System;
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
        private int huboError = 0;
        public bool envioHabilitado;
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
            arubro.lblLlamada.Text = "1";
            arubro.Show();
            this.Hide();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == -1)
            {
                return;
            }
            if (cboTipo.SelectedItem.ToString() == "Subasta")
            {
                lblDescripcion.Visible = true;
                lblRubro.Visible = true;
               
               
                dtpFin.Visible = true;
                cmdRubro.Visible = true;
                txtDescripcion.Visible = true;
                lblFin.Visible = true;

                lblValorSubasta.Visible = true;
                txtValorSubasta.Visible = true;

                lblStockInmediata.Visible = false;
                txtStockInmediata.Visible = false;

                lblPrecio.Visible = false;
                txtPrecio.Visible = false;
                
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
               
                label8.Visible = true;

                lblVisibilidad.Visible = true;
                lblVisSel.Visible = true;
                cmdSelVis.Visible = true;

            }

            if (cboTipo.SelectedItem.ToString() == "Compra inmediata")
            {
                lblDescripcion.Visible = true;
                lblRubro.Visible = true;
                lblRubroSe.Visible = true;
             
                dtpFin.Visible = true;
                cmdRubro.Visible = true;
                txtDescripcion.Visible = true;
                lblFin.Visible = true;

                lblValorSubasta.Visible = false;
                txtValorSubasta.Visible = false;

                lblStockInmediata.Visible = true;
                txtStockInmediata.Visible = true;
                txtPrecio.Visible = true;
              
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lblPrecio.Visible = true;
                label8.Visible = true;

                lblVisibilidad.Visible = true;
                lblVisSel.Visible = true;
                cmdSelVis.Visible = true;
            }
            timer1.Start();
        }

        private void AltaPublicacion_Load(object sender, EventArgs e)
        {
            lblPrecio.Visible = false;
            txtPrecio.Visible = false;

            lblVisibilidad.Visible = false;
            lblVisSel.Visible = false;
            cmdSelVis.Visible = false;
            
            lblDescripcion.Visible = false;
            lblRubro.Visible = false;
            lblRubroSe.Visible = false;
           
            dtpFin.Visible = false;          
            cmdRubro.Visible = false;
            txtDescripcion.Visible = false;
            lblFin.Visible = false;

            lblValorSubasta.Visible = false;
            txtValorSubasta.Visible = false;

            lblStockInmediata.Visible = false;
            txtStockInmediata.Visible = false;
            label2.Visible = true;
            
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblPrecio.Visible = false;
            label8.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

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
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";
            string cadenaDeErrorTipo = "Debe seleccionar un tipo de publicacion";
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (cboTipo.SelectedItem.ToString() == "Compra inmediata")                                 
            {
                if(string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    cadenaDeErrores += " Descripcion \r";
                    huboError++;
                }

                if(string.IsNullOrEmpty(txtStockInmediata.Text))
                {
                    cadenaDeErrores += " Stock \r";
                    huboError++;
                }

                if(string.IsNullOrEmpty(lblRubroSe.Text))
                {
                    cadenaDeErrores += " Rubro \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(lblVisSel.Text))
                {
                    cadenaDeErrores += "Visibilidad \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    cadenaDeErrores += " Precio \r";
                    huboError++;
                }

                if (huboError != 0)
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                PublicacionDOA doa = new PublicacionDOA();
               // doa.crearPublicacion();

               
                
            }
            if (cboTipo.SelectedItem.ToString() == "Subasta")
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    cadenaDeErrores += " Descripcion \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(txtValorSubasta.Text))
                {
                    cadenaDeErrores += " Valor Inicial de la subasta \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(lblRubroSe.Text))
                {
                    cadenaDeErrores += " Rubro \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(lblVisSel.Text))
                {
                    cadenaDeErrores += "Visibilidad \r";
                    huboError++;
                }

                if (huboError != 0) 
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                PublicacionDOA doa = new PublicacionDOA();
                
                doa.crearPublicacion(txtDescripcion.Text, 1,dtpFin.Value,int.Parse(txtValorSubasta.Text),lblVisSel.Text,lblRubroSe.Text,cboTipo.SelectedItem.ToString(), lblUsername.Text, envioHabilitado);
            }     
            
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            lblRubroSe.Text = "";
            txtDescripcion.Text = "";
            txtStockInmediata.Text = "";
            txtValorSubasta.Text = "";
            txtPrecio.Text = "";
            
            
            cboTipo.SelectedIndex = -1;
            cboTipo.Text = "Seleccione un tipo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSelVis_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.Form1 setVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.Form1();
            setVisibilidad.Show();
            this.Hide();
        }
    }
}
