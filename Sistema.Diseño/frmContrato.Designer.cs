namespace Sistema.Diseño
{
    partial class frmContrato
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldoC = new System.Windows.Forms.TextBox();
            this.txtDiasC = new System.Windows.Forms.TextBox();
            this.dateFechaC = new System.Windows.Forms.DateTimePicker();
            this.txtRutC = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAgregarFM = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMontoFM = new System.Windows.Forms.TextBox();
            this.dateAbonoFM = new System.Windows.Forms.DateTimePicker();
            this.txtRutFM = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarSC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTerminoSC = new System.Windows.Forms.DateTimePicker();
            this.txtDescripServicioSC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorServicioSC = new System.Windows.Forms.TextBox();
            this.txtNombreServicioSC = new System.Windows.Forms.TextBox();
            this.dateInicioSC = new System.Windows.Forms.DateTimePicker();
            this.txtRutSC = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkboxSeleccionarC = new System.Windows.Forms.CheckBox();
            this.btnSuspenderC = new System.Windows.Forms.Button();
            this.btnBuscarRutC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRutBuscarC = new System.Windows.Forms.TextBox();
            this.btnActualizarRegistrosC = new System.Windows.Forms.Button();
            this.lblTotalC = new System.Windows.Forms.Label();
            this.DgvListadoContrato = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAgregarC);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(123, 325);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(213, 23);
            this.btnAgregarC.TabIndex = 44;
            this.btnAgregarC.Text = "Agregar Contrato";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSueldoC);
            this.groupBox1.Controls.Add(this.txtDiasC);
            this.groupBox1.Controls.Add(this.dateFechaC);
            this.groupBox1.Controls.Add(this.txtRutC);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Contrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Sueldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Plazo en Dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Rut Usuario";
            // 
            // txtSueldoC
            // 
            this.txtSueldoC.Location = new System.Drawing.Point(95, 183);
            this.txtSueldoC.Name = "txtSueldoC";
            this.txtSueldoC.Size = new System.Drawing.Size(217, 20);
            this.txtSueldoC.TabIndex = 38;
            this.txtSueldoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoC_KeyPress);
            // 
            // txtDiasC
            // 
            this.txtDiasC.Location = new System.Drawing.Point(95, 140);
            this.txtDiasC.Name = "txtDiasC";
            this.txtDiasC.Size = new System.Drawing.Size(117, 20);
            this.txtDiasC.TabIndex = 37;
            this.txtDiasC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasC_KeyPress);
            // 
            // dateFechaC
            // 
            this.dateFechaC.Location = new System.Drawing.Point(95, 95);
            this.dateFechaC.Name = "dateFechaC";
            this.dateFechaC.Size = new System.Drawing.Size(217, 20);
            this.dateFechaC.TabIndex = 36;
            // 
            // txtRutC
            // 
            this.txtRutC.Location = new System.Drawing.Point(95, 51);
            this.txtRutC.Name = "txtRutC";
            this.txtRutC.Size = new System.Drawing.Size(217, 20);
            this.txtRutC.TabIndex = 35;
            this.txtRutC.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutC_Validating);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAgregarFM);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1222, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crear Fondo Monetario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFM
            // 
            this.btnAgregarFM.Location = new System.Drawing.Point(120, 242);
            this.btnAgregarFM.Name = "btnAgregarFM";
            this.btnAgregarFM.Size = new System.Drawing.Size(213, 23);
            this.btnAgregarFM.TabIndex = 47;
            this.btnAgregarFM.Text = "Agregar Fondo Monetario";
            this.btnAgregarFM.UseVisualStyleBackColor = true;
            this.btnAgregarFM.Click += new System.EventHandler(this.btnAgregarFM_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtMontoFM);
            this.groupBox3.Controls.Add(this.dateAbonoFM);
            this.groupBox3.Controls.Add(this.txtRutFM);
            this.groupBox3.Location = new System.Drawing.Point(21, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 199);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Fondo Monetario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Monto Abono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Fecha Abono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Rut Usuario";
            // 
            // txtMontoFM
            // 
            this.txtMontoFM.Location = new System.Drawing.Point(94, 90);
            this.txtMontoFM.Name = "txtMontoFM";
            this.txtMontoFM.Size = new System.Drawing.Size(117, 20);
            this.txtMontoFM.TabIndex = 37;
            this.txtMontoFM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoFM_KeyPress);
            // 
            // dateAbonoFM
            // 
            this.dateAbonoFM.Location = new System.Drawing.Point(95, 127);
            this.dateAbonoFM.Name = "dateAbonoFM";
            this.dateAbonoFM.Size = new System.Drawing.Size(217, 20);
            this.dateAbonoFM.TabIndex = 36;
            // 
            // txtRutFM
            // 
            this.txtRutFM.Location = new System.Drawing.Point(95, 51);
            this.txtRutFM.Name = "txtRutFM";
            this.txtRutFM.Size = new System.Drawing.Size(217, 20);
            this.txtRutFM.TabIndex = 35;
            this.txtRutFM.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutFM_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarSC);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Servicio Contrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSC
            // 
            this.btnAgregarSC.Location = new System.Drawing.Point(127, 389);
            this.btnAgregarSC.Name = "btnAgregarSC";
            this.btnAgregarSC.Size = new System.Drawing.Size(213, 23);
            this.btnAgregarSC.TabIndex = 46;
            this.btnAgregarSC.Text = "Agregar Servicio Contrato";
            this.btnAgregarSC.UseVisualStyleBackColor = true;
            this.btnAgregarSC.Click += new System.EventHandler(this.btnAgregarSC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTerminoSC);
            this.groupBox2.Controls.Add(this.txtDescripServicioSC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValorServicioSC);
            this.groupBox2.Controls.Add(this.txtNombreServicioSC);
            this.groupBox2.Controls.Add(this.dateInicioSC);
            this.groupBox2.Controls.Add(this.txtRutSC);
            this.groupBox2.Location = new System.Drawing.Point(32, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 350);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Contrato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Fecha Termino";
            // 
            // dateTerminoSC
            // 
            this.dateTerminoSC.Location = new System.Drawing.Point(132, 244);
            this.dateTerminoSC.Name = "dateTerminoSC";
            this.dateTerminoSC.Size = new System.Drawing.Size(217, 20);
            this.dateTerminoSC.TabIndex = 45;
            // 
            // txtDescripServicioSC
            // 
            this.txtDescripServicioSC.Location = new System.Drawing.Point(132, 164);
            this.txtDescripServicioSC.Name = "txtDescripServicioSC";
            this.txtDescripServicioSC.Size = new System.Drawing.Size(217, 20);
            this.txtDescripServicioSC.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Descripcion Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Valor Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre Servicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Rut Usuario";
            // 
            // txtValorServicioSC
            // 
            this.txtValorServicioSC.Location = new System.Drawing.Point(132, 123);
            this.txtValorServicioSC.Name = "txtValorServicioSC";
            this.txtValorServicioSC.Size = new System.Drawing.Size(217, 20);
            this.txtValorServicioSC.TabIndex = 38;
            this.txtValorServicioSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorServicioSC_KeyPress);
            // 
            // txtNombreServicioSC
            // 
            this.txtNombreServicioSC.Location = new System.Drawing.Point(132, 88);
            this.txtNombreServicioSC.Name = "txtNombreServicioSC";
            this.txtNombreServicioSC.Size = new System.Drawing.Size(217, 20);
            this.txtNombreServicioSC.TabIndex = 37;
            // 
            // dateInicioSC
            // 
            this.dateInicioSC.Location = new System.Drawing.Point(132, 204);
            this.dateInicioSC.Name = "dateInicioSC";
            this.dateInicioSC.Size = new System.Drawing.Size(217, 20);
            this.dateInicioSC.TabIndex = 36;
            // 
            // txtRutSC
            // 
            this.txtRutSC.Location = new System.Drawing.Point(132, 50);
            this.txtRutSC.Name = "txtRutSC";
            this.txtRutSC.Size = new System.Drawing.Size(217, 20);
            this.txtRutSC.TabIndex = 35;
            this.txtRutSC.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutSC_Validating);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkboxSeleccionarC);
            this.tabPage6.Controls.Add(this.btnSuspenderC);
            this.tabPage6.Controls.Add(this.btnBuscarRutC);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txtRutBuscarC);
            this.tabPage6.Controls.Add(this.btnActualizarRegistrosC);
            this.tabPage6.Controls.Add(this.lblTotalC);
            this.tabPage6.Controls.Add(this.DgvListadoContrato);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1222, 433);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Visualizar Contrato";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chkboxSeleccionarC
            // 
            this.chkboxSeleccionarC.AutoSize = true;
            this.chkboxSeleccionarC.Location = new System.Drawing.Point(19, 395);
            this.chkboxSeleccionarC.Name = "chkboxSeleccionarC";
            this.chkboxSeleccionarC.Size = new System.Drawing.Size(82, 17);
            this.chkboxSeleccionarC.TabIndex = 27;
            this.chkboxSeleccionarC.Text = "Seleccionar";
            this.chkboxSeleccionarC.UseVisualStyleBackColor = true;
            this.chkboxSeleccionarC.CheckedChanged += new System.EventHandler(this.chkboxSeleccionarC_CheckedChanged);
            // 
            // btnSuspenderC
            // 
            this.btnSuspenderC.Location = new System.Drawing.Point(148, 395);
            this.btnSuspenderC.Name = "btnSuspenderC";
            this.btnSuspenderC.Size = new System.Drawing.Size(169, 23);
            this.btnSuspenderC.TabIndex = 26;
            this.btnSuspenderC.Text = "Suspender";
            this.btnSuspenderC.UseVisualStyleBackColor = true;
            this.btnSuspenderC.Click += new System.EventHandler(this.btnSuspenderC_Click);
            // 
            // btnBuscarRutC
            // 
            this.btnBuscarRutC.Location = new System.Drawing.Point(307, 14);
            this.btnBuscarRutC.Name = "btnBuscarRutC";
            this.btnBuscarRutC.Size = new System.Drawing.Size(169, 23);
            this.btnBuscarRutC.TabIndex = 25;
            this.btnBuscarRutC.Text = "Buscar";
            this.btnBuscarRutC.UseVisualStyleBackColor = true;
            this.btnBuscarRutC.Click += new System.EventHandler(this.btnBuscarRutC_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ingrese Rut";
            // 
            // txtRutBuscarC
            // 
            this.txtRutBuscarC.Location = new System.Drawing.Point(95, 16);
            this.txtRutBuscarC.Name = "txtRutBuscarC";
            this.txtRutBuscarC.Size = new System.Drawing.Size(180, 20);
            this.txtRutBuscarC.TabIndex = 23;
            this.txtRutBuscarC.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutBuscarC_Validating);
            // 
            // btnActualizarRegistrosC
            // 
            this.btnActualizarRegistrosC.Location = new System.Drawing.Point(885, 395);
            this.btnActualizarRegistrosC.Name = "btnActualizarRegistrosC";
            this.btnActualizarRegistrosC.Size = new System.Drawing.Size(169, 23);
            this.btnActualizarRegistrosC.TabIndex = 22;
            this.btnActualizarRegistrosC.Text = "Actualizar Registros";
            this.btnActualizarRegistrosC.UseVisualStyleBackColor = true;
            this.btnActualizarRegistrosC.Click += new System.EventHandler(this.btnActualizarRegistrosC_Click);
            // 
            // lblTotalC
            // 
            this.lblTotalC.AutoSize = true;
            this.lblTotalC.Location = new System.Drawing.Point(1077, 400);
            this.lblTotalC.Name = "lblTotalC";
            this.lblTotalC.Size = new System.Drawing.Size(78, 13);
            this.lblTotalC.TabIndex = 21;
            this.lblTotalC.Text = "Total Registros";
            this.lblTotalC.Click += new System.EventHandler(this.lblTotalC_Click);
            // 
            // DgvListadoContrato
            // 
            this.DgvListadoContrato.AllowUserToAddRows = false;
            this.DgvListadoContrato.AllowUserToDeleteRows = false;
            this.DgvListadoContrato.AllowUserToOrderColumns = true;
            this.DgvListadoContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoContrato.Location = new System.Drawing.Point(19, 59);
            this.DgvListadoContrato.Name = "DgvListadoContrato";
            this.DgvListadoContrato.ReadOnly = true;
            this.DgvListadoContrato.Size = new System.Drawing.Size(1188, 330);
            this.DgvListadoContrato.TabIndex = 20;
            this.DgvListadoContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoContrato_CellContentClick);
            this.DgvListadoContrato.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoContrato_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmContrato";
            this.Text = "Gestionar Contratos";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.TextBox txtRutC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldoC;
        private System.Windows.Forms.TextBox txtDiasC;
        private System.Windows.Forms.DateTimePicker dateFechaC;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button btnAgregarSC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTerminoSC;
        private System.Windows.Forms.TextBox txtDescripServicioSC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorServicioSC;
        private System.Windows.Forms.TextBox txtNombreServicioSC;
        private System.Windows.Forms.DateTimePicker dateInicioSC;
        private System.Windows.Forms.TextBox txtRutSC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMontoFM;
        private System.Windows.Forms.DateTimePicker dateAbonoFM;
        private System.Windows.Forms.TextBox txtRutFM;
        private System.Windows.Forms.Button btnAgregarFM;
        private System.Windows.Forms.CheckBox chkboxSeleccionarC;
        private System.Windows.Forms.Button btnSuspenderC;
        private System.Windows.Forms.Button btnBuscarRutC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRutBuscarC;
        private System.Windows.Forms.Button btnActualizarRegistrosC;
        private System.Windows.Forms.Label lblTotalC;
        private System.Windows.Forms.DataGridView DgvListadoContrato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}