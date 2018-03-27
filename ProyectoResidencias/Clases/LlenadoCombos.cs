using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoResidencias.Clases
{
    class LlenadoCombos
    {
        
        SqlCommand cmd;
        SqlDataReader dr;

        string conexion = Clases.stconexion.scon;

        public void CBArticulos(ComboBox CB)
        {
            try
            {
                cmd = new SqlCommand("select Descripcion from Familia"+ conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :"+ex.ToString());
            }
        }
    }
}
