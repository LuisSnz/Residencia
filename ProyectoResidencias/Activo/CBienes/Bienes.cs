using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class Bienes : Form
    {
        public Bienes()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            CBienes.Nuevo Nuevo = new CBienes.Nuevo();
            Nuevo.ShowDialog();
            
        }

        private void consultaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Modificar modificar = new CBienes.Botones.Modificar();
            modificar.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CBienes.Botones.Buscar buscar = new CBienes.Botones.Buscar();

            var result =buscar.ShowDialog();
            if (result == DialogResult.OK)
            {
                BienesVi.DataSource = buscar.ds.Tables["bienes"];
            }
        }

        private void Bienes_Load(object sender, EventArgs e)
        {
            //Clases.ConexionBD conexion = new Clases.ConexionBD();
            //string conexion1 = "Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty";
            //string consulta = "select * from bienes";
            //SqlConnection cnn = new SqlConnection(conexion1);
            //SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "bienes");
            //BienesVi.DataSource = ds.Tables["bienes"];
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
