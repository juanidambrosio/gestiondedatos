﻿namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class AltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lblTipoDNICliente = new System.Windows.Forms.Label();
            this.lblNroDocCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.dtpCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacCliente = new System.Windows.Forms.Label();
            this.lblTelCliente = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblDpto = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblCodPos = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtTipoCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.txtCodPos = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblRazonEmpresa = new System.Windows.Forms.Label();
            this.lblCUITEmpresa = new System.Windows.Forms.Label();
            this.lblFechaEmpresa = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblTelefonoEmpresa = new System.Windows.Forms.Label();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.txtRazonEmpresa = new System.Windows.Forms.TextBox();
            this.txtCUITEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreContEmpresa = new System.Windows.Forms.TextBox();
            this.txtTelEmpresa = new System.Windows.Forms.TextBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Usuario";
            // 
            // lblCampos
            // 
            this.lblCampos.AllowDrop = true;
            this.lblCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCampos.Location = new System.Drawing.Point(126, 9);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(354, 438);
            this.lblCampos.TabIndex = 3;
            this.lblCampos.Text = "(*) Campos obligatorios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(139, 30);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(112, 13);
            this.lblNombreUsuario.TabIndex = 5;
            this.lblNombreUsuario.Text = "(*) Nombre de usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(183, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "(*) Password:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(210, 76);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(42, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "(*) Mail:";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(22, 99);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 8;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(22, 136);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 9;
            this.cmdBorrar.Text = "Borrar todo";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lblTipoDNICliente
            // 
            this.lblTipoDNICliente.AutoSize = true;
            this.lblTipoDNICliente.Location = new System.Drawing.Point(187, 166);
            this.lblTipoDNICliente.Name = "lblTipoDNICliente";
            this.lblTipoDNICliente.Size = new System.Drawing.Size(63, 13);
            this.lblTipoDNICliente.TabIndex = 10;
            this.lblTipoDNICliente.Text = "(*)Tipo DNI:";
            // 
            // lblNroDocCliente
            // 
            this.lblNroDocCliente.AutoSize = true;
            this.lblNroDocCliente.Location = new System.Drawing.Point(155, 188);
            this.lblNroDocCliente.Name = "lblNroDocCliente";
            this.lblNroDocCliente.Size = new System.Drawing.Size(95, 13);
            this.lblNroDocCliente.TabIndex = 11;
            this.lblNroDocCliente.Text = "(*)Nro Documento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 12;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(192, 101);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(60, 13);
            this.lblNombreCliente.TabIndex = 13;
            this.lblNombreCliente.Text = "(*) Nombre:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(193, 125);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(60, 13);
            this.lblApellidoCliente.TabIndex = 14;
            this.lblApellidoCliente.Text = "(*) Apellido:";
            // 
            // dtpCreacion
            // 
            this.dtpCreacion.Location = new System.Drawing.Point(257, 145);
            this.dtpCreacion.Name = "dtpCreacion";
            this.dtpCreacion.Size = new System.Drawing.Size(189, 20);
            this.dtpCreacion.TabIndex = 15;
            // 
            // lblFechaNacCliente
            // 
            this.lblFechaNacCliente.AutoSize = true;
            this.lblFechaNacCliente.Location = new System.Drawing.Point(143, 146);
            this.lblFechaNacCliente.Name = "lblFechaNacCliente";
            this.lblFechaNacCliente.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacCliente.TabIndex = 16;
            this.lblFechaNacCliente.Text = "(*) Fecha Nacimiento:";
            // 
            // lblTelCliente
            // 
            this.lblTelCliente.AutoSize = true;
            this.lblTelCliente.Location = new System.Drawing.Point(184, 209);
            this.lblTelCliente.Name = "lblTelCliente";
            this.lblTelCliente.Size = new System.Drawing.Size(65, 13);
            this.lblTelCliente.TabIndex = 17;
            this.lblTelCliente.Text = "(*) Telefono:";
            // 
            // lblDom
            // 
            this.lblDom.AllowDrop = true;
            this.lblDom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDom.Location = new System.Drawing.Point(143, 234);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(286, 200);
            this.lblDom.TabIndex = 19;
            this.lblDom.Text = "(*) Domicilio";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(209, 262);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 20;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(194, 285);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 13);
            this.lblNum.TabIndex = 21;
            this.lblNum.Text = " Numero:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(209, 312);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(33, 13);
            this.lblPiso.TabIndex = 22;
            this.lblPiso.Text = " Piso:";
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(163, 334);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(80, 13);
            this.lblDpto.TabIndex = 23;
            this.lblDpto.Text = " Departamento:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(184, 389);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(59, 13);
            this.lblLocal.TabIndex = 24;
            this.lblLocal.Text = " Localidad:";
            // 
            // lblCodPos
            // 
            this.lblCodPos.AutoSize = true;
            this.lblCodPos.Location = new System.Drawing.Point(165, 363);
            this.lblCodPos.Name = "lblCodPos";
            this.lblCodPos.Size = new System.Drawing.Size(78, 13);
            this.lblCodPos.TabIndex = 25;
            this.lblCodPos.Text = " Codigo Postal:";
            this.lblCodPos.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(257, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(257, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(257, 75);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 28;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(257, 101);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 29;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(258, 123);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCliente.TabIndex = 30;
            // 
            // txtTipoCliente
            // 
            this.txtTipoCliente.Location = new System.Drawing.Point(257, 166);
            this.txtTipoCliente.Name = "txtTipoCliente";
            this.txtTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCliente.TabIndex = 31;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(256, 188);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(100, 20);
            this.txtDNICliente.TabIndex = 32;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(255, 208);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelCliente.TabIndex = 33;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(253, 259);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 34;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(253, 285);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 35;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(253, 311);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 36;
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(253, 334);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(100, 20);
            this.txtDpto.TabIndex = 37;
            // 
            // txtCodPos
            // 
            this.txtCodPos.Location = new System.Drawing.Point(253, 363);
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.Size = new System.Drawing.Size(100, 20);
            this.txtCodPos.TabIndex = 38;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(253, 389);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 39;
            // 
            // lblRazonEmpresa
            // 
            this.lblRazonEmpresa.AutoSize = true;
            this.lblRazonEmpresa.Location = new System.Drawing.Point(166, 101);
            this.lblRazonEmpresa.Name = "lblRazonEmpresa";
            this.lblRazonEmpresa.Size = new System.Drawing.Size(86, 13);
            this.lblRazonEmpresa.TabIndex = 40;
            this.lblRazonEmpresa.Text = "(*) Razon Social:";
            // 
            // lblCUITEmpresa
            // 
            this.lblCUITEmpresa.AutoSize = true;
            this.lblCUITEmpresa.Location = new System.Drawing.Point(201, 125);
            this.lblCUITEmpresa.Name = "lblCUITEmpresa";
            this.lblCUITEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblCUITEmpresa.TabIndex = 41;
            this.lblCUITEmpresa.Text = "(*) CUIT:";
            // 
            // lblFechaEmpresa
            // 
            this.lblFechaEmpresa.AutoSize = true;
            this.lblFechaEmpresa.Location = new System.Drawing.Point(155, 146);
            this.lblFechaEmpresa.Name = "lblFechaEmpresa";
            this.lblFechaEmpresa.Size = new System.Drawing.Size(98, 13);
            this.lblFechaEmpresa.TabIndex = 42;
            this.lblFechaEmpresa.Text = "(*) Fecha Creacion:";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(146, 166);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(106, 13);
            this.lblNombreEmpresa.TabIndex = 43;
            this.lblNombreEmpresa.Text = "(*) Nombre Contacto:";
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(187, 188);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(62, 13);
            this.lblTelefonoEmpresa.TabIndex = 44;
            this.lblTelefonoEmpresa.Text = "(*)Telefono:";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(22, 30);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 46;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(22, 53);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rbEmpresa.TabIndex = 47;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtRazonEmpresa
            // 
            this.txtRazonEmpresa.Location = new System.Drawing.Point(258, 101);
            this.txtRazonEmpresa.Name = "txtRazonEmpresa";
            this.txtRazonEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtRazonEmpresa.TabIndex = 48;
            // 
            // txtCUITEmpresa
            // 
            this.txtCUITEmpresa.Location = new System.Drawing.Point(256, 123);
            this.txtCUITEmpresa.Name = "txtCUITEmpresa";
            this.txtCUITEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtCUITEmpresa.TabIndex = 49;
            // 
            // txtNombreContEmpresa
            // 
            this.txtNombreContEmpresa.Location = new System.Drawing.Point(258, 166);
            this.txtNombreContEmpresa.Name = "txtNombreContEmpresa";
            this.txtNombreContEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtNombreContEmpresa.TabIndex = 50;
            // 
            // txtTelEmpresa
            // 
            this.txtTelEmpresa.Location = new System.Drawing.Point(256, 185);
            this.txtTelEmpresa.Name = "txtTelEmpresa";
            this.txtTelEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtTelEmpresa.TabIndex = 51;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(22, 178);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 52;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 456);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.txtTelEmpresa);
            this.Controls.Add(this.txtNombreContEmpresa);
            this.Controls.Add(this.txtCUITEmpresa);
            this.Controls.Add(this.txtRazonEmpresa);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.lblTelefonoEmpresa);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.lblFechaEmpresa);
            this.Controls.Add(this.lblCUITEmpresa);
            this.Controls.Add(this.lblRazonEmpresa);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtCodPos);
            this.Controls.Add(this.txtDpto);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.txtTipoCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblCodPos);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblDpto);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.lblTelCliente);
            this.Controls.Add(this.lblFechaNacCliente);
            this.Controls.Add(this.dtpCreacion);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNroDocCliente);
            this.Controls.Add(this.lblTipoDNICliente);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.label1);
            this.Name = "AltaUsuario";
            this.Text = "(*) Nombre";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Label lblTipoDNICliente;
        private System.Windows.Forms.Label lblNroDocCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.DateTimePicker dtpCreacion;
        private System.Windows.Forms.Label lblFechaNacCliente;
        private System.Windows.Forms.Label lblTelCliente;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblCodPos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtTipoCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.TextBox txtCodPos;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblRazonEmpresa;
        private System.Windows.Forms.Label lblCUITEmpresa;
        private System.Windows.Forms.Label lblFechaEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblTelefonoEmpresa;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.TextBox txtRazonEmpresa;
        private System.Windows.Forms.TextBox txtCUITEmpresa;
        private System.Windows.Forms.TextBox txtNombreContEmpresa;
        private System.Windows.Forms.TextBox txtTelEmpresa;
        private System.Windows.Forms.Button cmdVolver;
    }
}