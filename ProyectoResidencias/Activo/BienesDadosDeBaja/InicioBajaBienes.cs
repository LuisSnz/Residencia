﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Activo.BienesDadosDeBaja
{
    public partial class InicioBajaBienes : Form
    {
        public InicioBajaBienes()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Activo.BienesDadosDeBaja.Modificar modificar = new Activo.BienesDadosDeBaja.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(DGBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Activo.BienesDadosDeBaja.Buscar buscar = new Activo.BienesDadosDeBaja.Buscar();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(DGBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void InicioBajaBienes_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
                " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
                "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
                "AS Modelo, RTRIM(MotivoBaja) AS Motivo, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
                "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes";
            Clases.LLenadoGrids.llenarGrid(DGBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(DGBaja);
        }

        private void DGBaja_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.referencia = DGBaja.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.desc = DGBaja.CurrentRow.Cells[13].Value.ToString();
            Clases.Variables.desc2 = DGBaja.CurrentRow.Cells[15].Value.ToString();
            Clases.Variables.desc3 = DGBaja.CurrentRow.Cells[17].Value.ToString();
        }

        private void DGBaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Activo.BienesDadosDeBaja.Modificar modificar = new Activo.BienesDadosDeBaja.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(DGBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BienesDadosDeBaja.RVBienesBaja reporte = new RVBienesBaja();
            reporte.ShowDialog();
        }
    }
}
