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
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridEmp, Clases.Variables.ConsultaBuscar, "empleados");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados.Modificar modificar = new Catalogos.Empleados.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridEmp, Clases.Variables.ConsultaBuscar, "empleados");
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
            Clases.Variables.ConsultaBuscar ="select NoEmp,Nombre,Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados";
            Clases.LLenadoGrids.llenarGrid(GridEmp, Clases.Variables.ConsultaBuscar, "empleados");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from empleados where NoEmp=" + Clases.Variables.IdEmpleados;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Empleado eliminado correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridEmp, Clases.Variables.ConsultaBuscar, "empleados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }

        private void GridEmp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridEmp.CurrentRow;
            Clases.Variables.IdEmpleados =        filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.EmpleadosNombre =    filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.EmpleadosDepto =     filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.EmpleadosJefe =      filaSeleccionada.Cells[3].Value.ToString();
            Clases.Variables.EmpleadosLicencia =  filaSeleccionada.Cells[4].Value.ToString();
            Clases.Variables.EmpleadosFecha =     filaSeleccionada.Cells[5].Value.ToString();
            Clases.Variables.EmpleadosNumJefe =   filaSeleccionada.Cells[6].Value.ToString();
            Clases.Variables.EmpleadosBaja =      filaSeleccionada.Cells[7].Value.ToString();
            Clases.Variables.EmpleadosNombreP =   filaSeleccionada.Cells[8].Value.ToString();
            Clases.Variables.EmpleadosBloqueado = filaSeleccionada.Cells[9].Value.ToString();
            Clases.Variables.EmpleadosPliegos =   filaSeleccionada.Cells[10].Value.ToString();
            Clases.Variables.EmpleadosNoPliegos = filaSeleccionada.Cells[11].Value.ToString();
        }

        private void GridEmp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Empleados.Modificar modificar = new Catalogos.Empleados.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridEmp, Clases.Variables.ConsultaBuscar, "empleados");
        }
    }
}
