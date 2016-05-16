namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class ModificacionUsuario
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
            this.cboSeleccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbApellidoCliente = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbMailCliente = new System.Windows.Forms.RadioButton();
            this.rbNombreCliente = new System.Windows.Forms.RadioButton();
            this.rbRazonEmpresa = new System.Windows.Forms.RadioButton();
            this.rbCUITEmpresa = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 137);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Usuario";
            // 
            // cboSeleccion
            // 
            this.cboSeleccion.FormattingEnabled = true;
            this.cboSeleccion.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.cboSeleccion.Location = new System.Drawing.Point(34, 39);
            this.cboSeleccion.Name = "cboSeleccion";
            this.cboSeleccion.Size = new System.Drawing.Size(171, 21);
            this.cboSeleccion.TabIndex = 2;
            this.cboSeleccion.Text = "Seleccione un Tipo de Usuario";
            this.cboSeleccion.SelectedIndexChanged += new System.EventHandler(this.cboSeleccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 214);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por..";
            // 
            // rbApellidoCliente
            // 
            this.rbApellidoCliente.AutoSize = true;
            this.rbApellidoCliente.Location = new System.Drawing.Point(33, 262);
            this.rbApellidoCliente.Name = "rbApellidoCliente";
            this.rbApellidoCliente.Size = new System.Drawing.Size(62, 17);
            this.rbApellidoCliente.TabIndex = 5;
            this.rbApellidoCliente.TabStop = true;
            this.rbApellidoCliente.Text = "Apellido";
            this.rbApellidoCliente.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(33, 304);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 6;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // rbMailCliente
            // 
            this.rbMailCliente.AutoSize = true;
            this.rbMailCliente.Location = new System.Drawing.Point(33, 345);
            this.rbMailCliente.Name = "rbMailCliente";
            this.rbMailCliente.Size = new System.Drawing.Size(50, 17);
            this.rbMailCliente.TabIndex = 7;
            this.rbMailCliente.TabStop = true;
            this.rbMailCliente.Text = "Email";
            this.rbMailCliente.UseVisualStyleBackColor = true;
            // 
            // rbNombreCliente
            // 
            this.rbNombreCliente.AutoSize = true;
            this.rbNombreCliente.Location = new System.Drawing.Point(33, 222);
            this.rbNombreCliente.Name = "rbNombreCliente";
            this.rbNombreCliente.Size = new System.Drawing.Size(62, 17);
            this.rbNombreCliente.TabIndex = 8;
            this.rbNombreCliente.TabStop = true;
            this.rbNombreCliente.Text = "Nombre";
            this.rbNombreCliente.UseVisualStyleBackColor = true;
            // 
            // rbRazonEmpresa
            // 
            this.rbRazonEmpresa.AutoSize = true;
            this.rbRazonEmpresa.Location = new System.Drawing.Point(34, 222);
            this.rbRazonEmpresa.Name = "rbRazonEmpresa";
            this.rbRazonEmpresa.Size = new System.Drawing.Size(88, 17);
            this.rbRazonEmpresa.TabIndex = 9;
            this.rbRazonEmpresa.TabStop = true;
            this.rbRazonEmpresa.Text = "Razon Social";
            this.rbRazonEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbCUITEmpresa
            // 
            this.rbCUITEmpresa.AutoSize = true;
            this.rbCUITEmpresa.Location = new System.Drawing.Point(33, 262);
            this.rbCUITEmpresa.Name = "rbCUITEmpresa";
            this.rbCUITEmpresa.Size = new System.Drawing.Size(50, 17);
            this.rbCUITEmpresa.TabIndex = 10;
            this.rbCUITEmpresa.TabStop = true;
            this.rbCUITEmpresa.Text = "CUIT";
            this.rbCUITEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(34, 304);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(50, 17);
            this.rbEmail.TabIndex = 11;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(237, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 382);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultados";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(161, 410);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(186, 23);
            this.cmdVolver.TabIndex = 13;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // ModificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 454);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbCUITEmpresa);
            this.Controls.Add(this.rbRazonEmpresa);
            this.Controls.Add(this.rbNombreCliente);
            this.Controls.Add(this.rbMailCliente);
            this.Controls.Add(this.rbDNI);
            this.Controls.Add(this.rbApellidoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSeleccion);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionUsuario";
            this.Text = "ModificacionUsuario";
            this.Load += new System.EventHandler(this.ModificacionUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSeleccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbApellidoCliente;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.RadioButton rbMailCliente;
        private System.Windows.Forms.RadioButton rbNombreCliente;
        private System.Windows.Forms.RadioButton rbRazonEmpresa;
        private System.Windows.Forms.RadioButton rbCUITEmpresa;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdVolver;
    }
}