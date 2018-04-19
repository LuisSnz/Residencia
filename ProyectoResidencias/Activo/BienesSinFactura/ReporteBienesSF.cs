﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace ProyectoResidencias.Activo.BienesSinFactura
{
    public partial class ReporteBienesSF : Form
    {
        public ReporteBienesSF()
        {
            InitializeComponent();
        }

        private void ReporteBienesSF_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            ReportParameter[] reporte = new ReportParameter[9];
            reporte[0] = new ReportParameter("id", Clases.Variables.referencia);
            reporte[1] = new ReportParameter("Etiqueta", Clases.Variables.desc);
            reporte[2] = new ReportParameter("NoOrden", Clases.Variables.lbOrdenCompra);
            reporte[3] = new ReportParameter("departamento", Clases.Variables.tbDepartamentoA);
            reporte[4] = new ReportParameter("articulo", Clases.Variables.tbArticulo);
            reporte[5] = new ReportParameter("observaciones", Clases.Variables.tbObservacion);
            reporte[6] = new ReportParameter("nombre", Clases.Variables.tbResguardoA);
            reporte[7] = new ReportParameter("total", "$" + Clases.Variables.desc3);
            reporte[8] = new ReportParameter("Familia", Clases.Variables.Familia);
            reportViewer1.LocalReport.SetParameters(reporte);
            reportViewer1.Refresh();
        }
    }
}
