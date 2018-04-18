using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Activo.BienesSinFactura
{
    public partial class ReporteBienesSF : Form
    {
        public ReporteBienesSF()
        {
            InitializeComponent();
        }

        private void ReporteBienesSF_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
