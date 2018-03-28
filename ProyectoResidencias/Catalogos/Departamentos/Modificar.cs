using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Departamentos
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0 && comboArea.SelectedIndex >= 0 && comboSubD.SelectedIndex >= 0)
            {
                string ConnString = Clases.stconexion.scon;
                string SqlString = "Insert Into DEPTOS (CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION) values ((select (COUNT(clave))+1 from DEPTOS),'" + Descripcion.Text + "', '" + comboArea.SelectedItem.ToString() + "','" + comboSubD.SelectedItem.ToString() + "');";
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
                            MessageBox.Show("Departamento agragado correctamente.");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
                MessageBox.Show("Todos los campos deben contener un valor");
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Clases.Departamentos.CBSubdireccion(comboSubD);
            Clases.Departamentos.CBAreas(comboArea);
            int index = comboArea.FindString(Clases.Variables.desc2);
            comboArea.SelectedIndex = index;
            index = comboSubD.FindString(Clases.Variables.desc3);
            comboSubD.SelectedIndex = index;
            Descripcion.Text = Clases.Variables.desc;
        }
    }
}
