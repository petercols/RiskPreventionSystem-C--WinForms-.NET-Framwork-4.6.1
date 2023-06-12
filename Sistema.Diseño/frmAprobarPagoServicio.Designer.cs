namespace Sistema.Diseño
{
    partial class frmAprobarPagoServicio
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
            this.txtRutUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxContrato = new System.Windows.Forms.GroupBox();
            this.rbSi1 = new System.Windows.Forms.RadioButton();
            this.rbNo0 = new System.Windows.Forms.RadioButton();
            this.btnConfirmarAS = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutUsuario
            // 
            this.txtRutUsuario.Location = new System.Drawing.Point(124, 47);
            this.txtRutUsuario.Name = "txtRutUsuario";
            this.txtRutUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtRutUsuario.TabIndex = 26;
            this.txtRutUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutUsuario_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Rut Usuario";
            // 
            // groupBoxContrato
            // 
            this.groupBoxContrato.Controls.Add(this.rbSi1);
            this.groupBoxContrato.Controls.Add(this.rbNo0);
            this.groupBoxContrato.Location = new System.Drawing.Point(68, 145);
            this.groupBoxContrato.Name = "groupBoxContrato";
            this.groupBoxContrato.Size = new System.Drawing.Size(265, 100);
            this.groupBoxContrato.TabIndex = 27;
            this.groupBoxContrato.TabStop = false;
            this.groupBoxContrato.Text = "¿Estado De Pago Servicio?";
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
            // 
            // btnConfirmarAS
            // 
            this.btnConfirmarAS.Location = new System.Drawing.Point(124, 293);
            this.btnConfirmarAS.Name = "btnConfirmarAS";
            this.btnConfirmarAS.Size = new System.Drawing.Size(149, 23);
            this.btnConfirmarAS.TabIndex = 28;
            this.btnConfirmarAS.Text = "Confirmar";
            this.btnConfirmarAS.UseVisualStyleBackColor = true;
            this.btnConfirmarAS.Click += new System.EventHandler(this.btnConfirmarAS_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Location = new System.Drawing.Point(124, 105);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(152, 20);
            this.txtIdServicio.TabIndex = 30;
            this.txtIdServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdServicio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID Servicio";
            // 
            // frmAprobarPagoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 391);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmarAS);
            this.Controls.Add(this.groupBoxContrato);
            this.Controls.Add(this.txtRutUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAprobarPagoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobar PagoServicio";
            this.Load += new System.EventHandler(this.frmAprobarPagoServicio_Load);
            this.groupBoxContrato.ResumeLayout(false);
            this.groupBoxContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxContrato;
        public System.Windows.Forms.RadioButton rbSi1;
        public System.Windows.Forms.RadioButton rbNo0;
        private System.Windows.Forms.Button btnConfirmarAS;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.Label label2;
    }
}