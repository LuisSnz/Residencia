using System;
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
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
               "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
               "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
               "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
               "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
               "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''";
        }
    }
}
