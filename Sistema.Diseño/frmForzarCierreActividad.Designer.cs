namespace Sistema.Diseño
{
    partial class frmForzarCierreActividad
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
            this.txtIdActividad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxContrato = new System.Windows.Forms.GroupBox();
            this.rbSi1 = new System.Windows.Forms.RadioButton();
            this.rbNo0 = new System.Windows.Forms.RadioButton();
            this.btnConfirmarEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.groupBoxContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdActividad
            // 
            this.txtIdActividad.Location = new System.Drawing.Point(110, 47);
            this.txtIdActividad.Name = "txtIdActividad";
            this.txtIdActividad.Size = new System.Drawing.Size(152, 20);
            this.txtIdActividad.TabIndex = 26;
            this.txtIdActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdActividad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Actividad";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // groupBoxContrato
            // 
            this.groupBoxContrato.Controls.Add(this.rbSi1);
            this.groupBoxContrato.Controls.Add(this.rbNo0);
            this.groupBoxContrato.Location = new System.Drawing.Point(49, 112);
            this.groupBoxContrato.Name = "groupBoxContrato";
            this.groupBoxContrato.Size = new System.Drawing.Size(265, 100);
            this.groupBoxContrato.TabIndex = 27;
            this.groupBoxContrato.TabStop = false;
            this.groupBoxContrato.Text = "¿Forzar Cierre de Actividad?";
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
            // btnConfirmarEstado
            // 
            this.btnConfirmarEstado.Location = new System.Drawing.Point(117, 261);
            this.btnConfirmarEstado.Name = "btnConfirmarEstado";
            this.btnConfirmarEstado.Size = new System.Drawing.Size(149, 23);
            this.btnConfirmarEstado.TabIndex = 28;
            this.btnConfirmarEstado.Text = "Confirmar";
            this.btnConfirmarEstado.UseVisualStyleBackColor = true;
            this.btnConfirmarEstado.Click += new System.EventHandler(this.btnConfirmarEstado_Click);
            // 
            // frmForzarCierreActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 338);
            this.Controls.Add(this.btnConfirmarEstado);
            this.Controls.Add(this.groupBoxContrato);
            this.Controls.Add(this.txtIdActividad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmForzarCierreActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forzar Cierre Actividad";
            this.Load += new System.EventHandler(this.frmForzarCierreActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.groupBoxContrato.ResumeLayout(false);
            this.groupBoxContrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.GroupBox groupBoxContrato;
        public System.Windows.Forms.RadioButton rbSi1;
        public System.Windows.Forms.RadioButton rbNo0;
        private System.Windows.Forms.Button btnConfirmarEstado;
    }
}