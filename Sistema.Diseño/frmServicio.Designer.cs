namespace Sistema.Diseño
{
    partial class frmServicio
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAprobarPago = new System.Windows.Forms.Button();
            this.chkboxSeleccionarS = new System.Windows.Forms.CheckBox();
            this.btnSuspenderS = new System.Windows.Forms.Button();
            this.btnBuscarRutS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRutBuscarS = new System.Windows.Forms.TextBox();
            this.btnActualizarRegistrosS = new System.Windows.Forms.Button();
            this.lblTotalServicio = new System.Windows.Forms.Label();
            this.DgvListadoServicio = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAprobarPago);
            this.tabPage1.Controls.Add(this.chkboxSeleccionarS);
            this.tabPage1.Controls.Add(this.btnSuspenderS);
            this.tabPage1.Controls.Add(this.btnBuscarRutS);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtRutBuscarS);
            this.tabPage1.Controls.Add(this.btnActualizarRegistrosS);
            this.tabPage1.Controls.Add(this.lblTotalServicio);
            this.tabPage1.Controls.Add(this.DgvListadoServicio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1221, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edicion de Estado de Servicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAprobarPago
            // 
            this.btnAprobarPago.Location = new System.Drawing.Point(430, 394);
            this.btnAprobarPago.Name = "btnAprobarPago";
            this.btnAprobarPago.Size = new System.Drawing.Size(169, 23);
            this.btnAprobarPago.TabIndex = 28;
            this.btnAprobarPago.Text = "Aprobar Pago Servicio";
            this.btnAprobarPago.UseVisualStyleBackColor = true;
            this.btnAprobarPago.Click += new System.EventHandler(this.btnAprobarPago_Click);
            // 
            // chkboxSeleccionarS
            // 
            this.chkboxSeleccionarS.AutoSize = true;
            this.chkboxSeleccionarS.Location = new System.Drawing.Point(18, 394);
            this.chkboxSeleccionarS.Name = "chkboxSeleccionarS";
            this.chkboxSeleccionarS.Size = new System.Drawing.Size(82, 17);
            this.chkboxSeleccionarS.TabIndex = 27;
            this.chkboxSeleccionarS.Text = "Seleccionar";
            this.chkboxSeleccionarS.UseVisualStyleBackColor = true;
            this.chkboxSeleccionarS.CheckedChanged += new System.EventHandler(this.chkboxSeleccionarS_CheckedChanged);
            // 
            // btnSuspenderS
            // 
            this.btnSuspenderS.Location = new System.Drawing.Point(179, 394);
            this.btnSuspenderS.Name = "btnSuspenderS";
            this.btnSuspenderS.Size = new System.Drawing.Size(169, 23);
            this.btnSuspenderS.TabIndex = 26;
            this.btnSuspenderS.Text = "Editar";
            this.btnSuspenderS.UseVisualStyleBackColor = true;
            this.btnSuspenderS.Click += new System.EventHandler(this.btnSuspenderS_Click);
            // 
            // btnBuscarRutS
            // 
            this.btnBuscarRutS.Location = new System.Drawing.Point(306, 13);
            this.btnBuscarRutS.Name = "btnBuscarRutS";
            this.btnBuscarRutS.Size = new System.Drawing.Size(169, 23);
            this.btnBuscarRutS.TabIndex = 25;
            this.btnBuscarRutS.Text = "Buscar";
            this.btnBuscarRutS.UseVisualStyleBackColor = true;
            this.btnBuscarRutS.Click += new System.EventHandler(this.btnBuscarRutS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ingrese Rut";
            // 
            // txtRutBuscarS
            // 
            this.txtRutBuscarS.Location = new System.Drawing.Point(94, 15);
            this.txtRutBuscarS.Name = "txtRutBuscarS";
            this.txtRutBuscarS.Size = new System.Drawing.Size(180, 20);
            this.txtRutBuscarS.TabIndex = 23;
            this.txtRutBuscarS.Validated += new System.EventHandler(this.txtRutBuscarS_Validated);
            // 
            // btnActualizarRegistrosS
            // 
            this.btnActualizarRegistrosS.Location = new System.Drawing.Point(884, 394);
            this.btnActualizarRegistrosS.Name = "btnActualizarRegistrosS";
            this.btnActualizarRegistrosS.Size = new System.Drawing.Size(169, 23);
            this.btnActualizarRegistrosS.TabIndex = 22;
            this.btnActualizarRegistrosS.Text = "Actualizar Registros";
            this.btnActualizarRegistrosS.UseVisualStyleBackColor = true;
            this.btnActualizarRegistrosS.Click += new System.EventHandler(this.btnActualizarRegistrosS_Click);
            // 
            // lblTotalServicio
            // 
            this.lblTotalServicio.AutoSize = true;
            this.lblTotalServicio.Location = new System.Drawing.Point(1076, 399);
            this.lblTotalServicio.Name = "lblTotalServicio";
            this.lblTotalServicio.Size = new System.Drawing.Size(78, 13);
            this.lblTotalServicio.TabIndex = 21;
            this.lblTotalServicio.Text = "Total Registros";
            // 
            // DgvListadoServicio
            // 
            this.DgvListadoServicio.AllowUserToAddRows = false;
            this.DgvListadoServicio.AllowUserToDeleteRows = false;
            this.DgvListadoServicio.AllowUserToOrderColumns = true;
            this.DgvListadoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoServicio.Location = new System.Drawing.Point(18, 58);
            this.DgvListadoServicio.Name = "DgvListadoServicio";
            this.DgvListadoServicio.ReadOnly = true;
            this.DgvListadoServicio.Size = new System.Drawing.Size(1188, 330);
            this.DgvListadoServicio.TabIndex = 20;
            this.DgvListadoServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoServicio_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 460);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmServicio";
            this.Text = "Controlar Servicios";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkboxSeleccionarS;
        private System.Windows.Forms.Button btnSuspenderS;
        private System.Windows.Forms.Button btnBuscarRutS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRutBuscarS;
        private System.Windows.Forms.Button btnActualizarRegistrosS;
        private System.Windows.Forms.Label lblTotalServicio;
        private System.Windows.Forms.DataGridView DgvListadoServicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnAprobarPago;
    }
}