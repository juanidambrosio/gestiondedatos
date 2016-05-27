using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.ABM_Rubro
{
    public partial class AltaRubro : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adapter;

        public AltaRubro()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2016;Persist Security Info=True;User ID=gd;Password=gd2016");
            cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaRubros", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Rubro");
            adapter.Fill(dt);
            this.cboRubro.DataSource = dt;
            this.cboRubro.DisplayMember = "DescripLarga";
            
            cboRubro.ValueMember = cboRubro.DisplayMember;
            cboRubro.SelectedIndex = -1;
            cboRubro.Text = "Seleccione un rubro";
            
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            if (cboRubro.SelectedIndex == -1)
            {
                WindowsFormsApplication1.Generar_Publicación.AltaPublicacion.ap1.lblRubroSe.Text = "";
            }
            WindowsFormsApplication1.Generar_Publicación.AltaPublicacion.ap1.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cboRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           WindowsFormsApplication1.Generar_Publicación.AltaPublicacion.ap1.lblRubroSe.Text = cboRubro.SelectedValue.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
            
        }     
    }
}
