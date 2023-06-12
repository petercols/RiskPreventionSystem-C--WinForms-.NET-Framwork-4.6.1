namespace Sistema.Diseño
{
    partial class frmEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Grafico02 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grafico01 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarGrafica = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.Grafico00 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico01)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico00)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Grafico02);
            this.tabPage3.Controls.Add(this.Grafico01);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1221, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visualizar Estadistica";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // Grafico02
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafico02.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Grafico02.Legends.Add(legend2);
            this.Grafico02.Location = new System.Drawing.Point(600, 43);
            this.Grafico02.Name = "Grafico02";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Grafico02.Series.Add(series2);
            this.Grafico02.Size = new System.Drawing.Size(496, 321);
            this.Grafico02.TabIndex = 1;
            this.Grafico02.Text = "chart1";
            // 
            // Grafico01
            // 
            this.Grafico01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.Grafico01.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.Grafico01.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea3.Name = "ChartArea1";
            this.Grafico01.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Grafico01.Legends.Add(legend3);
            this.Grafico01.Location = new System.Drawing.Point(40, 43);
            this.Grafico01.Name = "Grafico01";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Grafico01.Series.Add(series3);
            this.Grafico01.Size = new System.Drawing.Size(496, 321);
            this.Grafico01.TabIndex = 0;
            this.Grafico01.Text = "Grafico01";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnGuardarGrafica);
            this.tabPage1.Controls.Add(this.btnGraficar);
            this.tabPage1.Controls.Add(this.Grafico00);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1221, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Estadistica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rut Usuario - Pago Total Servicio";
            // 
            // btnGuardarGrafica
            // 
            this.btnGuardarGrafica.Location = new System.Drawing.Point(339, 363);
            this.btnGuardarGrafica.Name = "btnGuardarGrafica";
            this.btnGuardarGrafica.Size = new System.Drawing.Size(187, 23);
            this.btnGuardarGrafica.TabIndex = 34;
            this.btnGuardarGrafica.Text = "Guardar Grafica";
            this.btnGuardarGrafica.UseVisualStyleBackColor = true;
            this.btnGuardarGrafica.Click += new System.EventHandler(this.btnGuardarGrafica_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(47, 363);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(187, 23);
            this.btnGraficar.TabIndex = 33;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // Grafico00
            // 
            this.Grafico00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.Grafico00.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.Grafico00.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea1.Name = "ChartArea1";
            this.Grafico00.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico00.Legends.Add(legend1);
            this.Grafico00.Location = new System.Drawing.Point(47, 53);
            this.Grafico00.Name = "Grafico00";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafico00.Series.Add(series1);
            this.Grafico00.Size = new System.Drawing.Size(479, 290);
            this.Grafico00.TabIndex = 32;
            this.Grafico00.Text = "Usuario - Pago";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage3);
            this.tabGeneral.Location = new System.Drawing.Point(1, 1);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1229, 458);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Tag = "";
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 460);
            this.Controls.Add(this.tabGeneral);
            this.Name = "frmEstadistica";
            this.Text = "Gestionar Estadistica";
            this.Load += new System.EventHandler(this.frmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafico02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico01)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico00)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGuardarGrafica;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico00;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico02;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico01;
        private System.Windows.Forms.Label label1;
    }
}