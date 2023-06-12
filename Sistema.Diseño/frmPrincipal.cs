using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Diseño
{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
     
        public string rutUsuario;
        public string nombreUsuario;
        public string apellidoUsuario;
        public int telefonoUsuario;
        public string correoUsuario;
        public string domicilioUsuario;
        public int habilitado;
        public string tipo;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            StBarraInferior.Text = "Duoc UC Portafolio de Titulo 2020, Usuario Administrador :" + " " + this.nombreUsuario + " " + this.apellidoUsuario;
            MessageBox.Show("Bienvenido : " + this.tipo + " " + this.nombreUsuario + " " + this.apellidoUsuario, "Sistema de No Más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.tipo.Equals("Administrador"))
            {
                MenuGestionar.Visible = true;
                MenuReporte.Visible = true;
                MenuServicios.Visible = true;
                //MenuAlertas.Visible = true;
                MenuPerfil.Visible = true;
                MenuSalir.Visible = true;

                btnClientes.Visible = true;
                btnProfesional.Visible = true;
            }
            else
            {
                if (this.tipo.Equals("Cliente"))
                {
                    MenuGestionar.Visible = false;
                    MenuReporte.Visible = false;
                    MenuServicios.Visible = false;
                    //MenuAlertas.Visible = false;
                    MenuPerfil.Visible = false;
                    MenuSalir.Visible = false;

                    btnClientes.Visible = false;
                    btnProfesional.Visible = false;
                }
                else
                {
                    if (this.tipo.Equals("Profesional"))
                    {
                        MenuGestionar.Visible = false;
                        MenuReporte.Visible = false;
                        MenuServicios.Visible = false;
                        //MenuAlertas.Visible = false;
                        MenuPerfil.Visible = false;
                        MenuSalir.Visible = false;

                        btnClientes.Visible = false;
                        btnProfesional.Visible = false;
                    }
                    else
                    {
                        MenuGestionar.Visible = false;
                        MenuReporte.Visible = false;
                        MenuServicios.Visible = false;
                        //MenuAlertas.Visible = false;
                        MenuPerfil.Visible = false;
                        MenuSalir.Visible = false;

                        btnClientes.Visible = false;
                        btnProfesional.Visible = false;
                    }
                }
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void gestionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea salir del Sistema?", "Sistema No más Accidentes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Cerrar del Sesion?", "Sistema No más Accidentes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //FUTURO
        }

        private void gestionarProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesional frm = new frmProfesional();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProfesional_Click(object sender, EventArgs e)
        {
            frmProfesional frm = new frmProfesional();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gestionarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContrato frm = new frmContrato();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gestionarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPago frm = new frmPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void controlarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio frm = new frmServicio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGContratos_Click(object sender, EventArgs e)
        {
            frmContrato frm = new frmContrato();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGPagos_Click(object sender, EventArgs e)
        {
            frmPago frm = new frmPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCServicios_Click(object sender, EventArgs e)
        {
            frmServicio frm = new frmServicio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
