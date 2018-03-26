using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Activo.Familias
{
    public partial class Familia : Form
    {
        public Familia()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Familias.Nuevo nuevo = new Catalogos.Activo.Familias.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Familias.Modificar modificar = new Catalogos.Activo.Familias.Modificar();
            modificar.ShowDialog();
        }
    }
}
