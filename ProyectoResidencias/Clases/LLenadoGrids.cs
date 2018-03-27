using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoResidencias.Clases
{
    class LLenadoGrids
    {
        public static void llenarSubDireccion(DataGridView Grid, string tabla)
        {
            Clases.ConexionBD conexion = new Clases.ConexionBD();
            string conexion1 = Clases.stconexion.scon;
            string consulta = "select ID, Descripcion from "+tabla;
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[tabla];
        }

        public static void llenarAreas(DataGridView Grid, string tabla)
        {
            Clases.ConexionBD conexion = new Clases.ConexionBD();
            string conexion1 = Clases.stconexion.scon;
            string consulta = "select Clave, Descripcion from " + tabla;
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[tabla];
        }
        public static void llenarFamilias(DataGridView Grid, string tabla)
        {
            Clases.ConexionBD conexion = new Clases.ConexionBD();
            string conexion1 = Clases.stconexion.scon;
            string consulta = "select Id, Descripcion from " + tabla;
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[tabla];
        }
        public static void llenarMarcas(DataGridView Grid, string tabla)
        {
            Clases.ConexionBD conexion = new Clases.ConexionBD();
            string conexion1 = Clases.stconexion.scon;
            string consulta = "select * from " + tabla +" order by Descripcion";
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[tabla];
        }
    }
}
