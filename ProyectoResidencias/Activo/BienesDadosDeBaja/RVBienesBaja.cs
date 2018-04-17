using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Activo.BienesDadosDeBaja
{
    public partial class RVBienesBaja : Form
    {
        public RVBienesBaja()
        {
            InitializeComponent();
        }

        private void RVBienesBaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'activoJcasDataSet.BajaBienes' Puede moverla o quitarla según sea necesario.
            this.bajaBienesTableAdapter.Fill(this.activoJcasDataSet.BajaBienes);

            this.reportViewer1.RefreshReport();
        }
    }
}
