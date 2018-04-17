using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProyectoResidencias.Activo.CBienes
{
    public partial class ReporteBienes : Form
    {
        public ReporteBienes()
        {
            InitializeComponent();
        }

        private void ReporteBienes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            ReportParameter[] reporte = new ReportParameter[10];
            reporte[0] = new ReportParameter("id", Clases.Variables.referencia);
            reporte[1] = new ReportParameter("Etiqueta", Clases.Variables.desc);
            reporte[2] = new ReportParameter("NoOrden", Clases.Variables.lbOrdenCompra);
            reporte[3] = new ReportParameter("factura", Clases.Variables.lbFactura);
            reporte[4] = new ReportParameter("departamento", Clases.Variables.tbDepartamentoA);
            reporte[5] = new ReportParameter("articulo", Clases.Variables.tbArticulo);
            reporte[6] = new ReportParameter("observaciones", Clases.Variables.tbObservacion);
            reporte[7] = new ReportParameter("nombre", Clases.Variables.tbResguardoA);
            reporte[8] = new ReportParameter("total", Clases.Variables.referencia);
            reporte[9] = new ReportParameter("Familia", Clases.Variables.desc);
            reportViewer1.LocalReport.SetParameters(reporte);
            reportViewer1.Refresh();
        }

    }
}
