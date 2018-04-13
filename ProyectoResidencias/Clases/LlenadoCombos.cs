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
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
        string conexion = Clases.stconexion.scon;

        public static void CBArticulosFamilia(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from familia", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
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
        public static void CBArticulosTipoArticulo(ComboBox CB)
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
        public static void CBArticulosMedida(ComboBox CB)
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
        public static void CBBuscarArticulo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from CatArticulos", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
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
    class Bienes
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");

        public static void CBCambio(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select nombre from empleados where Baja=0 order by Nombre", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }
    class Departamentos
    {
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
        public static void BuscarJefe(ComboBox CB, string n)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Nombre from Empleados where NoEmp=" + n, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int index = CB.FindString(dr["Nombre"].ToString());
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
                    TB.Text = dr["Textobloqueado"].ToString();
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

    class Proveedores {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");

        public static void Modificar (TextBox Nombre, TextBox Direccion, TextBox Fax, TextBox Ciudad, TextBox Contacto,
            TextBox RFC, TextBox CURP, TextBox Email, TextBox Telefono, TextBox Giro, TextBox Padron,TextBox Certificacion, 
            TextBox Accionistas,TextBox Observaciones)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select RTRIM(Nombre) as 'Nombre',RTRIM(Direccion) as 'Direccion',RTRIM(Fax) as 'Fax'," +
                    "RTRIM(Ciudad) as 'Ciudad',RTRIM(Contacto) as 'Contacto',RTRIM(Rfc) as 'RFC',RTRIM(Curp) as 'CURP'," +
                    "RTRIM(Email) as 'Email',RTRIM(Telefono) as 'Telefono',RTRIM(Giro) as 'Giro',RTRIM(PadronGobierno) as 'Padron'," +
                    "RTRIM(Certificaciones) as 'Certificaciones',RTRIM(Accionistas) as 'Accionistas'," +
                    "RTRIM(Observaciones) as 'Observaciones' from Proveedores where Id=" + Clases.Variables.referencia, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nombre.Text = dr["Nombre"].ToString();
                    Direccion.Text = dr["Direccion"].ToString();
                    Fax.Text = dr["Fax"].ToString();
                    CURP.Text = dr["CURP"].ToString();
                    Ciudad.Text = dr["Ciudad"].ToString();
                    RFC.Text = dr["RFC"].ToString();
                    Telefono.Text = dr["Telefono"].ToString();
                    Email.Text = dr["Email"].ToString();
                    Contacto.Text = dr["Contacto"].ToString();
                    Giro.Text = dr["Giro"].ToString();
                    Padron.Text = dr["Padron"].ToString();
                    Certificacion.Text = dr["Certificaciones"].ToString();
                    Accionistas.Text = dr["Accionistas"].ToString();
                    Observaciones.Text = dr["Observaciones"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        public static void CBBuscar(ComboBox CB, string Consulta,string Columna)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand(Consulta, cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr[Columna].ToString());
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
