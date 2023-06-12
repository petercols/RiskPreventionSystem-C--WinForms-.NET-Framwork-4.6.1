namespace Sistema.Diseño
{
    partial class frmDeshabilitarCliente
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutDeshabilitar = new System.Windows.Forms.TextBox();
            this.rbSi1 = new System.Windows.Forms.RadioButton();
            this.rbNo0 = new System.Windows.Forms.RadioButton();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(69, 259);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(149, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Habilitar Cliente?";
            // 
            // txtRutDeshabilitar
            // 
            this.txtRutDeshabilitar.Location = new System.Drawing.Point(75, 82);
            this.txtRutDeshabilitar.Name = "txtRutDeshabilitar";
            this.txtRutDeshabilitar.Size = new System.Drawing.Size(143, 20);
            this.txtRutDeshabilitar.TabIndex = 3;
            this.txtRutDeshabilitar.Validating += new System.ComponentModel.CancelEventHandler(this.txtRutDeshabilitar_Validating);
            // 
            // rbSi1
            // 
            this.rbSi1.AutoSize = true;
            this.rbSi1.Location = new System.Drawing.Point(75, 145);
            this.rbSi1.Name = "rbSi1";
            this.rbSi1.Size = new System.Drawing.Size(34, 17);
            this.rbSi1.TabIndex = 4;
            this.rbSi1.TabStop = true;
            this.rbSi1.Text = "Si";
            this.rbSi1.UseVisualStyleBackColor = true;
            this.rbSi1.CheckedChanged += new System.EventHandler(this.rbSi1_CheckedChanged);
            // 
            // rbNo0
            // 
            this.rbNo0.AutoSize = true;
            this.rbNo0.Location = new System.Drawing.Point(179, 145);
            this.rbNo0.Name = "rbNo0";
            this.rbNo0.Size = new System.Drawing.Size(39, 17);
            this.rbNo0.TabIndex = 5;
            this.rbNo0.TabStop = true;
            this.rbNo0.Text = "No";
            this.rbNo0.UseVisualStyleBackColor = true;
            this.rbNo0.CheckedChanged += new System.EventHandler(this.rbNo0_CheckedChanged);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // frmDeshabilitarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 342);
            this.Controls.Add(this.rbNo0);
            this.Controls.Add(this.rbSi1);
            this.Controls.Add(this.txtRutDeshabilitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDeshabilitarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deshabilitar Cliente";
            this.Load += new System.EventHandler(this.frmDeshabilitarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRutDeshabilitar;
        public System.Windows.Forms.RadioButton rbSi1;
        public System.Windows.Forms.RadioButton rbNo0;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
    }
}