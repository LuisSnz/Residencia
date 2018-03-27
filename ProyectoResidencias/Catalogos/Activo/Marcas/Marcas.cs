﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Activo.Marcas
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Marcas.Nuevo nuevo = new Catalogos.Activo.Marcas.Nuevo();
            nuevo.ShowDialog();
            Clases.LLenadoGrids.llenarMarcas(GridMarcas, "marca");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Marcas.Modificar modificar = new Catalogos.Activo.Marcas.Modificar();
            modificar.ShowDialog();
            Clases.LLenadoGrids.llenarMarcas(GridMarcas, "marca");
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarMarcas(GridMarcas, "marca");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Delete from marca where Id=" + Clases.Variables.referencia;
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(SqlString, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Marca eliminada correctamente.");
                Clases.LLenadoGrids.llenarMarcas(GridMarcas, "marca");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
            }
        }

        private void GridMarcas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridMarcas.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
        }
    }
}
