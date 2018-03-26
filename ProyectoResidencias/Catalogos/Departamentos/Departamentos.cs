using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Departamentos
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Departamentos.Nuevo nuevo = new Catalogos.Departamentos.Nuevo();
            nuevo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Departamentos.Modificar modificar = new Catalogos.Departamentos.Modificar();
            modificar.ShowDialog();
        }
    }
}
