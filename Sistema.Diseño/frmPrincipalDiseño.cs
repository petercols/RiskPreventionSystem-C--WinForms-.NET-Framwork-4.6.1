using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

//using System.Data;
using System.Data.OracleClient;
using Sistema.Datos;
using System.Collections;

namespace Sistema.Diseño
{
    public partial class frmPrincipalDiseño : Form
    {

        public string rutUsuario;
        public string nombreUsuario;
        public string apellidoUsuario;
        public int telefonoUsuario;
        public string correoUsuario;
        public string domicilioUsuario;
        public int habilitado;
        public string tipo;

        //Estadisticas 00 & 01
        ArrayList Usuario = new ArrayList();
        ArrayList Pago = new ArrayList();
        public void graficoRutxTotal()
        {
            OracleDataReader Resultado;
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("DATOS_ESTADISTICA_E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ESTADISTICA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                while (Resultado.Read())
                {
                    Usuario.Add(Resultado.GetString(0));
                    Pago.Add(Resultado.GetInt32(1));
                }
                Grafico00.Series[0].Points.DataBindXY(Usuario, Pago);
                Grafico01.Series[0].Points.DataBindXY(Usuario, Pago);
                //Grafico02.Series[0].Points.DataBindXY(Usuario, Pago);
                Resultado.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
        }
        //Estadisticas 01
        //GRAFICO
        ArrayList Usuario1 = new ArrayList();
        ArrayList fechaA = new ArrayList();
        public void graficoRutxFechaA()
        {
            OracleDataReader Resultado;
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("DATOS_ESTADISTICA_1E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ESTADISTICA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                while (Resultado.Read())
                {
                    Usuario1.Add(Resultado.GetString(0));
                    fechaA.Add(Resultado.GetDateTime(1));
                }
                GraficoDash00.Series[0].Points.DataBindXY(Usuario1, fechaA);
                GraficoDash01.Series[0].Points.DataBindXY(Usuario1, fechaA);

                //Grafico02.Series[0].Points.DataBindXY(Usuario, Pago);
                Resultado.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
        }
        //Estadisticas 02
        //GRAFICO
        ArrayList UsuarioEmpresa = new ArrayList();
        ArrayList FechaA2 = new ArrayList();    
        public void graficoRutEmpresaFechaA()
        {
            OracleDataReader Resultado;
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("DATOS_ESTADISTICA_2E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ESTADISTICA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                while (Resultado.Read())
                {
                    UsuarioEmpresa.Add(Resultado.GetString(0));
                    FechaA2.Add(Resultado.GetDateTime(1));
                }

                GraficoDash02.Series[0].Points.DataBindXY(UsuarioEmpresa, FechaA2);
                GraficoDash03.Series[0].Points.DataBindXY(UsuarioEmpresa, FechaA2);

                Resultado.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
        }
        //Estadisticas 03
        //GRAFICO
        ArrayList Usuario2 = new ArrayList();
        ArrayList FechaC = new ArrayList();
        public void graficoRutUsuarioFechaC()
        {
            OracleDataReader Resultado;
            OracleConnection OracleCon = new OracleConnection();
            try
            {
                OracleCon = ConexionOracle.getInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("DATOS_ESTADISTICA_3E", OracleCon);
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.Add("OUT_CURSOR_ESTADISTICA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleCon.Open();
                Resultado = Comando.ExecuteReader();
                while (Resultado.Read())
                {
                    Usuario2.Add(Resultado.GetInt32(0));
                    FechaC.Add(Resultado.GetDateTime(1));
                }

                GraficoDash04.Series[0].Points.DataBindXY(Usuario2, FechaC);
                

                Resultado.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (OracleCon.State == ConnectionState.Open) OracleCon.Close();
            }
        }


        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public frmPrincipalDiseño()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Estadisticas
            graficoRutxTotal();
            graficoRutxFechaA();
            graficoRutEmpresaFechaA();
            graficoRutUsuarioFechaC();
            //Form
            this.subMenuGUsuarios.Visible = false;
            this.subMenuGContratos.Visible = false;

            //this.subMenuPerfilUsuario.Visible = false;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(30, 30, 45);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 30, 45);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChild.Text = childForm.Text;
            //subMenuGUsuarios.Controls.Add(childForm);
            //subMenuGUsuarios.Tag = childForm;
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;

            //subMenuPerfilUsuario.Visible = false;

            //subMenuGUsuarios.BringToFront();
            //subMenuGUsuarios.Show();
        }
        private void hideMenu()
        {
            if(subMenuGUsuarios.Visible == true)
            {
                subMenuGUsuarios.Visible = false;
            }
            if (subMenuGContratos.Visible == true)
            {
                subMenuGContratos.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
            }
            else
            {
                subMenu.Visible = false;
            }
        }  
        private void btnPerfilIcono_Click(object sender, EventArgs e)
        {
            //subMenuPerfilUsuario.Visible = true;
            //btnperfilUserPestaña.Visible = true;
            //ActivateButton(sender, RGBColors.color1);

        }

        //private void OpenChildForm
        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color1);
            subMenuGUsuarios.Visible = true;
            //OpenChildForm(new frmEmpresa());
        }
        //Sub botones
        private void btnCliente_Click(object sender, EventArgs e)
        {
            subMenuGContratos.Visible = false;
            //ActivateButton(sender, RGBColors.color1);
            subMenuGUsuarios.Visible = true;
            OpenChildForm(new frmEmpresa());
        }
        //Sub botones
        private void btnProfesional_Click(object sender, EventArgs e)
        {
            subMenuGContratos.Visible = false;
            //ActivateButton(sender, RGBColors.color1);
            subMenuGUsuarios.Visible = true;
            OpenChildForm(new frmProfesional());
        }

        private void btnGestionarContratos_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = true;
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new frmContrato());    
        }
        private void btnContratos_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = true;
            OpenChildForm(new frmContrato());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = true;
            OpenChildForm(new frmPago());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = true;
            OpenChildForm(new frmServicio());
        }

        private void btnGestionarActividades_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmActividad());
        }

        private void btnGestionarAccidentabilidad_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmAccidentabilidad());
        }

        private void btnGestionarVisitas_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmVisita());
        }

        private void btnGestionarReportes_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new frmReporte());
        }

        private void btnGestionarEstadisticas_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmEstadistica());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color6);

            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea salir del Sistema?", "Sistema No más Accidentes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            ActivateButton(sender, RGBColors.color6);

            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Cerrar del Sesion?", "Sistema No más Accidentes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            currentChildForm.Close();
            Reset();
        }
        private void lblInicio_Click(object sender, EventArgs e)
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            subMenuGUsuarios.Visible = false;
            subMenuGContratos.Visible = false;
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChild.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPrincipalDiseño_Load(object sender, EventArgs e)
        {
            StBarraInferior.Text = "Duoc UC Portafolio de Titulo 2020, Usuario Administrador :" + " " + this.nombreUsuario + " " + this.apellidoUsuario;
            MessageBox.Show("Bienvenido : " + this.tipo + " " + this.nombreUsuario + " " + this.apellidoUsuario, "Sistema de No Más Accidentes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.tipo.Equals("Administrador"))
            {
                btnGestionarUsuarios.Visible = true;
                btnGestionarContratos.Visible = true;
                btnGestionarActividades.Visible = true;
                btnGestionarVisitas.Visible = true;
                btnGestionarReportes.Visible = true;
                btnGestionarEstadisticas.Visible = true;
            }
            else
            {
                if (this.tipo.Equals("Cliente"))
                {
                    btnGestionarUsuarios.Visible = false;
                    btnGestionarContratos.Visible = false;
                    btnGestionarActividades.Visible = false;
                    btnGestionarVisitas.Visible = false;
                    btnGestionarReportes.Visible = false;
                    btnGestionarEstadisticas.Visible = false;
                }
                else
                {
                    if (this.tipo.Equals("Profesional"))
                    {
                        btnGestionarUsuarios.Visible = false;
                        btnGestionarContratos.Visible = false;
                        btnGestionarActividades.Visible = false;
                        btnGestionarVisitas.Visible = false;
                        btnGestionarReportes.Visible = false;
                        btnGestionarEstadisticas.Visible = false;
                    }
                    else
                    {
                        btnGestionarUsuarios.Visible = false;
                        btnGestionarContratos.Visible = false;
                        btnGestionarActividades.Visible = false;
                        btnGestionarVisitas.Visible = false;
                        btnGestionarReportes.Visible = false;
                        btnGestionarEstadisticas.Visible = false;
                    }
                }
            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            //graficoRutxTotal();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void StBarraInferior_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
