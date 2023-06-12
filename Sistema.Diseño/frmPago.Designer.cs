namespace Sistema.Diseño
{
    partial class frmPago
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
            this.lblTotalRegPago = new System.Windows.Forms.Label();
            this.btnActualizarRegistrosGP = new System.Windows.Forms.Button();
            this.DgvListadoPagos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscarRutGP = new System.Windows.Forms.Button();
            this.txtRutBuscarGP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1231, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalRegPago);
            this.tabPage1.Controls.Add(this.btnActualizarRegistrosGP);
            this.tabPage1.Controls.Add(this.DgvListadoPagos);
            this.tabPage1.Controls.Add(this.btnBuscarRutGP);
            this.tabPage1.Controls.Add(this.txtRutBuscarGP);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1223, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar Pagos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalRegPago
            // 
            this.lblTotalRegPago.AutoSize = true;
            this.lblTotalRegPago.Location = new System.Drawing.Point(1080, 397);
            this.lblTotalRegPago.Name = "lblTotalRegPago";
            this.lblTotalRegPago.Size = new System.Drawing.Size(81, 13);
            this.lblTotalRegPago.TabIndex = 38;
            this.lblTotalRegPago.Text = "Total Registros:";
            // 
            // btnActualizarRegistrosGP
            // 
            this.btnActualizarRegistrosGP.Location = new System.Drawing.Point(884, 393);
            this.btnActualizarRegistrosGP.Name = "btnActualizarRegistrosGP";
            this.btnActualizarRegistrosGP.Size = new System.Drawing.Size(169, 23);
            this.btnActualizarRegistrosGP.TabIndex = 37;
            this.btnActualizarRegistrosGP.Text = "Actualizar Registros";
            this.btnActualizarRegistrosGP.UseVisualStyleBackColor = true;
            this.btnActualizarRegistrosGP.Click += new System.EventHandler(this.btnActualizarRegistrosGP_Click);
            // 
            // DgvListadoPagos
            // 
            this.DgvListadoPagos.AllowUserToAddRows = false;
            this.DgvListadoPagos.AllowUserToDeleteRows = false;
            this.DgvListadoPagos.AllowUserToOrderColumns = true;
            this.DgvListadoPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoPagos.Location = new System.Drawing.Point(17, 72);
            this.DgvListadoPagos.Name = "DgvListadoPagos";
            this.DgvListadoPagos.ReadOnly = true;
            this.DgvListadoPagos.Size = new System.Drawing.Size(1191, 308);
            this.DgvListadoPagos.TabIndex = 34;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btnBuscarRutGP
            // 
            this.btnBuscarRutGP.Location = new System.Drawing.Point(328, 21);
            this.btnBuscarRutGP.Name = "btnBuscarRutGP";
            this.btnBuscarRutGP.Size = new System.Drawing.Size(169, 23);
            this.btnBuscarRutGP.TabIndex = 33;
            this.btnBuscarRutGP.Text = "Buscar";
            this.btnBuscarRutGP.UseVisualStyleBackColor = true;
            this.btnBuscarRutGP.Click += new System.EventHandler(this.btnBuscarRutGP_Click);
            // 
            // txtRutBuscarGP
            // 
            this.txtRutBuscarGP.Location = new System.Drawing.Point(82, 24);
            this.txtRutBuscarGP.Name = "txtRutBuscarGP";
            this.txtRutBuscarGP.Size = new System.Drawing.Size(222, 20);
            this.txtRutBuscarGP.TabIndex = 32;
            this.txtRutBuscarGP.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutBuscarGP_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ingrese Rut";
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 460);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPago";
            this.Text = "Gestionar Pagos";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTotalRegPago;
        private System.Windows.Forms.Button btnActualizarRegistrosGP;
        private System.Windows.Forms.DataGridView DgvListadoPagos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnBuscarRutGP;
        private System.Windows.Forms.TextBox txtRutBuscarGP;
        private System.Windows.Forms.Label label7;
    }
}