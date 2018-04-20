using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Subdirecciones
{
    public partial class SubDireccion : Form
    {
      
        public SubDireccion()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Subdirecciones.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Subdirecciones.Modificar modificarSD = new Modificar();
            modificarSD.ShowDialog();
            if (modificarSD.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        public void SubDireccion_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select ID, Descripcion from subdireccion";
            Clases.LLenadoGrids.llenarGrid(GridSubD,Clases.Variables.ConsultaBuscar, "subdireccion");
        }
        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from subdireccion where ID=" + Clases.Variables.IdSubD;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SubDireccion eliminada correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor no se pudo eliminar. \n" + ex.ToString());
                }
            }            
        }

        private void GridSubD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdSubD = GridSubD.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.DescripcionSubD= GridSubD.CurrentRow.Cells[1].Value.ToString();
        }
        private void GridSubD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Subdirecciones.Modificar modificarSD = new Modificar();
            modificarSD.ShowDialog();
            if (modificarSD.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }
    }
}
