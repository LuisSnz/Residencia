﻿using System;
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
                if (Descripcion.Text.Length < 50)
                {
                    string ConnString = Clases.Variables.scon;
                    string SqlString = "Update DEPTOS  set DESCRIPCION='" + Descripcion.Text + "', DIRECCION='" +
                        comboArea.SelectedItem.ToString() + "',SUBDIRECCION='" + comboSubD.SelectedItem.ToString() +
                        "' where CLAVE=" + Clases.Variables.IdDeptos + ";";
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
                                MessageBox.Show("Departamento modificado correctamente.");
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
                {
                    MessageBox.Show("El nombre del departamento debe tener menos de 50 caracteres");
                }
            }
            else
                MessageBox.Show("Todos los campos deben contener un valor");
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Clases.Departamentos.CBSubdireccion(comboSubD);
            Clases.Departamentos.CBAreas(comboArea);
            int index = comboArea.FindString(Clases.Variables.DireccionDeptos);
            comboArea.SelectedIndex = index;
            index = comboSubD.FindString(Clases.Variables.SubDeptos);
            comboSubD.SelectedIndex = index;
            Descripcion.Text = Clases.Variables.DescripcionDeptos;
        }
    }
}
