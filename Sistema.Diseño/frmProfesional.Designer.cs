namespace Sistema.Diseño
{
    partial class frmProfesional
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
            this.tabGeneralPro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProfesion = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtDomicilioUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtFonoUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarProfesional = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotalRegProf = new System.Windows.Forms.Label();
            this.btnActualizarRegistros = new System.Windows.Forms.Button();
            this.btnDeshabilitarPro = new System.Windows.Forms.Button();
            this.chkBoxSelecionarPro = new System.Windows.Forms.CheckBox();
            this.DgvListadoProfesional = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscarProf = new System.Windows.Forms.Button();
            this.txtBuscarProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnActualizarProfesional = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRutUserP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDomicilioUsuarioP = new System.Windows.Forms.TextBox();
            this.txtTelefonoUsuarioP = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuarioP = new System.Windows.Forms.TextBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabGeneralPro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProfesional)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneralPro
            // 
            this.tabGeneralPro.Controls.Add(this.tabPage1);
            this.tabGeneralPro.Controls.Add(this.tabPage3);
            this.tabGeneralPro.Controls.Add(this.tabPage2);
            this.tabGeneralPro.Location = new System.Drawing.Point(1, 2);
            this.tabGeneralPro.Name = "tabGeneralPro";
            this.tabGeneralPro.SelectedIndex = 0;
            this.tabGeneralPro.Size = new System.Drawing.Size(1234, 462);
            this.tabGeneralPro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAgregarProfesional);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Profesional";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProfesion);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRutUsuario);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtDomicilioUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.txtFonoUsuario);
            this.groupBox1.Controls.Add(this.txtApellidoUsuario);
            this.groupBox1.Controls.Add(this.txtCorreoUsuario);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 349);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Profesional";
            // 
            // txtProfesion
            // 
            this.txtProfesion.FormattingEnabled = true;
            this.txtProfesion.Items.AddRange(new object[] {
            "Capacitador",
            "Supervisor",
            "Asistente"});
            this.txtProfesion.Location = new System.Drawing.Point(444, 62);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(217, 21);
            this.txtProfesion.TabIndex = 44;
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Profesional"});
            this.txtTipo.Location = new System.Drawing.Point(107, 104);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(217, 21);
            this.txtTipo.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Profesion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Domicilio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rut Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipos Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Contraseña";
            // 
            // txtRutUsuario
            // 
            this.txtRutUsuario.Location = new System.Drawing.Point(107, 21);
            this.txtRutUsuario.Name = "txtRutUsuario";
            this.txtRutUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtRutUsuario.TabIndex = 32;
            this.txtRutUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutUsuario_Validating);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 63);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(217, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtDomicilioUsuario
            // 
            this.txtDomicilioUsuario.Location = new System.Drawing.Point(444, 19);
            this.txtDomicilioUsuario.Name = "txtDomicilioUsuario";
            this.txtDomicilioUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtDomicilioUsuario.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(107, 143);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtFonoUsuario
            // 
            this.txtFonoUsuario.Location = new System.Drawing.Point(107, 231);
            this.txtFonoUsuario.Name = "txtFonoUsuario";
            this.txtFonoUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtFonoUsuario.TabIndex = 4;
            this.txtFonoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFonoUsuario_KeyPress);
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(107, 186);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtApellidoUsuario.TabIndex = 7;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(107, 280);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtCorreoUsuario.TabIndex = 5;
            // 
            // btnAgregarProfesional
            // 
            this.btnAgregarProfesional.Location = new System.Drawing.Point(272, 387);
            this.btnAgregarProfesional.Name = "btnAgregarProfesional";
            this.btnAgregarProfesional.Size = new System.Drawing.Size(213, 23);
            this.btnAgregarProfesional.TabIndex = 0;
            this.btnAgregarProfesional.Text = "Agregar Profesional";
            this.btnAgregarProfesional.UseVisualStyleBackColor = true;
            this.btnAgregarProfesional.Click += new System.EventHandler(this.btnAgregarProfesional_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalRegProf);
            this.tabPage3.Controls.Add(this.btnActualizarRegistros);
            this.tabPage3.Controls.Add(this.btnDeshabilitarPro);
            this.tabPage3.Controls.Add(this.chkBoxSelecionarPro);
            this.tabPage3.Controls.Add(this.DgvListadoProfesional);
            this.tabPage3.Controls.Add(this.btnBuscarProf);
            this.tabPage3.Controls.Add(this.txtBuscarProf);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1226, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Profesional";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalRegProf
            // 
            this.lblTotalRegProf.AutoSize = true;
            this.lblTotalRegProf.Location = new System.Drawing.Point(1092, 397);
            this.lblTotalRegProf.Name = "lblTotalRegProf";
            this.lblTotalRegProf.Size = new System.Drawing.Size(81, 13);
            this.lblTotalRegProf.TabIndex = 30;
            this.lblTotalRegProf.Text = "Total Registros:";
            // 
            // btnActualizarRegistros
            // 
            this.btnActualizarRegistros.Location = new System.Drawing.Point(896, 393);
            this.btnActualizarRegistros.Name = "btnActualizarRegistros";
            this.btnActualizarRegistros.Size = new System.Drawing.Size(169, 23);
            this.btnActualizarRegistros.TabIndex = 29;
            this.btnActualizarRegistros.Text = "Actualizar Registros";
            this.btnActualizarRegistros.UseVisualStyleBackColor = true;
            this.btnActualizarRegistros.Click += new System.EventHandler(this.btnActualizarRegistros_Click);
            // 
            // btnDeshabilitarPro
            // 
            this.btnDeshabilitarPro.Location = new System.Drawing.Point(168, 393);
            this.btnDeshabilitarPro.Name = "btnDeshabilitarPro";
            this.btnDeshabilitarPro.Size = new System.Drawing.Size(169, 23);
            this.btnDeshabilitarPro.TabIndex = 28;
            this.btnDeshabilitarPro.Text = "Deshabilitar";
            this.btnDeshabilitarPro.UseVisualStyleBackColor = true;
            this.btnDeshabilitarPro.Click += new System.EventHandler(this.btnDeshabilitarPro_Click);
            // 
            // chkBoxSelecionarPro
            // 
            this.chkBoxSelecionarPro.AutoSize = true;
            this.chkBoxSelecionarPro.Location = new System.Drawing.Point(29, 397);
            this.chkBoxSelecionarPro.Name = "chkBoxSelecionarPro";
            this.chkBoxSelecionarPro.Size = new System.Drawing.Size(82, 17);
            this.chkBoxSelecionarPro.TabIndex = 27;
            this.chkBoxSelecionarPro.Text = "Seleccionar";
            this.chkBoxSelecionarPro.UseVisualStyleBackColor = true;
            this.chkBoxSelecionarPro.CheckedChanged += new System.EventHandler(this.chkBoxSelecionarPro_CheckedChanged);
            // 
            // DgvListadoProfesional
            // 
            this.DgvListadoProfesional.AllowUserToAddRows = false;
            this.DgvListadoProfesional.AllowUserToDeleteRows = false;
            this.DgvListadoProfesional.AllowUserToOrderColumns = true;
            this.DgvListadoProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoProfesional.Location = new System.Drawing.Point(29, 72);
            this.DgvListadoProfesional.Name = "DgvListadoProfesional";
            this.DgvListadoProfesional.ReadOnly = true;
            this.DgvListadoProfesional.Size = new System.Drawing.Size(1191, 308);
            this.DgvListadoProfesional.TabIndex = 26;
            this.DgvListadoProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoProfesional_CellContentClick);
            this.DgvListadoProfesional.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoProfesional_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btnBuscarProf
            // 
            this.btnBuscarProf.Location = new System.Drawing.Point(340, 21);
            this.btnBuscarProf.Name = "btnBuscarProf";
            this.btnBuscarProf.Size = new System.Drawing.Size(169, 23);
            this.btnBuscarProf.TabIndex = 25;
            this.btnBuscarProf.Text = "Buscar";
            this.btnBuscarProf.UseVisualStyleBackColor = true;
            this.btnBuscarProf.Click += new System.EventHandler(this.btnBuscarProf_Click);
            // 
            // txtBuscarProf
            // 
            this.txtBuscarProf.Location = new System.Drawing.Point(94, 24);
            this.txtBuscarProf.Name = "txtBuscarProf";
            this.txtBuscarProf.Size = new System.Drawing.Size(222, 20);
            this.txtBuscarProf.TabIndex = 24;
            this.txtBuscarProf.Validating += new System.ComponentModel.CancelEventHandler(this.txtBuscarProf_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ingrese Rut";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnActualizarProfesional);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Profesional";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProfesional
            // 
            this.btnActualizarProfesional.Location = new System.Drawing.Point(129, 372);
            this.btnActualizarProfesional.Name = "btnActualizarProfesional";
            this.btnActualizarProfesional.Size = new System.Drawing.Size(213, 23);
            this.btnActualizarProfesional.TabIndex = 36;
            this.btnActualizarProfesional.Text = "Actualizar";
            this.btnActualizarProfesional.UseVisualStyleBackColor = true;
            this.btnActualizarProfesional.Click += new System.EventHandler(this.btnActualizarProfesional_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRutUserP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDomicilioUsuarioP);
            this.groupBox2.Controls.Add(this.txtTelefonoUsuarioP);
            this.groupBox2.Controls.Add(this.txtCorreoUsuarioP);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Location = new System.Drawing.Point(27, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 315);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los siguentes datos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Rut Profesional";
            // 
            // txtRutUserP
            // 
            this.txtRutUserP.Location = new System.Drawing.Point(113, 53);
            this.txtRutUserP.Name = "txtRutUserP";
            this.txtRutUserP.Size = new System.Drawing.Size(217, 20);
            this.txtRutUserP.TabIndex = 42;
            this.txtRutUserP.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutUserP_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Domicilio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Correo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Telefono";
            // 
            // txtDomicilioUsuarioP
            // 
            this.txtDomicilioUsuarioP.Location = new System.Drawing.Point(113, 236);
            this.txtDomicilioUsuarioP.Name = "txtDomicilioUsuarioP";
            this.txtDomicilioUsuarioP.Size = new System.Drawing.Size(217, 20);
            this.txtDomicilioUsuarioP.TabIndex = 9;
            // 
            // txtTelefonoUsuarioP
            // 
            this.txtTelefonoUsuarioP.Location = new System.Drawing.Point(113, 110);
            this.txtTelefonoUsuarioP.Name = "txtTelefonoUsuarioP";
            this.txtTelefonoUsuarioP.Size = new System.Drawing.Size(217, 20);
            this.txtTelefonoUsuarioP.TabIndex = 4;
            this.txtTelefonoUsuarioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoUsuarioP_KeyPress);
            // 
            // txtCorreoUsuarioP
            // 
            this.txtCorreoUsuarioP.Location = new System.Drawing.Point(113, 173);
            this.txtCorreoUsuarioP.Name = "txtCorreoUsuarioP";
            this.txtCorreoUsuarioP.Size = new System.Drawing.Size(217, 20);
            this.txtCorreoUsuarioP.TabIndex = 5;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // frmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 463);
            this.Controls.Add(this.tabGeneralPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmProfesional";
            this.Text = "Gestionar Profesional";
            this.Load += new System.EventHandler(this.frmProfesional_Load);
            this.tabGeneralPro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProfesional)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneralPro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAgregarProfesional;
        private System.Windows.Forms.TextBox txtDomicilioUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtFonoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtRutUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDomicilioUsuarioP;
        private System.Windows.Forms.TextBox txtTelefonoUsuarioP;
        private System.Windows.Forms.TextBox txtCorreoUsuarioP;
        private System.Windows.Forms.Button btnBuscarProf;
        private System.Windows.Forms.TextBox txtBuscarProf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvListadoProfesional;
        private System.Windows.Forms.CheckBox chkBoxSelecionarPro;
        private System.Windows.Forms.Button btnActualizarRegistros;
        private System.Windows.Forms.Button btnDeshabilitarPro;
        private System.Windows.Forms.Label lblTotalRegProf;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button btnActualizarProfesional;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRutUserP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.ComboBox txtProfesion;
    }
}