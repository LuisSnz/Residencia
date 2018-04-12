using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.CBienes.CambiodeBienes
{
    public partial class PorEmpleados : Form
    {
        public PorEmpleados()
        {
            InitializeComponent();
        }

        private void PorEmpleados_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombre(CBNombreActual);
            Clases.Empleados.CBNombre(CBNombreNuevo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridActual, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBNombreActual.SelectedItem.ToString() + "')", "bienes");
            if (CBNombreActual.SelectedIndex >= 0 && CBNombreNuevo.SelectedIndex >= 0)
                Aceptar.Enabled = true;
        }

        private void CBNombreNuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridNuevo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBNombreNuevo.SelectedItem.ToString() + "')", "bienes");
            if (CBNombreActual.SelectedIndex >= 0 && CBNombreNuevo.SelectedIndex >= 0)
                Aceptar.Enabled = true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='"+
                CBNombreNuevo.SelectedItem.ToString()+"') where NoEmpleado=(select NoEmp from empleados where Nombre='"+
                CBNombreActual.SelectedItem.ToString()+"');";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Cambio realizado correctamente.");
                Clases.LLenadoGrids.llenarGrid(GridActual, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBNombreActual.SelectedItem.ToString() + "')", "bienes");
                
                Clases.LLenadoGrids.llenarGrid(GridNuevo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBNombreNuevo.SelectedItem.ToString() + "')", "bienes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                DateTime hoy = DateTime.Today;
            }
        }
    }
}
