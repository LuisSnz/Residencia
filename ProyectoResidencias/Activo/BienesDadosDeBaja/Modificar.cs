using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Activo.BienesDadosDeBaja
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            int index = Motivo.FindString(Clases.Variables.BienesBMotivoBaja);
            Motivo.SelectedIndex = index;
            Valor.Text = Clases.Variables.BienesBValor;
            Observaciones.Text = Clases.Variables.BienesBObservacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.Variables.scon;
            string SqlString = "Update BajaBienes set MotivoBaja='"+Motivo.SelectedItem.ToString()+"',ObservacionBaja='"+
                Observaciones.Text+"',ValorActual="+Valor.Text+" where id=" + Clases.Variables.IdBienesB + ";";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Bien modificado correctamente.");
                        this.Close();
                        this.DialogResult = DialogResult.OK;
                    }
                }
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
    }
}
