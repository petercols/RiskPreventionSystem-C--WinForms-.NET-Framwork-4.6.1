namespace Sistema.Diseño
{
    partial class frmVisita
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTerminoALL = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateInicioALL = new System.Windows.Forms.DateTimePicker();
            this.txtDescPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescActividad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescServicio = new System.Windows.Forms.TextBox();
            this.cmbNombreTipoActividad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTotalPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btnCrearActividadALL = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalE = new System.Windows.Forms.Label();
            this.dataGridEditarVisita = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rb0Deshabilitado = new System.Windows.Forms.RadioButton();
            this.rb1Habilitado = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdServicioE = new System.Windows.Forms.TextBox();
            this.dateTerminoE = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateInicioE = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdActividadE = new System.Windows.Forms.TextBox();
            this.btnEditarVisita = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotalC = new System.Windows.Forms.Label();
            this.lblTotalA = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridChecklist = new System.Windows.Forms.DataGridView();
            this.dataGridAsistencia = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblTotalEliminar = new System.Windows.Forms.Label();
            this.btnEliminarVisita = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdVisita = new System.Windows.Forms.TextBox();
            this.dataGridEliminarVista = new System.Windows.Forms.DataGridView();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditarVisita)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsistencia)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEliminarVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1238, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCrearActividadALL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Visita";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTerminoALL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateInicioALL);
            this.groupBox1.Controls.Add(this.txtDescPago);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescActividad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescServicio);
            this.groupBox1.Controls.Add(this.cmbNombreTipoActividad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValorTotalPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreServicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 598);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Actividad ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Fecha Termino";
            // 
            // dateTerminoALL
            // 
            this.dateTerminoALL.Location = new System.Drawing.Point(138, 557);
            this.dateTerminoALL.Name = "dateTerminoALL";
            this.dateTerminoALL.Size = new System.Drawing.Size(217, 20);
            this.dateTerminoALL.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Fecha Inicio";
            // 
            // dateInicioALL
            // 
            this.dateInicioALL.Location = new System.Drawing.Point(140, 517);
            this.dateInicioALL.Name = "dateInicioALL";
            this.dateInicioALL.Size = new System.Drawing.Size(217, 20);
            this.dateInicioALL.TabIndex = 59;
            // 
            // txtDescPago
            // 
            this.txtDescPago.Location = new System.Drawing.Point(140, 416);
            this.txtDescPago.Multiline = true;
            this.txtDescPago.Name = "txtDescPago";
            this.txtDescPago.Size = new System.Drawing.Size(217, 77);
            this.txtDescPago.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Descripcion Pago";
            // 
            // txtDescActividad
            // 
            this.txtDescActividad.Location = new System.Drawing.Point(140, 315);
            this.txtDescActividad.Multiline = true;
            this.txtDescActividad.Name = "txtDescActividad";
            this.txtDescActividad.Size = new System.Drawing.Size(217, 77);
            this.txtDescActividad.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Descripcion Actividad";
            // 
            // txtDescServicio
            // 
            this.txtDescServicio.Location = new System.Drawing.Point(140, 172);
            this.txtDescServicio.Multiline = true;
            this.txtDescServicio.Name = "txtDescServicio";
            this.txtDescServicio.Size = new System.Drawing.Size(217, 77);
            this.txtDescServicio.TabIndex = 50;
            // 
            // cmbNombreTipoActividad
            // 
            this.cmbNombreTipoActividad.FormattingEnabled = true;
            this.cmbNombreTipoActividad.Items.AddRange(new object[] {
            "Visita"});
            this.cmbNombreTipoActividad.Location = new System.Drawing.Point(140, 271);
            this.cmbNombreTipoActividad.Name = "cmbNombreTipoActividad";
            this.cmbNombreTipoActividad.Size = new System.Drawing.Size(217, 21);
            this.cmbNombreTipoActividad.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tipo Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Descripcion Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Valor Total";
            // 
            // txtValorTotalPago
            // 
            this.txtValorTotalPago.Location = new System.Drawing.Point(140, 127);
            this.txtValorTotalPago.Name = "txtValorTotalPago";
            this.txtValorTotalPago.Size = new System.Drawing.Size(217, 20);
            this.txtValorTotalPago.TabIndex = 44;
            this.txtValorTotalPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotalPago_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre Servicio";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(140, 84);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(217, 20);
            this.txtNombreServicio.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Rut Usuario";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(140, 40);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(217, 20);
            this.txtRut.TabIndex = 40;
            this.txtRut.Validating += new System.ComponentModel.CancelEventHandler(this.txtRut_Validating);
            // 
            // btnCrearActividadALL
            // 
            this.btnCrearActividadALL.Location = new System.Drawing.Point(120, 644);
            this.btnCrearActividadALL.Name = "btnCrearActividadALL";
            this.btnCrearActividadALL.Size = new System.Drawing.Size(213, 23);
            this.btnCrearActividadALL.TabIndex = 1;
            this.btnCrearActividadALL.Text = "Crear Actividad";
            this.btnCrearActividadALL.UseVisualStyleBackColor = true;
            this.btnCrearActividadALL.Click += new System.EventHandler(this.btnCrearActividadALL_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalE);
            this.tabPage2.Controls.Add(this.dataGridEditarVisita);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnEditarVisita);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Visita";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalE
            // 
            this.lblTotalE.AutoSize = true;
            this.lblTotalE.Location = new System.Drawing.Point(986, 253);
            this.lblTotalE.Name = "lblTotalE";
            this.lblTotalE.Size = new System.Drawing.Size(31, 13);
            this.lblTotalE.TabIndex = 64;
            this.lblTotalE.Text = "Total";
            // 
            // dataGridEditarVisita
            // 
            this.dataGridEditarVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEditarVisita.Location = new System.Drawing.Point(39, 28);
            this.dataGridEditarVisita.Name = "dataGridEditarVisita";
            this.dataGridEditarVisita.Size = new System.Drawing.Size(1022, 213);
            this.dataGridEditarVisita.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rb0Deshabilitado);
            this.groupBox2.Controls.Add(this.rb1Habilitado);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtIdServicioE);
            this.groupBox2.Controls.Add(this.dateTerminoE);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateInicioE);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtIdActividadE);
            this.groupBox2.Location = new System.Drawing.Point(39, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Actividad ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Estado";
            // 
            // rb0Deshabilitado
            // 
            this.rb0Deshabilitado.AutoSize = true;
            this.rb0Deshabilitado.Location = new System.Drawing.Point(241, 121);
            this.rb0Deshabilitado.Name = "rb0Deshabilitado";
            this.rb0Deshabilitado.Size = new System.Drawing.Size(89, 17);
            this.rb0Deshabilitado.TabIndex = 67;
            this.rb0Deshabilitado.TabStop = true;
            this.rb0Deshabilitado.Text = "Deshabilitado";
            this.rb0Deshabilitado.UseVisualStyleBackColor = true;
            this.rb0Deshabilitado.CheckedChanged += new System.EventHandler(this.rb0Deshabilitado_CheckedChanged);
            // 
            // rb1Habilitado
            // 
            this.rb1Habilitado.AutoSize = true;
            this.rb1Habilitado.Location = new System.Drawing.Point(140, 121);
            this.rb1Habilitado.Name = "rb1Habilitado";
            this.rb1Habilitado.Size = new System.Drawing.Size(72, 17);
            this.rb1Habilitado.TabIndex = 66;
            this.rb1Habilitado.TabStop = true;
            this.rb1Habilitado.Text = "Habilitado";
            this.rb1Habilitado.UseVisualStyleBackColor = true;
            this.rb1Habilitado.CheckedChanged += new System.EventHandler(this.rb1Habilitado_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "ID Servicio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "Fecha Termino";
            // 
            // txtIdServicioE
            // 
            this.txtIdServicioE.Location = new System.Drawing.Point(140, 83);
            this.txtIdServicioE.Name = "txtIdServicioE";
            this.txtIdServicioE.Size = new System.Drawing.Size(217, 20);
            this.txtIdServicioE.TabIndex = 64;
            this.txtIdServicioE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdServicioE_KeyPress);
            // 
            // dateTerminoE
            // 
            this.dateTerminoE.Location = new System.Drawing.Point(140, 203);
            this.dateTerminoE.Name = "dateTerminoE";
            this.dateTerminoE.Size = new System.Drawing.Size(217, 20);
            this.dateTerminoE.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Fecha Inicio";
            // 
            // dateInicioE
            // 
            this.dateInicioE.Location = new System.Drawing.Point(140, 156);
            this.dateInicioE.Name = "dateInicioE";
            this.dateInicioE.Size = new System.Drawing.Size(217, 20);
            this.dateInicioE.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "ID Actividad";
            // 
            // txtIdActividadE
            // 
            this.txtIdActividadE.Location = new System.Drawing.Point(140, 40);
            this.txtIdActividadE.Name = "txtIdActividadE";
            this.txtIdActividadE.Size = new System.Drawing.Size(217, 20);
            this.txtIdActividadE.TabIndex = 40;
            this.txtIdActividadE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdActividadE_KeyPress);
            // 
            // btnEditarVisita
            // 
            this.btnEditarVisita.Location = new System.Drawing.Point(121, 545);
            this.btnEditarVisita.Name = "btnEditarVisita";
            this.btnEditarVisita.Size = new System.Drawing.Size(213, 23);
            this.btnEditarVisita.TabIndex = 3;
            this.btnEditarVisita.Text = "Editar Actividad";
            this.btnEditarVisita.UseVisualStyleBackColor = true;
            this.btnEditarVisita.Click += new System.EventHandler(this.btnEditarVisita_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalC);
            this.tabPage3.Controls.Add(this.lblTotalA);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dataGridChecklist);
            this.tabPage3.Controls.Add(this.dataGridAsistencia);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1230, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visualizar Visita";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalC
            // 
            this.lblTotalC.AutoSize = true;
            this.lblTotalC.Location = new System.Drawing.Point(983, 550);
            this.lblTotalC.Name = "lblTotalC";
            this.lblTotalC.Size = new System.Drawing.Size(31, 13);
            this.lblTotalC.TabIndex = 66;
            this.lblTotalC.Text = "Total";
            // 
            // lblTotalA
            // 
            this.lblTotalA.AutoSize = true;
            this.lblTotalA.Location = new System.Drawing.Point(983, 280);
            this.lblTotalA.Name = "lblTotalA";
            this.lblTotalA.Size = new System.Drawing.Size(31, 13);
            this.lblTotalA.TabIndex = 65;
            this.lblTotalA.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Checklist";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Asistencia";
            // 
            // dataGridChecklist
            // 
            this.dataGridChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChecklist.Location = new System.Drawing.Point(39, 315);
            this.dataGridChecklist.Name = "dataGridChecklist";
            this.dataGridChecklist.Size = new System.Drawing.Size(1012, 213);
            this.dataGridChecklist.TabIndex = 1;
            // 
            // dataGridAsistencia
            // 
            this.dataGridAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAsistencia.Location = new System.Drawing.Point(39, 47);
            this.dataGridAsistencia.Name = "dataGridAsistencia";
            this.dataGridAsistencia.Size = new System.Drawing.Size(1012, 213);
            this.dataGridAsistencia.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblTotalEliminar);
            this.tabPage4.Controls.Add(this.btnEliminarVisita);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.dataGridEliminarVista);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1230, 702);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Visita";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblTotalEliminar
            // 
            this.lblTotalEliminar.AutoSize = true;
            this.lblTotalEliminar.Location = new System.Drawing.Point(787, 275);
            this.lblTotalEliminar.Name = "lblTotalEliminar";
            this.lblTotalEliminar.Size = new System.Drawing.Size(31, 13);
            this.lblTotalEliminar.TabIndex = 67;
            this.lblTotalEliminar.Text = "Total";
            // 
            // btnEliminarVisita
            // 
            this.btnEliminarVisita.Location = new System.Drawing.Point(85, 419);
            this.btnEliminarVisita.Name = "btnEliminarVisita";
            this.btnEliminarVisita.Size = new System.Drawing.Size(213, 23);
            this.btnEliminarVisita.TabIndex = 65;
            this.btnEliminarVisita.Text = "Eliminar Visita";
            this.btnEliminarVisita.UseVisualStyleBackColor = true;
            this.btnEliminarVisita.Click += new System.EventHandler(this.btnEliminarVisita_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtIdVisita);
            this.groupBox3.Location = new System.Drawing.Point(38, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar una Visita";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "ID Actividad Visita";
            // 
            // txtIdVisita
            // 
            this.txtIdVisita.Location = new System.Drawing.Point(125, 36);
            this.txtIdVisita.Name = "txtIdVisita";
            this.txtIdVisita.Size = new System.Drawing.Size(148, 20);
            this.txtIdVisita.TabIndex = 0;
            this.txtIdVisita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdVisita_KeyPress);
            // 
            // dataGridEliminarVista
            // 
            this.dataGridEliminarVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEliminarVista.Location = new System.Drawing.Point(38, 34);
            this.dataGridEliminarVista.Name = "dataGridEliminarVista";
            this.dataGridEliminarVista.Size = new System.Drawing.Size(863, 213);
            this.dataGridEliminarVista.TabIndex = 3;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // frmVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 724);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVisita";
            this.Text = "Gestionar Visita";
            this.Load += new System.EventHandler(this.frmVisita_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditarVisita)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsistencia)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEliminarVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridChecklist;
        private System.Windows.Forms.DataGridView dataGridAsistencia;
        private System.Windows.Forms.Button btnCrearActividadALL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNombreTipoActividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorTotalPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtDescActividad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescServicio;
        private System.Windows.Forms.TextBox txtDescPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTerminoALL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateInicioALL;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridEliminarVista;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridEditarVisita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateInicioE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdActividadE;
        private System.Windows.Forms.Button btnEditarVisita;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEliminarVisita;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdVisita;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIdServicioE;
        private System.Windows.Forms.DateTimePicker dateTerminoE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb0Deshabilitado;
        private System.Windows.Forms.RadioButton rb1Habilitado;
        private System.Windows.Forms.Label lblTotalE;
        private System.Windows.Forms.Label lblTotalC;
        private System.Windows.Forms.Label lblTotalA;
        private System.Windows.Forms.Label lblTotalEliminar;
    }
}