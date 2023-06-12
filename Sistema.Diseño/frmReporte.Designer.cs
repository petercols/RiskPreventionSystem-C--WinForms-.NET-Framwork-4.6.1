namespace Sistema.Diseño
{
    partial class frmReporte
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDescripInforme = new System.Windows.Forms.TextBox();
            this.txtNombreInforme = new System.Windows.Forms.TextBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dataSetSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSistema = new Sistema.Diseño.Reportes.DataSetSistema();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRutUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorTotalPago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSistema)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.fechaEmision);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtDescripInforme);
            this.groupBox1.Controls.Add(this.txtNombreInforme);
            this.groupBox1.Location = new System.Drawing.Point(482, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 235);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Reporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(125, 88);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(176, 20);
            this.txtArchivo.TabIndex = 33;
            // 
            // fechaEmision
            // 
            this.fechaEmision.Location = new System.Drawing.Point(126, 153);
            this.fechaEmision.Name = "fechaEmision";
            this.fechaEmision.Size = new System.Drawing.Size(176, 20);
            this.fechaEmision.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Informe";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Fecha Emision";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Descripcion Informe";
            // 
            // txtDescripInforme
            // 
            this.txtDescripInforme.Location = new System.Drawing.Point(125, 117);
            this.txtDescripInforme.Name = "txtDescripInforme";
            this.txtDescripInforme.Size = new System.Drawing.Size(176, 20);
            this.txtDescripInforme.TabIndex = 22;
            // 
            // txtNombreInforme
            // 
            this.txtNombreInforme.Location = new System.Drawing.Point(125, 59);
            this.txtNombreInforme.Name = "txtNombreInforme";
            this.txtNombreInforme.Size = new System.Drawing.Size(176, 20);
            this.txtNombreInforme.TabIndex = 1;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.Location = new System.Drawing.Point(566, 279);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(186, 23);
            this.btnCrearReporte.TabIndex = 34;
            this.btnCrearReporte.Text = "Insertar Reporte";
            this.btnCrearReporte.UseVisualStyleBackColor = true;
            this.btnCrearReporte.Click += new System.EventHandler(this.btnCrearReporte_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(566, 353);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(186, 23);
            this.btnGenerarReporte.TabIndex = 37;
            this.btnGenerarReporte.Text = "Generar Reporte ";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // dataSetSistemaBindingSource
            // 
            this.dataSetSistemaBindingSource.DataSource = this.dataSetSistema;
            this.dataSetSistemaBindingSource.Position = 0;
            // 
            // dataSetSistema
            // 
            this.dataSetSistema.DataSetName = "DataSetSistema";
            this.dataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRutUsuario);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTerminoALL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateInicioALL);
            this.groupBox2.Controls.Add(this.txtDescPago);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDescActividad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDescServicio);
            this.groupBox2.Controls.Add(this.cmbNombreTipoActividad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtValorTotalPago);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNombreServicio);
            this.groupBox2.Location = new System.Drawing.Point(26, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 598);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Reporte";
            // 
            // txtRutUsuario
            // 
            this.txtRutUsuario.Location = new System.Drawing.Point(138, 41);
            this.txtRutUsuario.Name = "txtRutUsuario";
            this.txtRutUsuario.Size = new System.Drawing.Size(219, 20);
            this.txtRutUsuario.TabIndex = 64;
            this.txtRutUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutUsuario_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Rut Usuario";
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
            "Reporte"});
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Valor Total";
            // 
            // txtValorTotalPago
            // 
            this.txtValorTotalPago.Location = new System.Drawing.Point(140, 127);
            this.txtValorTotalPago.Name = "txtValorTotalPago";
            this.txtValorTotalPago.Size = new System.Drawing.Size(217, 20);
            this.txtValorTotalPago.TabIndex = 44;
            this.txtValorTotalPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotalPago_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Nombre Servicio";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(140, 84);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(217, 20);
            this.txtNombreServicio.TabIndex = 42;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnCrearReporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporte";
            this.Text = "Generar Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSistema)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.DateTimePicker fechaEmision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDescripInforme;
        private System.Windows.Forms.TextBox txtNombreInforme;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.BindingSource dataSetSistemaBindingSource;
        private Reportes.DataSetSistema dataSetSistema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTerminoALL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateInicioALL;
        private System.Windows.Forms.TextBox txtDescPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescActividad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescServicio;
        private System.Windows.Forms.ComboBox cmbNombreTipoActividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorTotalPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtRutUsuario;
        private System.Windows.Forms.Label label1;
    }
}