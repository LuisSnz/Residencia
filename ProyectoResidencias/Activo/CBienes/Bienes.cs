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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            CBienes.Nuevo Nuevo = new CBienes.Nuevo();
            Nuevo.ShowDialog();
            
        }

        private void consultaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Modificar modificar = new CBienes.Botones.Modificar();
            modificar.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Buscar buscar = new CBienes.Botones.Buscar();

            var result =buscar.ShowDialog();
            if (result == DialogResult.OK)
            {
                GVBienes.DataSource = buscar.ds.Tables["bienes"];
            }
        }

        private void Bienes_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GVBienes, "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, bienes.total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id  ", "bienes");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
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
        }
    }
}
