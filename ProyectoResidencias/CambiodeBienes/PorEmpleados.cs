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
            Clases.Bienes.CBCambio(CBIzquierdo);
            Clases.Bienes.CBCambio(CBDerecho);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

            if (CBIzquierdo.SelectedIndex >= 0 && CBDerecho.SelectedIndex >= 0)
                toolStrip1.Enabled=true;
        }

        private void CBNombreNuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");

            if (CBIzquierdo.SelectedIndex >= 0 && CBDerecho.SelectedIndex >= 0)
                toolStrip1.Enabled = true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasarIzquierda_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBDerecho.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBIzquierdo.SelectedItem.ToString() + "') and Etiqueta="+GridIzquierdo.CurrentRow.Cells[0].Value.ToString()+";";

            string SqlString2 = "insert into HistoricoBienes values ("+ GridIzquierdo.CurrentRow.Cells[0].Value.ToString() + ",(" +
                "Select NoEmp from empleados where Nombre='"+CBDerecho.SelectedItem.ToString()+ "'),(convert(datetime,'" +DateTime.Today.ToShortDateString()+ "')));";
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
                    using(SqlCommand cmd = new SqlCommand(SqlString2, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Cambio realizado correctamente.");
                Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                DateTime hoy = DateTime.Today;
            }
        }

        private void PasarDerecha_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBIzquierdo.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBDerecho.SelectedItem.ToString() + "') and Etiqueta=" + GridDerecho.CurrentRow.Cells[0].Value.ToString() + ";";

            string SqlString2 = "insert into HistoricoBienes values (" + GridDerecho.CurrentRow.Cells[0].Value.ToString() + ",(" +
                "Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
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
                    using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Cambio realizado correctamente.");
                Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                DateTime hoy = DateTime.Today;
            }
        }

        private void TodoIzquierda_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            try
            {
                for (int i=0;i<GridIzquierdo.RowCount;i++)
                {
                    string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBDerecho.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBIzquierdo.SelectedItem.ToString() + "') and Etiqueta=" + GridIzquierdo.Rows[i].Cells[0].Value.ToString() + ";";

                    string SqlString2 = "insert into HistoricoBienes values (" + GridIzquierdo.Rows[i].Cells[0].Value.ToString() + ",(" +
                        "Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("Cambio realizado correctamente.");
                Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                DateTime hoy = DateTime.Today;
            }
        }

        private void TodoDerecha_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            try
            {
                for (int i = 0; i < GridDerecho.RowCount; i++)
                {
                    string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBIzquierdo.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBDerecho.SelectedItem.ToString() + "') and Etiqueta=" + GridDerecho.Rows[i].Cells[0].Value.ToString() + ";";

                    string SqlString2 = "insert into HistoricoBienes values (" + GridDerecho.Rows[i].Cells[0].Value.ToString() + ",(" +
                        "Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("Cambio realizado correctamente.");
                Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                DateTime hoy = DateTime.Today;
            }
        }
    }
}
