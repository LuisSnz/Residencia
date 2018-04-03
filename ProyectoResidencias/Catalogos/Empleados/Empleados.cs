using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Nuevo nuevo = new Catalogos.Empleados.Nuevo();
            nuevo.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridEmp, "select NoEmp,Nombre,Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados", "empleados");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Modificar modificar = new Catalogos.Empleados.Modificar();
            modificar.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridEmp, "select NoEmp,Nombre,Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados", "empleados");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Buscar buscar = new Catalogos.Empleados.Buscar();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridEmp, Clases.Variables.ConsultaBuscar, "empleados");
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridEmp, "select NoEmp,Nombre,Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados", "empleados");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Delete from empleados where NoEmp=" + Clases.Variables.referencia;
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(SqlString, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Empleado eliminado correctamente.");
                Clases.LLenadoGrids.llenarGrid(GridEmp, "select NoEmp,Nombre,Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados", "empleados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
            }
        }

        private void GridEmp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridEmp.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.ECHJefe = filaSeleccionada.Cells[3].Value.ToString();
            Clases.Variables.ECHBaja = filaSeleccionada.Cells[7].Value.ToString();
            Clases.Variables.ECHBloqueado = filaSeleccionada.Cells[9].Value.ToString();
            Clases.Variables.ECHPliegos = filaSeleccionada.Cells[10].Value.ToString();
            Clases.Variables.ECHNoPliegos = filaSeleccionada.Cells[11].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.desc2 = filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.desc3 = filaSeleccionada.Cells[4].Value.ToString();
            Clases.Variables.desc4 = filaSeleccionada.Cells[5].Value.ToString();
            Clases.Variables.desc5 = filaSeleccionada.Cells[8].Value.ToString();
            Clases.Variables.desc6 = filaSeleccionada.Cells[6].Value.ToString();
        }
    }
}
