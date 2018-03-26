using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Cat.Articulos
{
    public partial class CatArticulos : Form
    {
        public CatArticulos()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Cat.Articulos.Botones.Nuevo nuevo = new Catalogos.Cat.Articulos.Botones.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Cat.Articulos.Botones.Modificar modificar = new Catalogos.Cat.Articulos.Botones.Modificar();
            modificar.ShowDialog();
        }
    }
}
