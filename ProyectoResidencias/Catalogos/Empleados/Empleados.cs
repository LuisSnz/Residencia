using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Nuevo nuevo = new Catalogos.Empleados.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Modificar modificar = new Catalogos.Empleados.Modificar();
            modificar.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Buscar buscar = new Catalogos.Empleados.Buscar();
            buscar.ShowDialog();
        }
    }
}
