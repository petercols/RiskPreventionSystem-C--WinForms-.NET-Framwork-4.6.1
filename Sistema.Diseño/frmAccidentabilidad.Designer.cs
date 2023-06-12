namespace Sistema.Diseño
{
    partial class frmAccidentabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccidentabilidad));
            this.dataGridAccidentes = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalE = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultAcc = new System.Windows.Forms.TextBox();
            this.txtN_Trabajadores = new System.Windows.Forms.TextBox();
            this.txtN_Accidentes = new System.Windows.Forms.TextBox();
            this.btnCalAccidentabilidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccidentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAccidentes
            // 
            this.dataGridAccidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccidentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridAccidentes.Location = new System.Drawing.Point(24, 23);
            this.dataGridAccidentes.Name = "dataGridAccidentes";
            this.dataGridAccidentes.Size = new System.Drawing.Size(1188, 330);
            this.dataGridAccidentes.TabIndex = 1;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // lblTotalE
            // 
            this.lblTotalE.AutoSize = true;
            this.lblTotalE.Location = new System.Drawing.Point(1118, 365);
            this.lblTotalE.Name = "lblTotalE";
            this.lblTotalE.Size = new System.Drawing.Size(31, 13);
            this.lblTotalE.TabIndex = 65;
            this.lblTotalE.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResultAcc);
            this.groupBox1.Controls.Add(this.txtN_Trabajadores);
            this.groupBox1.Controls.Add(this.txtN_Accidentes);
            this.groupBox1.Controls.Add(this.btnCalAccidentabilidad);
            this.groupBox1.Location = new System.Drawing.Point(24, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 208);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accidentabilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "N°Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N°Accidentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado de Accidentabilidad";
            // 
            // txtResultAcc
            // 
            this.txtResultAcc.Location = new System.Drawing.Point(345, 157);
            this.txtResultAcc.Name = "txtResultAcc";
            this.txtResultAcc.Size = new System.Drawing.Size(250, 20);
            this.txtResultAcc.TabIndex = 3;
            // 
            // txtN_Trabajadores
            // 
            this.txtN_Trabajadores.Location = new System.Drawing.Point(94, 97);
            this.txtN_Trabajadores.Name = "txtN_Trabajadores";
            this.txtN_Trabajadores.Size = new System.Drawing.Size(192, 20);
            this.txtN_Trabajadores.TabIndex = 2;
            // 
            // txtN_Accidentes
            // 
            this.txtN_Accidentes.Location = new System.Drawing.Point(94, 41);
            this.txtN_Accidentes.Name = "txtN_Accidentes";
            this.txtN_Accidentes.Size = new System.Drawing.Size(192, 20);
            this.txtN_Accidentes.TabIndex = 1;
            // 
            // btnCalAccidentabilidad
            // 
            this.btnCalAccidentabilidad.Location = new System.Drawing.Point(94, 157);
            this.btnCalAccidentabilidad.Name = "btnCalAccidentabilidad";
            this.btnCalAccidentabilidad.Size = new System.Drawing.Size(192, 23);
            this.btnCalAccidentabilidad.TabIndex = 0;
            this.btnCalAccidentabilidad.Text = "Calcular Accidentabilidad";
            this.btnCalAccidentabilidad.UseVisualStyleBackColor = true;
            this.btnCalAccidentabilidad.Click += new System.EventHandler(this.btnCalAccidentabilidad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 117);
            this.label2.TabIndex = 67;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // frmAccidentabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalE);
            this.Controls.Add(this.dataGridAccidentes);
            this.Name = "frmAccidentabilidad";
            this.Text = "Gestionar Accidentabilidad";
            this.Load += new System.EventHandler(this.frmAccidentabilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccidentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAccidentes;
        private System.Windows.Forms.Label lblTotalE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtN_Accidentes;
        private System.Windows.Forms.Button btnCalAccidentabilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN_Trabajadores;
        private System.Windows.Forms.TextBox txtResultAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}