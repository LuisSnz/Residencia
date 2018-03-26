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
            Activo.BienesSinFactura.Nuevo form = new Nuevo();
            form.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Modificar form = new Modificar();
            form.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Buscar form = new Buscar();
            form.ShowDialog();
        }
    }
}
