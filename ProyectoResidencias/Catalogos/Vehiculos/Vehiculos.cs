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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }
        
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Catalogos.Vehiculos.ReporteVehiculos reporteVehiculos = new ReporteVehiculos();
            reporteVehiculos.ShowDialog();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GVVehiculos, "select Numero,Placas,Modelo,Tipo,Subtipo,Marca,NoSerie,Familia,Resguardo,Departamento,Observacion from vVehiculos order by id", "vVehiculos");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(GVVehiculos);
        }
    }
}
