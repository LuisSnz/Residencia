using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.AreasODirecciones
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }
        //public static string referencia;
        //public static string desc;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.AreasODirecciones.Nuevo nuevo = new Catalogos.AreasODirecciones.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.AreasODirecciones.Modificar modificar = new Catalogos.AreasODirecciones.Modificar();
            modificar.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var filaSeleccionada = dataGridView1.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
        }
    }
}
