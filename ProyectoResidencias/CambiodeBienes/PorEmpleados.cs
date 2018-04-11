using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.CBienes.CambiodeBienes
{
    public partial class PorEmpleados : Form
    {
        public PorEmpleados()
        {
            InitializeComponent();
        }

        private void PorEmpleados_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombre(CBNombreActual);
            Clases.Empleados.CBNombre(CBNombreNuevo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("f");
        }
    }
}
