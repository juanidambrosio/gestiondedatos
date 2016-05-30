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


namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class Form1 : Form
    {

        //SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;

        public Form1()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelComs.Visible = false;

            cmd = new SqlCommand("ROAD_TO_PROYECTO.Comisiones_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Visibilidad");
            adapter.Fill(dt);
            this.cboTipoVis.DataSource = dt;
            this.cboTipoVis.DisplayMember = "Descripcion";

            cboTipoVis.ValueMember = cboTipoVis.DisplayMember;
            cboTipoVis.SelectedIndex = -1;
            cboTipoVis.Text = "Seleccione un tipo de visibilidad";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEnvio.Visible = false;
            if (cboTipoVis.SelectedIndex != -1)
            {
                if (cboTipoVis.SelectedValue.ToString() == "Gratis")
                {
                    cbEnvio.Visible = false;
                }
                else
                {
                    cbEnvio.Visible = true;
                    cbEnvio.Checked = false;
                }
                panelComs.Visible = true;
                textBoxTipo.Enabled = false;
                textBoxProd.Enabled = false;

                cmd = new SqlCommand("ROAD_TO_PROYECTO.Comisiones_Valores", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Visibilidad", SqlDbType.NVarChar).Value = cboTipoVis.SelectedValue.ToString();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    textBoxTipo.Text = sdr["ComiFija"].ToString();
                    textBoxProd.Text = sdr["ComiVariable"].ToString();
                }
                sdr.Close();
            }
        }

        private void cbEnvio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnvio.Checked == false)
            {
                panelEnvio.Visible = false;
            } else 
            {
                panelEnvio.Visible = true;
            }
        }

        private void eliminarVisibilidad_Click(object sender, EventArgs e)
        {

        }

        private void cmdCrearVis_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.AgregarVisibilidad newVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.AgregarVisibilidad();
            newVisibilidad.Show();
            this.Hide();
        }

        private void cmdAceptarComisiones_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Generar_Publicación.AltaPublicacion.ap1.lblVisSel.Text = cboTipoVis.SelectedValue.ToString();
            WindowsFormsApplication1.Generar_Publicación.AltaPublicacion.ap1.Show();
            this.Hide();
        }

    }
}
