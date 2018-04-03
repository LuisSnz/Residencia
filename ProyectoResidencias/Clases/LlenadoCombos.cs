using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoResidencias.Clases
{
    class Articulos
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
        string conexion = Clases.stconexion.scon;

        public void CBArticulosFamilia(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from familia", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                //CB.SelectedIndex = 0;
                //dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public void CBArticulosTipoArticulo(ComboBox CB)
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("select Descripcion from tipoarticulo", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CB.Items.Add(dr["Descripcion"].ToString());
                    }
                    //CB.SelectedIndex = 0;
                    //dr.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar :" + ex.ToString());
                }
            }
        public void CBArticulosMedida(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from Medida", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Departamentos {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");

        public static void CBAreas(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from areas", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBSubdireccion(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from subdireccion", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Empleados
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");

        public static void CBJefe(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct Nombre from empleados where JefeDepto=1", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        public static void CBDeptos(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select DESCRIPCION from DEPTOS", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["DESCRIPCION"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BuscarJefe(ComboBox CB,string n)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Nombre from Empleados where NoEmp="+n, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int index=CB.FindString(dr["Nombre"].ToString());
                    CB.SelectedIndex = index;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BuscarMotivo(TextBox TB, string n)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Textobloqueado from Empleados where NoEmp=" + n, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB.Text=dr["Textobloqueado"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBNombre(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Nombre from empleados", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }
}
