using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Activo
{
    public partial class ImprimirEtiquetas : Form
    {
        public ImprimirEtiquetas()
        {
            InitializeComponent();
        }

        private void ImprimirEtiquetas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Etiquetas.ImprimirEtiquetas(printDialog1, minimo.Value.ToString(), maximo.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
