using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Nuevo nuevo = new Catalogos.Proveedores.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Modificar modificar = new Catalogos.Proveedores.Modificar();
            modificar.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Buscar buscar = new Buscar();
            buscar.ShowDialog();
        }
    }
}
