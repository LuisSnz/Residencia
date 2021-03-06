﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoResidencias.Catalogos.Activo.Familias
{
    public partial class Familia : Form
    {
        public Familia()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Familias.Nuevo nuevo = new Catalogos.Activo.Familias.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Activo.Familias.Modificar modificar = new Catalogos.Activo.Familias.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void Familia_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select Id, Descripcion from Familia";
            Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void GridFamilias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridFamilias.CurrentRow;
            Clases.Variables.IDFamilia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.DescripcionFamilia = filaSeleccionada.Cells[1].Value.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from Familia where Id=" + Clases.Variables.IDFamilia;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Familia eliminada correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }

        private void GridFamilias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Activo.Familias.Modificar modificar = new Catalogos.Activo.Familias.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }
    }
}
