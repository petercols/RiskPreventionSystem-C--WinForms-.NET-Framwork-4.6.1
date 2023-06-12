namespace Sistema.Diseño
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip MenuGeneral;
            this.MenuGestionar = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProfesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarAccidentabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEstadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StBarraInferior = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCServicios = new System.Windows.Forms.Button();
            this.btnProfesional = new System.Windows.Forms.Button();
            this.btnGPagos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGContratos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            MenuGeneral = new System.Windows.Forms.MenuStrip();
            MenuGeneral.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGeneral
            // 
            MenuGeneral.BackColor = System.Drawing.Color.White;
            MenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGestionar,
            this.MenuServicios,
            this.gestionarAccidentabilidadToolStripMenuItem,
            this.gestionarActividadesToolStripMenuItem,
            this.MenuSalir,
            this.MenuPerfil,
            this.gestionarVisitasToolStripMenuItem,
            this.MenuReporte,
            this.gestionarEstadisticasToolStripMenuItem});
            MenuGeneral.Location = new System.Drawing.Point(0, 0);
            MenuGeneral.Name = "MenuGeneral";
            MenuGeneral.Size = new System.Drawing.Size(1500, 24);
            MenuGeneral.TabIndex = 0;
            MenuGeneral.Text = "MenuStrip";
            MenuGeneral.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // MenuGestionar
            // 
            this.MenuGestionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClienteToolStripMenuItem,
            this.gestionarProfesionalToolStripMenuItem});
            this.MenuGestionar.Name = "MenuGestionar";
            this.MenuGestionar.Size = new System.Drawing.Size(117, 20);
            this.MenuGestionar.Text = "Gestionar Usuarios";
            // 
            // gestionarClienteToolStripMenuItem
            // 
            this.gestionarClienteToolStripMenuItem.Name = "gestionarClienteToolStripMenuItem";
            this.gestionarClienteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionarClienteToolStripMenuItem.Text = "Gestionar Cliente";
            this.gestionarClienteToolStripMenuItem.Click += new System.EventHandler(this.gestionarClienteToolStripMenuItem_Click);
            // 
            // gestionarProfesionalToolStripMenuItem
            // 
            this.gestionarProfesionalToolStripMenuItem.Name = "gestionarProfesionalToolStripMenuItem";
            this.gestionarProfesionalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionarProfesionalToolStripMenuItem.Text = "Gestionar Profesional";
            this.gestionarProfesionalToolStripMenuItem.Click += new System.EventHandler(this.gestionarProfesionalToolStripMenuItem_Click);
            // 
            // MenuServicios
            // 
            this.MenuServicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarContratosToolStripMenuItem,
            this.gestionarPagosToolStripMenuItem,
            this.controlarServiciosToolStripMenuItem});
            this.MenuServicios.Name = "MenuServicios";
            this.MenuServicios.Size = new System.Drawing.Size(127, 20);
            this.MenuServicios.Text = "Gestionar Contratos ";
            // 
            // gestionarContratosToolStripMenuItem
            // 
            this.gestionarContratosToolStripMenuItem.Name = "gestionarContratosToolStripMenuItem";
            this.gestionarContratosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarContratosToolStripMenuItem.Text = "Gestionar Contratos";
            this.gestionarContratosToolStripMenuItem.Click += new System.EventHandler(this.gestionarContratosToolStripMenuItem_Click);
            // 
            // gestionarPagosToolStripMenuItem
            // 
            this.gestionarPagosToolStripMenuItem.Name = "gestionarPagosToolStripMenuItem";
            this.gestionarPagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarPagosToolStripMenuItem.Text = "Gestionar Pagos";
            this.gestionarPagosToolStripMenuItem.Click += new System.EventHandler(this.gestionarPagosToolStripMenuItem_Click);
            // 
            // controlarServiciosToolStripMenuItem
            // 
            this.controlarServiciosToolStripMenuItem.Name = "controlarServiciosToolStripMenuItem";
            this.controlarServiciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controlarServiciosToolStripMenuItem.Text = "Controlar Servicios";
            this.controlarServiciosToolStripMenuItem.Click += new System.EventHandler(this.controlarServiciosToolStripMenuItem_Click);
            // 
            // gestionarAccidentabilidadToolStripMenuItem
            // 
            this.gestionarAccidentabilidadToolStripMenuItem.Name = "gestionarAccidentabilidadToolStripMenuItem";
            this.gestionarAccidentabilidadToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.gestionarAccidentabilidadToolStripMenuItem.Text = "Gestionar Accidentabilidad";
            // 
            // gestionarActividadesToolStripMenuItem
            // 
            this.gestionarActividadesToolStripMenuItem.Name = "gestionarActividadesToolStripMenuItem";
            this.gestionarActividadesToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.gestionarActividadesToolStripMenuItem.Text = "Gestionar Actividades";
            // 
            // MenuSalir
            // 
            this.MenuSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.cerrarSistemaToolStripMenuItem});
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(41, 20);
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MenuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cerrarSistemaToolStripMenuItem
            // 
            this.cerrarSistemaToolStripMenuItem.Name = "cerrarSistemaToolStripMenuItem";
            this.cerrarSistemaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSistemaToolStripMenuItem.Text = "Cerrar Sistema";
            this.cerrarSistemaToolStripMenuItem.Click += new System.EventHandler(this.cerrarSistemaToolStripMenuItem_Click);
            // 
            // MenuPerfil
            // 
            this.MenuPerfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuPerfil.Name = "MenuPerfil";
            this.MenuPerfil.Size = new System.Drawing.Size(89, 20);
            this.MenuPerfil.Text = "Perfil Usuario";
            // 
            // gestionarVisitasToolStripMenuItem
            // 
            this.gestionarVisitasToolStripMenuItem.Name = "gestionarVisitasToolStripMenuItem";
            this.gestionarVisitasToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.gestionarVisitasToolStripMenuItem.Text = "Gestionar Visitas";
            // 
            // MenuReporte
            // 
            this.MenuReporte.Name = "MenuReporte";
            this.MenuReporte.Size = new System.Drawing.Size(109, 20);
            this.MenuReporte.Text = "Generar Reportes";
            this.MenuReporte.Click += new System.EventHandler(this.MenuReporte_Click);
            // 
            // gestionarEstadisticasToolStripMenuItem
            // 
            this.gestionarEstadisticasToolStripMenuItem.Name = "gestionarEstadisticasToolStripMenuItem";
            this.gestionarEstadisticasToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.gestionarEstadisticasToolStripMenuItem.Text = "Gestionar Estadisticas";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StBarraInferior});
            this.statusStrip.Location = new System.Drawing.Point(0, 778);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1500, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StBarraInferior
            // 
            this.StBarraInferior.Name = "StBarraInferior";
            this.StBarraInferior.Size = new System.Drawing.Size(185, 17);
            this.StBarraInferior.Text = "Duoc UC Portafolio de Titulo 2020";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnCServicios);
            this.panel1.Controls.Add(this.btnProfesional);
            this.panel1.Controls.Add(this.btnGPagos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGContratos);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 748);
            this.panel1.TabIndex = 4;
            // 
            // btnCServicios
            // 
            this.btnCServicios.FlatAppearance.BorderSize = 0;
            this.btnCServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCServicios.ForeColor = System.Drawing.Color.Black;
            this.btnCServicios.Location = new System.Drawing.Point(3, 246);
            this.btnCServicios.Name = "btnCServicios";
            this.btnCServicios.Size = new System.Drawing.Size(221, 24);
            this.btnCServicios.TabIndex = 8;
            this.btnCServicios.Text = "Controlar Servicios";
            this.btnCServicios.UseVisualStyleBackColor = true;
            this.btnCServicios.Click += new System.EventHandler(this.btnCServicios_Click);
            // 
            // btnProfesional
            // 
            this.btnProfesional.FlatAppearance.BorderSize = 0;
            this.btnProfesional.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProfesional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProfesional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesional.ForeColor = System.Drawing.Color.Black;
            this.btnProfesional.Location = new System.Drawing.Point(3, 156);
            this.btnProfesional.Name = "btnProfesional";
            this.btnProfesional.Size = new System.Drawing.Size(224, 24);
            this.btnProfesional.TabIndex = 2;
            this.btnProfesional.Text = "Profesional";
            this.btnProfesional.UseVisualStyleBackColor = true;
            this.btnProfesional.Click += new System.EventHandler(this.btnProfesional_Click);
            // 
            // btnGPagos
            // 
            this.btnGPagos.FlatAppearance.BorderSize = 0;
            this.btnGPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGPagos.ForeColor = System.Drawing.Color.Black;
            this.btnGPagos.Location = new System.Drawing.Point(3, 216);
            this.btnGPagos.Name = "btnGPagos";
            this.btnGPagos.Size = new System.Drawing.Size(221, 24);
            this.btnGPagos.TabIndex = 7;
            this.btnGPagos.Text = "Gestionar Pagos";
            this.btnGPagos.UseVisualStyleBackColor = true;
            this.btnGPagos.Click += new System.EventHandler(this.btnGPagos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Diseño.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(65, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGContratos
            // 
            this.btnGContratos.FlatAppearance.BorderSize = 0;
            this.btnGContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGContratos.ForeColor = System.Drawing.Color.Black;
            this.btnGContratos.Location = new System.Drawing.Point(6, 186);
            this.btnGContratos.Name = "btnGContratos";
            this.btnGContratos.Size = new System.Drawing.Size(221, 24);
            this.btnGContratos.TabIndex = 6;
            this.btnGContratos.Text = "Gestionar Contratos";
            this.btnGContratos.UseVisualStyleBackColor = true;
            this.btnGContratos.Click += new System.EventHandler(this.btnGContratos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Location = new System.Drawing.Point(6, 126);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(221, 24);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Cliente";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(MenuGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = MenuGeneral;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema No más Accidentes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            MenuGeneral.ResumeLayout(false);
            MenuGeneral.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StBarraInferior;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionar;
        private System.Windows.Forms.ToolStripMenuItem gestionarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuReporte;
        private System.Windows.Forms.ToolStripMenuItem MenuServicios;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuPerfil;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProfesionalToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProfesional;
        private System.Windows.Forms.ToolStripMenuItem gestionarContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarServiciosToolStripMenuItem;
        private System.Windows.Forms.Button btnCServicios;
        private System.Windows.Forms.Button btnGPagos;
        private System.Windows.Forms.Button btnGContratos;
        private System.Windows.Forms.ToolStripMenuItem gestionarAccidentabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEstadisticasToolStripMenuItem;
    }
}



