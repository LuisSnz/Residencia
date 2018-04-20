using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.AreasODirecciones
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.AreasODirecciones.Nuevo nuevo = new Catalogos.AreasODirecciones.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.AreasODirecciones.Modificar modificar = new Catalogos.AreasODirecciones.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select Clave, Descripcion from areas";
            Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void GridAreas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdAreas = GridAreas.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.DescripcionAreas = GridAreas.CurrentRow.Cells[1].Value.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from areas where Clave=" + Clases.Variables.IdAreas;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Area eliminada correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridAreas,Clases.Variables.ConsultaBuscar, "areas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }

        private void GridAreas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.AreasODirecciones.Modificar modificar = new Catalogos.AreasODirecciones.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }
    }
}
