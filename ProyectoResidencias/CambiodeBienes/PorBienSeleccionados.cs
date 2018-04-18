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


namespace ProyectoResidencias.CBienes.CambiodeBienes
{
    public partial class PorBienSeleccionados : Form
    {
        public PorBienSeleccionados()
        {
            InitializeComponent();
        }               
        
        private void PorBienSeleccionados_Load(object sender, EventArgs e)
        {
            LBId.Text = Clases.Variables.referencia;
            LBEtiqueta.Text = Clases.Variables.desc;
            LBOrdenCompra.Text = Clases.Variables.lbOrdenCompra;
            TBArticulo.Text = Clases.Variables.tbArticulo;
            TBObservaciones.Text = Clases.Variables.tbObservacion;
            TBResguardoA.Text = Clases.Variables.tbResguardoA;
            TBDepartamentoA.Text = Clases.Variables.tbDepartamentoA;
            Clases.Bienes.CBCambio(CBNuevoResguardo);
       
 }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBNuevoResguardo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.stconexion.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select departamento from empleados where Nombre='"+CBNuevoResguardo.SelectedItem+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TBNuevoResguardo.Text = dr["departamento"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBNuevoResguardo.SelectedIndex >= 0)
            {
                DateTime hoy = DateTime.Today;
                string ConnString = Clases.stconexion.scon;
                string SqlString = "update bienes set NoEmpleado=(select NoEmp from empleados where nombre='"+ CBNuevoResguardo.SelectedItem +"') where NoEmpleado=(select NoEmp from empleados where nombre='"+TBResguardoA.Text + "')  and id=" + LBId.Text+ "";
                string SqlString1 = "insert into HistoricoBienes (Etiqueta,NoEmpleado,FechaCambio) values ("+LBEtiqueta.Text+",(select NoEmp from empleados where nombre='" + CBNuevoResguardo.SelectedItem + "'),(convert(datetime,'" + hoy.ToShortDateString() + "')))";
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
                        using (SqlCommand cmd = new SqlCommand(SqlString1, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            this.Close();
                        }
                        MessageBox.Show("Bien Cambiado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }


            }
            else
            {
                MessageBox.Show("Favor de Seleccionar un destino del bien");
            }
        }
    }
}
