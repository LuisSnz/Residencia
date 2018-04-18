using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.CBienes.Reportes
{
    public partial class HistoricoDelBien : Form
    {
        public HistoricoDelBien()
        {
            InitializeComponent();
        }

        private void HistoricoDelBien_Load(object sender, EventArgs e)
        {
            Clases.Bienes.CBEtiqueta(Etiqueta);
            Clases.Variables.ConsultaBuscar = "Select HistoricoBienes.Etiqueta, empleados.Nombre, HistoricoBienes.FechaCambio" +
                " from HistoricoBienes inner join empleados on HistoricoBienes.NoEmpleado=empleados.NoEmp";
            Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar,"HistoricoBienes");
        }

        private void Etiqueta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "Select HistoricoBienes.Etiqueta, empleados.Nombre, HistoricoBienes.FechaCambio" +
                " from HistoricoBienes inner join empleados on HistoricoBienes.NoEmpleado=empleados.NoEmp where HistoricoBienes.Etiqueta="+Etiqueta.SelectedItem.ToString();
            Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "HistoricoBienes");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (Etiqueta.FindString(Etiqueta.Text) >= 0)
            {
                Clases.Variables.ConsultaBuscar = "Select HistoricoBienes.Etiqueta, empleados.Nombre, HistoricoBienes.FechaCambio" +
                " from HistoricoBienes inner join empleados on HistoricoBienes.NoEmpleado=empleados.NoEmp where HistoricoBienes.Etiqueta=" + Etiqueta.Text;
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "HistoricoBienes");
            }
            else
                MessageBox.Show("El valor tecleado no es valido");
        }
    }
}
