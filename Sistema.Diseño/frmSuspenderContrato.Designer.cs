namespace Sistema.Diseño
{
    partial class frmSuspenderContrato
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
            this.rbNo0 = new System.Windows.Forms.RadioButton();
            this.rbSi1 = new System.Windows.Forms.RadioButton();
            this.txtRutSuspender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbNO_0 = new System.Windows.Forms.RadioButton();
            this.rbSI_1 = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado2 = new System.Windows.Forms.RadioButton();
            this.groupBoxModificar = new System.Windows.Forms.GroupBox();
            this.groupBoxContrato = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.groupBoxModificar.SuspendLayout();
            this.groupBoxContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNo0
            // 
            this.rbNo0.AutoSize = true;
            this.rbNo0.Location = new System.Drawing.Point(85, 38);
            this.rbNo0.Name = "rbNo0";
            this.rbNo0.Size = new System.Drawing.Size(79, 17);
            this.rbNo0.TabIndex = 11;
            this.rbNo0.TabStop = true;
            this.rbNo0.Text = "No Pagado";
            this.rbNo0.UseVisualStyleBackColor = true;
            this.rbNo0.CheckedChanged += new System.EventHandler(this.rbNo0_CheckedChanged);
            // 
            // rbSi1
            // 
            this.rbSi1.AutoSize = true;
            this.rbSi1.Location = new System.Drawing.Point(6, 38);
            this.rbSi1.Name = "rbSi1";
            this.rbSi1.Size = new System.Drawing.Size(55, 17);
            this.rbSi1.TabIndex = 10;
            this.rbSi1.TabStop = true;
            this.rbSi1.Text = "Activo";
            this.rbSi1.UseVisualStyleBackColor = true;
            this.rbSi1.CheckedChanged += new System.EventHandler(this.rbSi1_CheckedChanged);
            // 
            // txtRutSuspender
            // 
            this.txtRutSuspender.Location = new System.Drawing.Point(116, 59);
            this.txtRutSuspender.Name = "txtRutSuspender";
            this.txtRutSuspender.Size = new System.Drawing.Size(143, 20);
            this.txtRutSuspender.TabIndex = 9;
            this.txtRutSuspender.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutSuspender_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rut Cliente";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(116, 386);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(149, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // rbNO_0
            // 
            this.rbNO_0.AutoSize = true;
            this.rbNO_0.Location = new System.Drawing.Point(128, 38);
            this.rbNO_0.Name = "rbNO_0";
            this.rbNO_0.Size = new System.Drawing.Size(39, 17);
            this.rbNO_0.TabIndex = 14;
            this.rbNO_0.TabStop = true;
            this.rbNO_0.Text = "No";
            this.rbNO_0.UseVisualStyleBackColor = true;
            this.rbNO_0.CheckedChanged += new System.EventHandler(this.rbNO_0_CheckedChanged);
            // 
            // rbSI_1
            // 
            this.rbSI_1.AutoSize = true;
            this.rbSI_1.Location = new System.Drawing.Point(24, 38);
            this.rbSI_1.Name = "rbSI_1";
            this.rbSI_1.Size = new System.Drawing.Size(34, 17);
            this.rbSI_1.TabIndex = 13;
            this.rbSI_1.TabStop = true;
            this.rbSI_1.Text = "Si";
            this.rbSI_1.UseVisualStyleBackColor = true;
            this.rbSI_1.CheckedChanged += new System.EventHandler(this.rbSI_1_CheckedChanged);
            // 
            // rbDeshabilitado2
            // 
            this.rbDeshabilitado2.AutoSize = true;
            this.rbDeshabilitado2.Location = new System.Drawing.Point(170, 38);
            this.rbDeshabilitado2.Name = "rbDeshabilitado2";
            this.rbDeshabilitado2.Size = new System.Drawing.Size(89, 17);
            this.rbDeshabilitado2.TabIndex = 15;
            this.rbDeshabilitado2.TabStop = true;
            this.rbDeshabilitado2.Text = "Deshabilitado";
            this.rbDeshabilitado2.UseVisualStyleBackColor = true;
            this.rbDeshabilitado2.CheckedChanged += new System.EventHandler(this.rbDeshabilitado2_CheckedChanged);
            // 
            // groupBoxModificar
            // 
            this.groupBoxModificar.Controls.Add(this.rbSI_1);
            this.groupBoxModificar.Controls.Add(this.rbNO_0);
            this.groupBoxModificar.Location = new System.Drawing.Point(63, 242);
            this.groupBoxModificar.Name = "groupBoxModificar";
            this.groupBoxModificar.Size = new System.Drawing.Size(265, 100);
            this.groupBoxModificar.TabIndex = 16;
            this.groupBoxModificar.TabStop = false;
            this.groupBoxModificar.Text = "¿Modificar Contrato?";
            // 
            // groupBoxContrato
            // 
            this.groupBoxContrato.Controls.Add(this.rbSi1);
            this.groupBoxContrato.Controls.Add(this.rbNo0);
            this.groupBoxContrato.Controls.Add(this.rbDeshabilitado2);
            this.groupBoxContrato.Location = new System.Drawing.Point(57, 107);
            this.groupBoxContrato.Name = "groupBoxContrato";
            this.groupBoxContrato.Size = new System.Drawing.Size(265, 100);
            this.groupBoxContrato.TabIndex = 17;
            this.groupBoxContrato.TabStop = false;
            this.groupBoxContrato.Text = "¿Estado Contrato?";
            // 
            // frmSuspenderContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 469);
            this.Controls.Add(this.groupBoxContrato);
            this.Controls.Add(this.groupBoxModificar);
            this.Controls.Add(this.txtRutSuspender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSuspenderContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suspender Contrato";
            this.Load += new System.EventHandler(this.frmSuspenderContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.groupBoxModificar.ResumeLayout(false);
            this.groupBoxModificar.PerformLayout();
            this.groupBoxContrato.ResumeLayout(false);
            this.groupBoxContrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbNo0;
        public System.Windows.Forms.RadioButton rbSi1;
        public System.Windows.Forms.TextBox txtRutSuspender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        public System.Windows.Forms.RadioButton rbDeshabilitado2;
        public System.Windows.Forms.RadioButton rbNO_0;
        public System.Windows.Forms.RadioButton rbSI_1;
        private System.Windows.Forms.GroupBox groupBoxContrato;
        private System.Windows.Forms.GroupBox groupBoxModificar;
    }
}