﻿using System;
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
            Activo.BienesSinFactura.Nuevo Nuevo = new Nuevo();
            Nuevo.ShowDialog();
            if (Nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Modificar modificar = new Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Buscar buscar = new Buscar();
            buscar.ShowDialog();

            if (buscar.DialogResult == DialogResult.OK)
            {
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
            };
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(dataGridView1);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Baja baja = new CBienes.Botones.Baja();
            baja.ShowDialog();
            if (baja.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ProyectoResidencias.CBienes.CambiodeBienes.PorEmpleados porempleado = 
                new ProyectoResidencias.CBienes.CambiodeBienes.PorEmpleados();
            porempleado.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ProyectoResidencias.CBienes.CambiodeBienes.PorBienSeleccionados porbienseleccionado = 
                new ProyectoResidencias.CBienes.CambiodeBienes.PorBienSeleccionados();
            porbienseleccionado.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void BienesSF_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, " +
                "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where nofactura=''";
            Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.ReporteBienesSF reporteBienesSF = new ReporteBienesSF();
            reporteBienesSF.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridView1.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.lbOrdenCompra = filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.tbArticulo = filaSeleccionada.Cells[5].Value.ToString();
            Clases.Variables.tbObservacion = filaSeleccionada.Cells[10].Value.ToString();
            Clases.Variables.tbResguardoA = filaSeleccionada.Cells[6].Value.ToString();
            Clases.Variables.tbDepartamentoA = filaSeleccionada.Cells[7].Value.ToString();
            Clases.Variables.desc2 = filaSeleccionada.Cells[8].Value.ToString();
            Clases.Variables.desc3 = filaSeleccionada.Cells[3].Value.ToString();
            Clases.Variables.Familia = filaSeleccionada.Cells[4].Value.ToString();
        }
    }
}
