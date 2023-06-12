using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Diseño.Reportes
{
    public partial class frmReporteFolder : Form
    {
        public frmReporteFolder()
        {
            InitializeComponent();
        }

        private void frmReporteFolder_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetSistema.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetSistema.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
