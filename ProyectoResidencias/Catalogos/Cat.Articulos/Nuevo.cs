using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Cat.Articulos.Botones
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Insert Into CatArticulos (Descripcion,idfamilia,Medida,COG) values ('" + TBArticulo.Text + ",'select DISTINCT Familia.Descripcion from Familia,CatArticulos where Familia.Id = CatArticulos.IdFamilia AND Familia.Descripcion ='" +CBFamilia.SelectedValue+"," + CBMedida.SelectedValue +","+TBCOG.Text+"');";
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(SqlString, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Articulo agregado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Nuevo_Load(object sender, EventArgs e)
        {
            Clases.LlenadoCombos cb = new Clases.LlenadoCombos();

            cb.CBArticulos(CBFamilia);

        }
    }
}
