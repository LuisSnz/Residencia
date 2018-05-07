using System;
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
            DGBaja.Width = Clases.Variables.GridWidth;
            DGBaja.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura, Total, " +
                "RTRIM(Articulo) as Articulo, RTRIM(Observacion) as Observacion, Departamento, RTRIM(Empleado) as Empleado," +
                " FechaCompra, Marca, Serie, Modelo, RTRIM(MotivoBaja) as MotivoBaja, EstatusBaja," +
                "(convert(varchar, FechaBaja,101))  as FechaBaja,RTRIM( ObservacionBaja) as ObservacionBaja," +
                " RTRIM(ValorActual) as ValorActual, Consumible, Borro FROM dbo.BajaBienes";
            Clases.LLenadoGrids.llenarGrid(DGBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(DGBaja);
        }

        private void DGBaja_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdBienesB = DGBaja.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.BienesBMotivoBaja = DGBaja.CurrentRow.Cells[13].Value.ToString();
            Clases.Variables.BienesBObservacion = DGBaja.CurrentRow.Cells[16].Value.ToString();
            Clases.Variables.BienesBValor = DGBaja.CurrentRow.Cells[17].Value.ToString();
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
            RVBaja reporte = new RVBaja();
            reporte.ShowDialog();
        }
    }
}
