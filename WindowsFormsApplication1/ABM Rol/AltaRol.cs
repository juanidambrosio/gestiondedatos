using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class AltaRol : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        private int pudoCrearRol = 0;
        public AltaRol()
        {
           
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaFuncionalidades", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Funcion");
            adapter.Fill(dt);
            this.lstFuncionalidades.DataSource = dt;
            this.lstFuncionalidades.DisplayMember = "Descripcion";

            lstFuncionalidades.ValueMember = lstFuncionalidades.DisplayMember;
            lstFuncElegidas.Items.Clear();
            lstFuncElegidas.SelectedIndex = 0;
            
           
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
            if (string.IsNullOrEmpty(txtNuevoRol.Text)) 
            {
                MessageBox.Show("Debe completar el campo del nuevo Rol", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.AltaRol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = txtNuevoRol.Text;
            cmd.ExecuteNonQuery();
            pudoCrearRol = 1;
            if (pudoCrearRol == 1)
            {
                for (int i = 0; i < lstFuncElegidas.Items.Count - 1; i++)
                {
                    cmd = new SqlCommand("ROAD_TO_PROYECTO.AsignarFuncionARol", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rol", SqlDbType.NVarChar).Value = txtNuevoRol.Text;
                    cmd.Parameters.AddWithValue("@Funcion", SqlDbType.NVarChar).Value = lstFuncElegidas.Items[i].ToString();
                    cmd.ExecuteNonQuery();

                }
                pudoCrearRol = 0;
                this.borrarTodo();

            }
           
          

        }

        private void lstFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFuncElegidas.Items.Add(lstFuncionalidades.SelectedValue.ToString());
        }

        private void borrarTodo() 
        {
            txtNuevoRol.Text = "";
            lstFuncElegidas.Items.Clear();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            this.borrarTodo();
        }

     
    }
}
