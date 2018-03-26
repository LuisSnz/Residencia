using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoResidencias.Clases
{

    public static class stconexion
    {
        public static string scon = ("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
    }
    class ConexionBD
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

       

        public ConexionBD()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
                cn.Open();
                //MessageBox.Show("Conectado");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    
    }
}
