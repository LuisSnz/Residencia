﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Subdirecciones
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update subdireccion set Descripcion='" + Descripcion.Text + "' where ID=" + Clases.Variables.IdSubD + ";";
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
                            MessageBox.Show("SubDireccion modificada correctamente.");
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
            else
                MessageBox.Show("El campo debe contener un valor");

        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Descripcion.Text = Clases.Variables.DescripcionSubD;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
