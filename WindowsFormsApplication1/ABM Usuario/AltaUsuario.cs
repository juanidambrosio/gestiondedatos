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
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class AltaUsuario : Form
    {
        public static AltaUsuario aus;
        private int huboError = 0;
        //SqlConnection cnn;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;
        private DataBase db;

        public AltaUsuario()
        {

            db = DataBase.GetInstance(); 
            InitializeComponent();            
           
            AltaUsuario.aus = this;

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void cargarTipoDOC(ComboBox cboTipoDoc) 
        {
            cmd2 = new SqlCommand("ROAD_TO_PROYECTO.ListaTipoDOC", db.Connection);
            cmd2.CommandType = CommandType.StoredProcedure;
            adapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable("ROAD_TO_PROYECTO.Cliente");
            adapter2.Fill(dt2);
            this.cboTipoDoc.DataSource = dt2;
            this.cboTipoDoc.DisplayMember = "TipoDocumento";
            cboTipoDoc.ValueMember = cboTipoDoc.DisplayMember;
            cboTipoDoc.SelectedIndex = -1;
            cboTipoDoc.Text = "Seleccione un tipo de documento";
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaRoles", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Rol");
            adapter.Fill(dt);
            this.cboRoles.DataSource = dt;
            this.cboRoles.DisplayMember = "Nombre";
            cboRoles.ValueMember = cboRoles.DisplayMember;
            cboRoles.SelectedIndex = -1;
            cboRoles.Text = "Seleccione un tipo de Rol";


            this.dtpCreacion.Visible = false;
            this.cmdRubroEmpresa.Visible = false;
            this.lblRubroEmpresa.Visible = false;
            this.lblRubroSel.Visible = false;
            this.lblApellidoCliente.Visible = false;
            this.lblNombreCliente.Visible = false;
            this.lblFechaNacCliente.Visible = false;
            this.lblNroDocCliente.Visible = false;
            this.lblTelCliente.Visible = false;
            this.lblTipoDNICliente.Visible = false;
            this.lblFechaEmpresa.Visible = false;
            this.lblNombreEmpresa.Visible = false;
            this.lblRazonEmpresa.Visible = false;
            this.lblTelefonoEmpresa.Visible = false;
            this.lblCUITEmpresa.Visible = false;
            this.lblCalle.Visible = false;
            this.lblCodPos.Visible = false;
            this.lblDom.Visible = false;
            this.lblDpto.Visible = false;
            this.lblLocal.Visible = false;
            this.lblPiso.Visible = false;
            this.lblNum.Visible = false;
            this.txtApellidoCliente.Visible = false;
            this.txtDNICliente.Visible = false;
            this.txtNombreCliente.Visible = false;
            this.txtTelCliente.Visible = false;
            this.cboTipoDoc.Visible = false;
            this.txtCalle.Visible = false;
            this.txtCodPos.Visible = false;
            this.txtDpto.Visible = false;
            this.txtLocalidad.Visible = false;
            this.txtPiso.Visible = false;
            this.txtNumero.Visible = false;
            this.txtCUITEmpresa.Visible = false;
            this.txtNombreContEmpresa.Visible = false;
            this.txtRazonEmpresa.Visible = false;
            this.txtTelEmpresa.Visible = false;
           
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";
            string cadenaDeErrorTipo = "Debe seleccionar un tipo de Usuario";
            

            if(cboRoles.SelectedIndex == -1)
            {
                MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }


            if (this.cboRoles.SelectedValue.ToString() == "Cliente")
                   
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    cadenaDeErrores += " Usuario \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtPassword.Text))
                {
                    cadenaDeErrores += " Password \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtMail.Text))
                {
                    cadenaDeErrores += " Mail \r";
                    huboError++;
                }
                
                if(string.IsNullOrEmpty(txtApellidoCliente.Text))
                {
                    cadenaDeErrores += " Apellido \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtNombreCliente.Text))
                {
                    cadenaDeErrores += " Nombre \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtDNICliente.Text))
                {
                    cadenaDeErrores += " DNI \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtTelCliente.Text)) 
                {
                    cadenaDeErrores += " Telefono \r";
                    huboError++;
                }
                if (cboTipoDoc.SelectedIndex == -1)
                {
                    cadenaDeErrores += " Tipo Documento \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(txtCodPos.Text)) 
                {
                    cadenaDeErrores += " CodigoPostal \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtDpto.Text))
                {
                    cadenaDeErrores += " Departamento \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtLocalidad.Text)) 
                {
                    cadenaDeErrores += " Localidad \r"; 
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtPiso.Text))
                {
                    cadenaDeErrores += " Piso \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    cadenaDeErrores += " Numero \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtCalle.Text))
                 {
                    cadenaDeErrores += " Calle \r";
                    huboError++;
                }
                

                if (huboError != 0)
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    huboError = 0;
                    return;
                }

                string hash = this.encriptacion(txtPassword.Text);
                UsuarioDOA doa = new UsuarioDOA();
                doa.crearCliente("Cliente", txtUsuario.Text, hash, txtMail.Text, txtApellidoCliente.Text, txtNombreCliente.Text, int.Parse(txtDNICliente.Text), int.Parse(txtTelCliente.Text), cboTipoDoc.SelectedValue.ToString(), txtCodPos.Text, txtDpto.Text, txtLocalidad.Text, int.Parse(txtPiso.Text), int.Parse(txtNumero.Text), txtCalle.Text, dtpCreacion.Value);

                
            }
            if (this.cboRoles.SelectedValue.ToString() == "Empresa")
          
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    cadenaDeErrores += " Usuario \r";
                    huboError++;

                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    cadenaDeErrores += " Password \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtMail.Text))
                {
                    cadenaDeErrores += " Mail \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtCUITEmpresa.Text)) 
                {
                    cadenaDeErrores += " CUIT \r";
                    huboError++;
                }
                if(string.IsNullOrEmpty(txtNombreContEmpresa.Text)) 
                {
                    cadenaDeErrores += " Nombre de Contacto \r";
                    huboError++;
                }

                if(string.IsNullOrEmpty(txtRazonEmpresa.Text))
                {
                    cadenaDeErrores += " Razon Social \r";
                    huboError++;
                }
                       
                if(string.IsNullOrEmpty(txtTelEmpresa.Text))
                {
                    cadenaDeErrores += " Telefono \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtCodPos.Text)) 
                {
                    cadenaDeErrores += " CodigoPostal \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtDpto.Text))
                {
                    cadenaDeErrores += " Departamento \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtLocalidad.Text)) 
                {
                    cadenaDeErrores += " Localidad \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtPiso.Text))
                {
                    cadenaDeErrores += " Piso \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    cadenaDeErrores += " Numero \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(txtCalle.Text))
                {
                    cadenaDeErrores += " Calle \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(lblRubroSel.Text))
                {
                    cadenaDeErrores += "Rubro \r";
                    huboError++;
                }

                if (huboError != 0)
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    huboError = 0;
                    return;
                }


                string hash = this.encriptacion(txtPassword.Text);
                UsuarioDOA doa = new UsuarioDOA();
                
                doa.crearEmpresa("Empresa",txtUsuario.Text,hash,txtMail.Text,txtCUITEmpresa.Text,txtNombreContEmpresa.Text,txtRazonEmpresa.Text,int.Parse(txtTelEmpresa.Text),txtCodPos.Text,txtDpto.Text,txtLocalidad.Text,int.Parse(txtPiso.Text),int.Parse(txtNumero.Text),txtCalle.Text,dtpCreacion.Value,lblRubroSel.Text);
        
            }

         
        

          
           //GUARDAR LOS DATOS DE LOS txtUsuario txtContrasenia y demas en la BDD
          Login.lg.Show();
          this.Hide();

                
        }

        public string encriptacion(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            this.txtMail.Text = "";
            this.txtPassword.Text = "";
            this.txtUsuario.Text = "";

            this.txtCalle.Text = "";
            this.txtCodPos.Text = "";
            this.txtDpto.Text = "";
            this.txtLocalidad.Text = "";
            this.txtPiso.Text = "";
            this.txtNumero.Text = "";

            this.txtApellidoCliente.Text = "";
            this.txtDNICliente.Text = "";
            this.txtNombreCliente.Text = "";
            this.txtTelCliente.Text = "";
            this.cboTipoDoc.SelectedIndex = -1;

            this.txtCUITEmpresa.Text = "";
            this.txtNombreContEmpresa.Text = "";
            this.txtRazonEmpresa.Text = "";
            this.txtTelEmpresa.Text = "";
            this.cmdRubroEmpresa.Visible = false;
            this.lblRubroEmpresa.Visible = false;

            this.lblRubroSel.Text = "";
            

            this.dtpCreacion.Visible = false;


            cboRoles.SelectedIndex = -1;

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.lg.Show();
            this.Hide();

        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRubroEmpresa_Click(object sender, EventArgs e)
        {
            
            WindowsFormsApplication1.ABM_Rubro.AltaRubro arubro = new WindowsFormsApplication1.ABM_Rubro.AltaRubro();
            arubro.lblLlamada.Text = "0";
            
            arubro.Show();
            this.Hide();
        }

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboRoles.SelectedValue.ToString() == "Cliente")
            {
                this.lblApellidoCliente.Visible = true;
                this.lblNombreCliente.Visible = true;
                this.lblFechaNacCliente.Visible = true;
                this.lblNroDocCliente.Visible = true;
                this.lblTelCliente.Visible = true;
                this.lblTipoDNICliente.Visible = true;

                this.txtApellidoCliente.Visible = true;
                this.txtDNICliente.Visible = true;
                this.txtNombreCliente.Visible = true;
                this.txtTelCliente.Visible = true;
                this.cboTipoDoc.Visible = true;

                this.txtCUITEmpresa.Text = "";
                this.txtNombreContEmpresa.Text = "";
                this.txtRazonEmpresa.Text = "";
                this.txtTelEmpresa.Text = "";

                this.cmdRubroEmpresa.Visible = false;
                this.lblRubroEmpresa.Visible = false;
                this.lblRubroSel.Text = "";

                this.cargarTipoDOC(cboTipoDoc);



            }
            if (this.cboRoles.SelectedValue.ToString() == "Empresa")
            {
                this.lblFechaEmpresa.Visible = true;
                this.lblNombreEmpresa.Visible = true;
                this.lblRazonEmpresa.Visible = true;
                this.lblTelefonoEmpresa.Visible = true;
                this.lblCUITEmpresa.Visible = true;

                this.txtCUITEmpresa.Visible = true;
                this.txtNombreContEmpresa.Visible = true;
                this.txtRazonEmpresa.Visible = true;
                this.txtTelEmpresa.Visible = true;

                this.cmdRubroEmpresa.Visible = true;
                this.lblRubroEmpresa.Visible = true;
                this.lblRubroSel.Visible = true;


                this.txtApellidoCliente.Text = "";
                this.txtDNICliente.Text = "";
                this.txtNombreCliente.Text = "";
                this.txtTelCliente.Text = "";
                this.cboTipoDoc.SelectedIndex = -1;
                



            }

            if (this.cboRoles.SelectedValue.ToString() == "Cliente" || this.cboRoles.SelectedValue.ToString() == "Empresa")
            {
                this.lblCalle.Visible = true;
                this.lblCodPos.Visible = true;
                this.lblDom.Visible = true;
                this.lblDpto.Visible = true;
                this.lblLocal.Visible = true;
                this.lblPiso.Visible = true;
                this.lblNum.Visible = true;

                this.txtCalle.Visible = true;
                this.txtCodPos.Visible = true;
                this.txtDpto.Visible = true;
                this.txtLocalidad.Visible = true;
                this.txtPiso.Visible = true;
                this.txtNumero.Visible = true;
                this.dtpCreacion.Visible = true;

                this.dtpCreacion.Visible = true;
            }

            if (this.cboRoles.SelectedValue.ToString() != "Cliente")
            {
                this.lblApellidoCliente.Visible = false;
                this.lblNombreCliente.Visible = false;
                this.lblFechaNacCliente.Visible = false;
                this.lblNroDocCliente.Visible = false;
                this.lblTelCliente.Visible = false;
                this.lblTipoDNICliente.Visible = false;

                this.txtApellidoCliente.Visible = false;
                this.txtDNICliente.Visible = false;
                this.txtNombreCliente.Visible = false;
                this.txtTelCliente.Visible = false;
                this.cboTipoDoc.Visible = false;


            }
            if (this.cboRoles.SelectedValue.ToString() != "Empresa")
            {
                this.lblFechaEmpresa.Visible = false;
                this.lblNombreEmpresa.Visible = false;
                this.lblRazonEmpresa.Visible = false;
                this.lblTelefonoEmpresa.Visible = false;
                this.lblCUITEmpresa.Visible = false;

                this.txtCUITEmpresa.Visible = false;
                this.txtNombreContEmpresa.Visible = false;
                this.txtRazonEmpresa.Visible = false;
                this.txtTelEmpresa.Visible = false;
            }
        }
    }
}


