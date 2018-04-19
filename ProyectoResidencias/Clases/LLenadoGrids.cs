﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ProyectoResidencias.Clases
{
    class LLenadoGrids
    {
        public static void llenarGrid(DataGridView Grid, string consulta,string tabla)
        {
            try
            {
                
                string conexion1 = Clases.Variables.scon;
                SqlConnection cnn = new SqlConnection(conexion1);
                SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
                DataSet ds = new DataSet();
                da.Fill(ds, tabla);
                Grid.DataSource = ds.Tables[tabla];
            }
            catch (Exception e)
            { MessageBox.Show("Error al llenar la base de datos. /n"+e.ToString()); }
        }
        public static DataSet GenerarDataSet(string consulta, string tabla)
        {
            string conexion1 = Clases.Variables.scon;
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            return ds;
        }
    }
}
