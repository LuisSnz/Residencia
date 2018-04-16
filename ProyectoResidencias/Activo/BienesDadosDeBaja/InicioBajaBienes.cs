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
    public partial class InicioBajaBienes : Form
    {
        public InicioBajaBienes()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Activo.BienesDadosDeBaja.Modificar modificar = new Activo.BienesDadosDeBaja.Modificar();
            modificar.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Activo.BienesDadosDeBaja.Buscar buscar = new Activo.BienesDadosDeBaja.Buscar();
            buscar.ShowDialog();
        }

        private void InicioBajaBienes_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(DGBaja, "Select * from BajaBienes", "BajaBienes");
        }
    }
}
