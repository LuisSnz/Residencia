using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoResidencias.CBienes.Botones
{
    public partial class Buscar : Form
    {
        public DataSet ds { get; set; }
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta;

            Clases.ConexionBD conexion = new Clases.ConexionBD();
            Bienes bs = new Bienes();
            string conexion1 = Clases.stconexion.scon;
            consulta = "select * from bienes";
            SqlConnection cnn = new SqlConnection(conexion1);
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);
            this.ds = new DataSet();
            da.Fill(ds, "bienes");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    }
