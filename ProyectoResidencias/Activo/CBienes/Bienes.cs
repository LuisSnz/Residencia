using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class Bienes : Form
    {
        public Bienes()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            CBienes.Nuevo Nuevo = new CBienes.Nuevo();
            Nuevo.ShowDialog();
            if (Nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void consultaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Modificar modificar = new CBienes.Botones.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult==DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Buscar buscar = new CBienes.Botones.Buscar();

            var result =buscar.ShowDialog();
            if (result == DialogResult.OK)
            {
                Clases.LLenadoGrids.llenarGrid(GVBienes, Clases.Variables.ConsultaBuscar, "bienes");
            }
        }

        private void Bienes_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id";
            Clases.LLenadoGrids.llenarGrid(GVBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Activo.CBienes.Botones.Baja baja = new Activo.CBienes.Botones.Baja();
            baja.ShowDialog();
            if (baja.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CBienes.CambiodeBienes.PorEmpleados porempleado = new CBienes.CambiodeBienes.PorEmpleados();
            porempleado.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CBienes.CambiodeBienes.PorBienSeleccionados porbienseleccionado = new CBienes.CambiodeBienes.PorBienSeleccionados();
            porbienseleccionado.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GVBienes,Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void GVBienes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GVBienes.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.lbOrdenCompra = filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.lbFactura = filaSeleccionada.Cells[3].Value.ToString();
            Clases.Variables.tbArticulo = filaSeleccionada.Cells[6].Value.ToString();
            Clases.Variables.tbObservacion = filaSeleccionada.Cells[11].Value.ToString();
            Clases.Variables.tbResguardoA = filaSeleccionada.Cells[7].Value.ToString();
            Clases.Variables.tbDepartamentoA = filaSeleccionada.Cells[8].Value.ToString();
            Clases.Variables.desc2 = filaSeleccionada.Cells[9].Value.ToString();
            Clases.Variables.desc3 = filaSeleccionada.Cells[4].Value.ToString();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(GVBienes);
        }

        private void GVBienes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CBienes.Botones.Modificar modificar = new CBienes.Botones.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Activo.CBienes.ReporteBienes reporteBienes = new Activo.CBienes.ReporteBienes();
            reporteBienes.ShowDialog();
        }
    }
}
