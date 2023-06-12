namespace Sistema.Diseño
{
    partial class frmSuspenderServicio
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
            this.groupBoxContrato = new System.Windows.Forms.GroupBox();
            this.rbSi1 = new System.Windows.Forms.RadioButton();
            this.rbNo0 = new System.Windows.Forms.RadioButton();
            this.groupBoxModificar = new System.Windows.Forms.GroupBox();
            this.rbSI_1 = new System.Windows.Forms.RadioButton();
            this.rbNO_0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarSS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateFechaUPDS = new System.Windows.Forms.DateTimePicker();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIDeditarS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDfolio = new System.Windows.Forms.TextBox();
            this.groupBoxContrato.SuspendLayout();
            this.groupBoxModificar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContrato
            // 
            this.groupBoxContrato.Controls.Add(this.rbSi1);
            this.groupBoxContrato.Controls.Add(this.rbNo0);
            this.groupBoxContrato.Location = new System.Drawing.Point(70, 294);
            this.groupBoxContrato.Name = "groupBoxContrato";
            this.groupBoxContrato.Size = new System.Drawing.Size(265, 100);
            this.groupBoxContrato.TabIndex = 22;
            this.groupBoxContrato.TabStop = false;
            this.groupBoxContrato.Text = "¿Estado Servicio?";
            // 
            // rbSi1
            // 
            this.rbSi1.AutoSize = true;
            this.rbSi1.Location = new System.Drawing.Point(24, 38);
            this.rbSi1.Name = "rbSi1";
            this.rbSi1.Size = new System.Drawing.Size(55, 17);
            this.rbSi1.TabIndex = 10;
            this.rbSi1.TabStop = true;
            this.rbSi1.Text = "Activo";
            this.rbSi1.UseVisualStyleBackColor = true;
            this.rbSi1.CheckedChanged += new System.EventHandler(this.rbSi1_CheckedChanged);
            // 
            // rbNo0
            // 
            this.rbNo0.AutoSize = true;
            this.rbNo0.Location = new System.Drawing.Point(128, 38);
            this.rbNo0.Name = "rbNo0";
            this.rbNo0.Size = new System.Drawing.Size(89, 17);
            this.rbNo0.TabIndex = 11;
            this.rbNo0.TabStop = true;
            this.rbNo0.Text = "Deshabilitado";
            this.rbNo0.UseVisualStyleBackColor = true;
            this.rbNo0.CheckedChanged += new System.EventHandler(this.rbNo0_CheckedChanged);
            // 
            // groupBoxModificar
            // 
            this.groupBoxModificar.Controls.Add(this.rbSI_1);
            this.groupBoxModificar.Controls.Add(this.rbNO_0);
            this.groupBoxModificar.Location = new System.Drawing.Point(70, 439);
            this.groupBoxModificar.Name = "groupBoxModificar";
            this.groupBoxModificar.Size = new System.Drawing.Size(265, 100);
            this.groupBoxModificar.TabIndex = 21;
            this.groupBoxModificar.TabStop = false;
            this.groupBoxModificar.Text = "¿Servicio Pagado?";
            // 
            // rbSI_1
            // 
            this.rbSI_1.AutoSize = true;
            this.rbSI_1.Location = new System.Drawing.Point(24, 38);
            this.rbSI_1.Name = "rbSI_1";
            this.rbSI_1.Size = new System.Drawing.Size(62, 17);
            this.rbSI_1.TabIndex = 13;
            this.rbSI_1.TabStop = true;
            this.rbSI_1.Text = "Pagado";
            this.rbSI_1.UseVisualStyleBackColor = true;
            this.rbSI_1.CheckedChanged += new System.EventHandler(this.rbSI_1_CheckedChanged);
            // 
            // rbNO_0
            // 
            this.rbNO_0.AutoSize = true;
            this.rbNO_0.Location = new System.Drawing.Point(128, 38);
            this.rbNO_0.Name = "rbNO_0";
            this.rbNO_0.Size = new System.Drawing.Size(79, 17);
            this.rbNO_0.TabIndex = 14;
            this.rbNO_0.TabStop = true;
            this.rbNO_0.Text = "No Pagado";
            this.rbNO_0.UseVisualStyleBackColor = true;
            this.rbNO_0.CheckedChanged += new System.EventHandler(this.rbNO_0_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Servicio";
            // 
            // btnConfirmarSS
            // 
            this.btnConfirmarSS.Location = new System.Drawing.Point(125, 560);
            this.btnConfirmarSS.Name = "btnConfirmarSS";
            this.btnConfirmarSS.Size = new System.Drawing.Size(149, 23);
            this.btnConfirmarSS.TabIndex = 18;
            this.btnConfirmarSS.Text = "Confirmar";
            this.btnConfirmarSS.UseVisualStyleBackColor = true;
            this.btnConfirmarSS.Click += new System.EventHandler(this.btnConfirmarSS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateFechaUPDS);
            this.groupBox1.Location = new System.Drawing.Point(70, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Fecha Termino?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateFechaUPDS
            // 
            this.dateFechaUPDS.Location = new System.Drawing.Point(18, 40);
            this.dateFechaUPDS.Name = "dateFechaUPDS";
            this.dateFechaUPDS.Size = new System.Drawing.Size(200, 20);
            this.dateFechaUPDS.TabIndex = 0;
            this.dateFechaUPDS.ValueChanged += new System.EventHandler(this.dateFechaUPDS_ValueChanged);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // txtIDeditarS
            // 
            this.txtIDeditarS.Location = new System.Drawing.Point(122, 85);
            this.txtIDeditarS.Name = "txtIDeditarS";
            this.txtIDeditarS.Size = new System.Drawing.Size(152, 20);
            this.txtIDeditarS.TabIndex = 24;
            this.txtIDeditarS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDeditarS_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingrese Rut";
            // 
            // txtRutUsuario
            // 
            this.txtRutUsuario.Location = new System.Drawing.Point(122, 36);
            this.txtRutUsuario.Name = "txtRutUsuario";
            this.txtRutUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtRutUsuario.TabIndex = 25;
            this.txtRutUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutUsuario_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID Folio";
            // 
            // txtIDfolio
            // 
            this.txtIDfolio.Location = new System.Drawing.Point(122, 134);
            this.txtIDfolio.Name = "txtIDfolio";
            this.txtIDfolio.Size = new System.Drawing.Size(152, 20);
            this.txtIDfolio.TabIndex = 28;
            this.txtIDfolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDfolio_KeyPress);
            // 
            // frmSuspenderServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 607);
            this.Controls.Add(this.txtIDfolio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRutUsuario);
            this.Controls.Add(this.txtIDeditarS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxContrato);
            this.Controls.Add(this.groupBoxModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmarSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSuspenderServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suspender Servicio";
            this.Load += new System.EventHandler(this.frmSuspenderServicio_Load);
            this.groupBoxContrato.ResumeLayout(false);
            this.groupBoxContrato.PerformLayout();
            this.groupBoxModificar.ResumeLayout(false);
            this.groupBoxModificar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContrato;
        public System.Windows.Forms.RadioButton rbSi1;
        public System.Windows.Forms.RadioButton rbNo0;
        private System.Windows.Forms.GroupBox groupBoxModificar;
        public System.Windows.Forms.RadioButton rbSI_1;
        public System.Windows.Forms.RadioButton rbNO_0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarSS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateFechaUPDS;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TextBox txtIDeditarS;
        private System.Windows.Forms.TextBox txtIDfolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutUsuario;
    }
}