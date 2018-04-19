using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Departamentos
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Departamentos.Nuevo nuevo = new Catalogos.Departamentos.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridDeptos, "select CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION from DEPTOS", "DEPTOS");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Departamentos.Modificar modificar = new Catalogos.Departamentos.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridDeptos, "select CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION from DEPTOS", "DEPTOS");
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridDeptos, "select CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION from DEPTOS", "DEPTOS");
        }

        private void GridDeptos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridDeptos.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.desc2 = filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.desc3 = filaSeleccionada.Cells[3].Value.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from DEPTOS where Clave=" + Clases.Variables.referencia;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Departamento eliminado correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridDeptos, "select CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION from DEPTOS", "DEPTOS");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GridDeptos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridDeptos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Departamentos.Modificar modificar = new Catalogos.Departamentos.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridDeptos, "select CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION from DEPTOS", "DEPTOS");
        }
    }
}
