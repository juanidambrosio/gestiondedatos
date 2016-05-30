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
    public partial class AgregarVisibilidad : Form
    {

        SqlCommand cmd;
        SqlDataReader sdr;
        private DataBase db;

        public AgregarVisibilidad()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void cmdAceptarVis_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Agregar_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VisiId", SqlDbType.Int).Value = 20000;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
            cmd.Parameters.AddWithValue("@ComiFija", SqlDbType.Int).Value = tbComiFija.Text;
            cmd.Parameters.AddWithValue("@ComiVariable", SqlDbType.Int).Value = tbComiVariable.Text;
            cmd.ExecuteNonQuery();

            /*sdr = cmd.ExecuteReader();
            sdr.Close();*/

        }
    }
}
