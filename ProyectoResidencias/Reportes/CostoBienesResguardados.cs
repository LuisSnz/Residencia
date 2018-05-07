﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace ProyectoResidencias.CBienes.Reportes
{
    public partial class CostoBienesResguardados : Form
    {
        public CostoBienesResguardados()
        {
            InitializeComponent();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            ProyectoResidencias.Reportes.RVCostoBienes reporte = new ProyectoResidencias.Reportes.RVCostoBienes();
            reporte.ShowDialog();
        }

        private void CostoBienesResguardados_Load(object sender, EventArgs e)
        {
            GridCosto.Height = Clases.Variables.GridHeight - 40;
            label1.Location = new Point(20, Clases.Variables.GridHeight + 30);
            Total.Location = new Point(140, Clases.Variables.GridHeight + 30);
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, dbo.CatArticulos.Descripcion AS Articulo," +
               "Familia.Descripcion as Familia, empleados.Nombre AS Empleado,bienes.Total " +
               "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
               "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
               "CatArticulos.IdFamilia = Familia.Id";
            Clases.LLenadoGrids.llenarGrid(GridCosto, Clases.Variables.ConsultaBuscar, "bienes");
            Clases.Bienes.Suma(Total);
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(GridCosto);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            ProyectoResidencias.Reportes.BuscarPorBienes buscar = new ProyectoResidencias.Reportes.BuscarPorBienes();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
            {
                Clases.LLenadoGrids.llenarGrid(GridCosto, Clases.Variables.ConsultaBuscar, "bienes");
                float x=0;
                foreach (DataGridViewRow row in GridCosto.Rows)
                {
                    x = x + float.Parse(row.Cells[4].Value.ToString());
                }
                Total.Text = x.ToString("C");
            }
        }
    }
}
