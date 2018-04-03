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
        public static void llenarGrid(DataGridView Grid, string consulta,string tabla)
        {
            string conexion1 = Clases.stconexion.scon;
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[tabla];
        }
        public static void llenarCatArticulos(DataGridView Grid, string tabla)
        {
            Clases.ConexionBD conexion = new Clases.ConexionBD();
            string conexion1 = Clases.stconexion.scon;
            string consulta = "select Id,Descripcion,Familia,Inventariable,Medida,TipoArticulo as 'Tipo Articulo',ActivoContratos as 'Activos por Contrato' from " + tabla + " order by id";
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[tabla];
        }
    }
}
