using System;
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
            Activo.BienesSinFactura.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(dataGridView1, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Modificar form = new Modificar();
            form.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Activo.BienesSinFactura.Buscar form = new Buscar();
            form.ShowDialog();
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
    }
}
