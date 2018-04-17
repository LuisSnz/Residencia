﻿using System;
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
                cmd = new SqlCommand("select Descripcion from CatArticulos order by Descripcion", cn);
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
        public static void CBMarca(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from marca order by Descripcion", cn);
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
        public static void CBEtiqueta(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Etiqueta from bienes", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Etiqueta"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBFactura(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select NoFactura from bienes order by NoFactura", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["NoFactura"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBProveedor(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select RTRIM(Nombre) as Nombre from Proveedores order by Nombre", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
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
        public static void Modificar(TextBox orden, DateTimePicker fecha, TextBox factura,ComboBox articulo,
            Label familia, ComboBox marca,TextBox serie,ComboBox conservacion,TextBox modelo, TextBox color,ComboBox proveedor,
            Label domicilio,Label rfc,TextBox observaciones)
        {
            try
            {
                int index;
                cn.Open();
                cmd = new SqlCommand("SELECT bienes.Id, bienes.NoOrden,bienes.FechaCompra, bienes.NoFactura," +
                    "bienes.Modelo,Bienes.Color,Familia.Descripcion as Familia, dbo.CatArticulos.Descripcion AS Articulo," +
                    "RTRIM(Proveedores.Nombre) AS Proveedor,bienes.Estado,RTRIM(Proveedores.Direccion) AS Direccion," +
                    "RTRIM(Proveedores.Rfc) AS RFC,bienes.Observacion,marca.Descripcion as marca,bienes.Serie " +
                    "FROM bienes INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia " +
                    "ON CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id" +
                    " LEFT OUTER JOIN marca on bienes.IdMarca=marca.Id where bienes.Id=" + Clases.Variables.referencia, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    orden.Text = dr["NoOrden"].ToString();
                    fecha.Value = Convert.ToDateTime( dr["FechaCompra"].ToString());
                    factura.Text = dr["NoFactura"].ToString();
                    index = articulo.FindString(dr["Articulo"].ToString());
                    articulo.SelectedIndex = index;
                    familia.Text = dr["Familia"].ToString();
                    index = marca.FindString(dr["marca"].ToString());
                    marca.SelectedIndex = index;
                    serie.Text = dr["Serie"].ToString();
                    index = conservacion.FindString(dr["Estado"].ToString());
                    conservacion.SelectedIndex = index;
                    modelo.Text = dr["Modelo"].ToString();
                    color.Text = dr["Color"].ToString();
                    index = proveedor.FindString(dr["Proveedor"].ToString());
                    proveedor.SelectedIndex = index;
                    domicilio.Text = dr["Direccion"].ToString();
                    rfc.Text = dr["RFC"].ToString();
                    observaciones.Text = dr["Observacion"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BajaLabels(Label modelo,Label precio,Label serie,Label marca)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT bienes.Id,bienes.Modelo,bienes.Precio,bienes.Serie,marca.Descripcion as marca " +
                    "from bienes inner join marca on bienes.IdMarca=marca.Id where bienes.Id=" + Clases.Variables.referencia, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    modelo.Text = dr["Modelo"].ToString();
                    serie.Text = dr["Serie"].ToString();
                    precio.Text = dr["Precio"].ToString();
                    marca.Text = dr["marca"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class BienesBaja
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
        public static void CBEtiqueta(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Etiqueta from BajaBienes order by Etiqueta", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Etiqueta"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBArticulo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(Articulo) AS Articulo from BajaBienes order by Articulo", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Articulo"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBEmleado(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(Empleado) AS Empleado from BajaBienes order by Empleado", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Empleado"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBFactura(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(NoFactura) AS Factura from BajaBienes", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Factura"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBMotivo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(MotivoBaja) AS Motivo from BajaBienes", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Motivo"].ToString());
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
                cmd = new SqlCommand("select Nombre from empleados order by Nombre", cn);
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
