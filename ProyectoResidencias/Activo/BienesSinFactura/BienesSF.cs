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
    public partial class BienesSF : Form
    {
        public BienesSF()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Nuevo Nuevo = new Nuevo();
            Nuevo.ShowDialog();
            if (Nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Modificar modificar = new Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Buscar buscar = new Buscar();
            buscar.ShowDialog();

            if (buscar.DialogResult == DialogResult.OK)
            {
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
            };
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(dataGridView1);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Baja baja = new CBienes.Botones.Baja();
            baja.ShowDialog();
            if (baja.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ProyectoResidencias.CBienes.CambiodeBienes.PorEmpleados porempleado = 
                new ProyectoResidencias.CBienes.CambiodeBienes.PorEmpleados();
            porempleado.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ProyectoResidencias.CBienes.CambiodeBienes.PorBienSeleccionados porbienseleccionado = 
                new ProyectoResidencias.CBienes.CambiodeBienes.PorBienSeleccionados();
            porbienseleccionado.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }
    }
}
