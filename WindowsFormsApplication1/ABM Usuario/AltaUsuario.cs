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
    public partial class AltaUsuario : Form
    {
        public static AltaUsuario aus;
        public AltaUsuario()
        {
            InitializeComponent();
            AltaUsuario.aus = this;

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.rbCliente.Checked == true)
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
                this.txtTipoCliente.Visible = true;

                this.txtCUITEmpresa.Text = "";
                this.txtNombreContEmpresa.Text = "";
                this.txtRazonEmpresa.Text = "";
                this.txtTelEmpresa.Text = "";
                             
               

            }
            if (this.rbEmpresa.Checked == true)
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

                this.txtApellidoCliente.Text = "";
                this.txtDNICliente.Text = "";
                this.txtNombreCliente.Text = "";
                this.txtTelCliente.Text = "";
                this.txtTipoCliente.Text = "";
            
          
                               
            }

            if(this.rbCliente.Checked == true || this.rbEmpresa.Checked == true)
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
            }
          
            if(this.rbCliente.Checked == false)
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
                this.txtTipoCliente.Visible = false;
            }
            if (this.rbEmpresa.Checked == false)
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
        private void AltaUsuario_Load(object sender, EventArgs e)
        {
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
            this.txtTipoCliente.Visible = false;
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
            this.dtpCreacion.Visible = false;
            this.timer1.Start();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";
            string cadenaDeErrorTipo = "Debe seleccionar un tipo de Usuario";
            

            if(rbCliente.Checked== false && rbEmpresa.Checked == false)
            {
                MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }


            if(rbCliente.Checked== true)
                   
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    cadenaDeErrores += " Usuario \r";
                }
                if(string.IsNullOrEmpty(txtPassword.Text))
                {
                    cadenaDeErrores += " Password \r";
                }
                if(string.IsNullOrEmpty(txtMail.Text))
                {
                    cadenaDeErrores += " Mail \r";
                }
                
                if(string.IsNullOrEmpty(txtApellidoCliente.Text))
                {
                    cadenaDeErrores += " Apellido \r";
                }
                if(string.IsNullOrEmpty(txtNombreCliente.Text))
                {
                    cadenaDeErrores += " Nombre \r";
                }
                if(string.IsNullOrEmpty(txtDNICliente.Text))
                {
                    cadenaDeErrores += " DNI \r";
                }
                if(string.IsNullOrEmpty(txtTelCliente.Text)) 
                {
                    cadenaDeErrores += " Telefono \r";
                }
                if(string.IsNullOrEmpty(txtTipoCliente.Text))
                {
                    cadenaDeErrores += " Tipo \r";
                }

                if (string.IsNullOrEmpty(txtCodPos.Text)) 
                {
                    cadenaDeErrores += " CodigoPostal \r";
                }
                if (string.IsNullOrEmpty(txtDpto.Text))
                {
                    cadenaDeErrores += " Departamento \r";
                }
                if (string.IsNullOrEmpty(txtLocalidad.Text)) 
                {
                    cadenaDeErrores += " Localidad \r";
                }
                if (string.IsNullOrEmpty(txtPiso.Text))
                {
                    cadenaDeErrores += " Piso \r";
                }
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    cadenaDeErrores += " Numero \r";
                }
                if (string.IsNullOrEmpty(txtCalle.Text))
                 {
                    cadenaDeErrores += " Calle \r";
                }


                MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (rbEmpresa.Checked == true)
              
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    cadenaDeErrores += " Usuario \r";
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    cadenaDeErrores += " Password \r";
                }
                if (string.IsNullOrEmpty(txtMail.Text))
                {
                    cadenaDeErrores += " Mail \r";
                }
                if(string.IsNullOrEmpty(txtCUITEmpresa.Text)) 
                {
                    cadenaDeErrores += " CUIT \r";
                }
                if(string.IsNullOrEmpty(txtNombreContEmpresa.Text)) 
                {
                    cadenaDeErrores += " Nombre de Contacto \r";
                }

                if(string.IsNullOrEmpty(txtRazonEmpresa.Text))
                {
                    cadenaDeErrores += " Razon Social \r";
                }
                if(string.IsNullOrEmpty(txtTelEmpresa.Text))
                {
                    cadenaDeErrores += " Telefono \r";
                }
                if (string.IsNullOrEmpty(txtCodPos.Text)) 
                {
                    cadenaDeErrores += " CodigoPostal \r";
                }
                if (string.IsNullOrEmpty(txtDpto.Text))
                {
                    cadenaDeErrores += " Departamento \r";
                }
                if (string.IsNullOrEmpty(txtLocalidad.Text)) 
                {
                    cadenaDeErrores += " Localidad \r";
                }
                if (string.IsNullOrEmpty(txtPiso.Text))
                {
                    cadenaDeErrores += " Piso \r";
                }
                if (string.IsNullOrEmpty(txtNumero.Text))
                {
                    cadenaDeErrores += " Numero \r";
                }
                if (string.IsNullOrEmpty(txtCalle.Text))
                {
                    cadenaDeErrores += " Calle \r";
                }

                MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
        
            }
         

          
           //GUARDAR LOS DATOS DE LOS txtUsuario txtContrasenia y demas en la BDD
          Login.lg.Show();
          this.Hide();

                
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
            this.txtTipoCliente.Text = "";

            this.txtCUITEmpresa.Text = "";
            this.txtNombreContEmpresa.Text = "";
            this.txtRazonEmpresa.Text = "";
            this.txtTelEmpresa.Text = "";

            this.dtpCreacion.Visible = false;


            this.rbEmpresa.Checked = false;
            this.rbCliente.Checked = false;

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
    }
}


