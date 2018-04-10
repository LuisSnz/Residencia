using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Vehiculos
{
    public partial class ReporteVehiculos : Form
    {
        public ReporteVehiculos()
        {
            InitializeComponent();
        }

        private void ReporteVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'activoJcasDataSet.vVehiculos' Puede moverla o quitarla según sea necesario.
            this.vVehiculosTableAdapter.Fill(this.activoJcasDataSet.vVehiculos);

            this.reportViewer1.RefreshReport();
        }
    }
}
