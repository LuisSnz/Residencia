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
            Clases.LLenadoGrids.llenarGrid(GridSubD, "select ID, Descripcion from subdireccion", "subdireccion");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Subdirecciones.Modificar modificar = new Modificar();
            modificar.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridSubD, "select ID, Descripcion from subdireccion", "subdireccion");
        }

        public void SubDireccion_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridSubD, "select ID, Descripcion from subdireccion", "subdireccion");
        }
        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.stconexion.scon;
                string SqlString = "Delete from subdireccion where ID=" + Clases.Variables.referencia;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SubDireccion eliminada correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridSubD, "select ID, Descripcion from subdireccion", "subdireccion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor no se pudo eliminar. \n" + ex.ToString());
                }
            }            
        }

        private void GridSubD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridSubD.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
        }

        private void GridSubD_DoubleClick(object sender, EventArgs e)
        {
            Catalogos.Subdirecciones.Modificar modificar = new Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
            {
                Clases.LLenadoGrids.llenarGrid(GridSubD, "select ID, Descripcion from subdireccion", "subdireccion");
            }
        }
    }
}
