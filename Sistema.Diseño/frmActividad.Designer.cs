namespace Sistema.Diseño
{
    partial class frmActividad
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
            this.chkboxSeleccionarAct = new System.Windows.Forms.CheckBox();
            this.btnForzarCierreAc = new System.Windows.Forms.Button();
            this.btnActualizarRegistrosAC = new System.Windows.Forms.Button();
            this.lblTotalAC = new System.Windows.Forms.Label();
            this.DgvListadoActividad = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkboxSeleccionarAct);
            this.tabPage1.Controls.Add(this.btnForzarCierreAc);
            this.tabPage1.Controls.Add(this.btnActualizarRegistrosAC);
            this.tabPage1.Controls.Add(this.lblTotalAC);
            this.tabPage1.Controls.Add(this.DgvListadoActividad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar Actividades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkboxSeleccionarAct
            // 
            this.chkboxSeleccionarAct.AutoSize = true;
            this.chkboxSeleccionarAct.Location = new System.Drawing.Point(17, 367);
            this.chkboxSeleccionarAct.Name = "chkboxSeleccionarAct";
            this.chkboxSeleccionarAct.Size = new System.Drawing.Size(82, 17);
            this.chkboxSeleccionarAct.TabIndex = 32;
            this.chkboxSeleccionarAct.Text = "Seleccionar";
            this.chkboxSeleccionarAct.UseVisualStyleBackColor = true;
            this.chkboxSeleccionarAct.CheckedChanged += new System.EventHandler(this.chkboxSeleccionarAct_CheckedChanged);
            // 
            // btnForzarCierreAc
            // 
            this.btnForzarCierreAc.Location = new System.Drawing.Point(159, 363);
            this.btnForzarCierreAc.Name = "btnForzarCierreAc";
            this.btnForzarCierreAc.Size = new System.Drawing.Size(169, 23);
            this.btnForzarCierreAc.TabIndex = 31;
            this.btnForzarCierreAc.Text = "Forzar Cierre Actividad";
            this.btnForzarCierreAc.UseVisualStyleBackColor = true;
            this.btnForzarCierreAc.Click += new System.EventHandler(this.btnForzarCierreAc_Click);
            // 
            // btnActualizarRegistrosAC
            // 
            this.btnActualizarRegistrosAC.Location = new System.Drawing.Point(813, 361);
            this.btnActualizarRegistrosAC.Name = "btnActualizarRegistrosAC";
            this.btnActualizarRegistrosAC.Size = new System.Drawing.Size(169, 23);
            this.btnActualizarRegistrosAC.TabIndex = 30;
            this.btnActualizarRegistrosAC.Text = "Actualizar Registros";
            this.btnActualizarRegistrosAC.UseVisualStyleBackColor = true;
            this.btnActualizarRegistrosAC.Click += new System.EventHandler(this.btnActualizarRegistrosAC_Click);
            // 
            // lblTotalAC
            // 
            this.lblTotalAC.AutoSize = true;
            this.lblTotalAC.Location = new System.Drawing.Point(1054, 368);
            this.lblTotalAC.Name = "lblTotalAC";
            this.lblTotalAC.Size = new System.Drawing.Size(78, 13);
            this.lblTotalAC.TabIndex = 29;
            this.lblTotalAC.Text = "Total Registros";
            // 
            // DgvListadoActividad
            // 
            this.DgvListadoActividad.AllowUserToAddRows = false;
            this.DgvListadoActividad.AllowUserToDeleteRows = false;
            this.DgvListadoActividad.AllowUserToOrderColumns = true;
            this.DgvListadoActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoActividad.Location = new System.Drawing.Point(17, 17);
            this.DgvListadoActividad.Name = "DgvListadoActividad";
            this.DgvListadoActividad.ReadOnly = true;
            this.DgvListadoActividad.Size = new System.Drawing.Size(1200, 330);
            this.DgvListadoActividad.TabIndex = 28;
            this.DgvListadoActividad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoActividad_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // frmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 429);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmActividad";
            this.Text = "Gestionar Actividad";
            this.Load += new System.EventHandler(this.frmActividad_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkboxSeleccionarAct;
        private System.Windows.Forms.Button btnActualizarRegistrosAC;
        private System.Windows.Forms.Label lblTotalAC;
        private System.Windows.Forms.DataGridView DgvListadoActividad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnForzarCierreAc;
    }
}