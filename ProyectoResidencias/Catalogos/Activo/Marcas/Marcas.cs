using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Activo.Marcas
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Marcas.Nuevo nuevo = new Catalogos.Activo.Marcas.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Marcas.Modificar modificar = new Catalogos.Activo.Marcas.Modificar();
            modificar.ShowDialog();
        }
    }
}
