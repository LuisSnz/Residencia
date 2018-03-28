﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Cat.Articulos
{
    public partial class CatArticulos : Form
    {
        public CatArticulos()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Cat.Articulos.Botones.Nuevo nuevo = new Catalogos.Cat.Articulos.Botones.Nuevo();
            nuevo.ShowDialog();
            Clases.LLenadoGrids.llenarCatArticulos(GVCatArticulos, "vArticulosCompras");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Cat.Articulos.Botones.Modificar modificar = new Catalogos.Cat.Articulos.Botones.Modificar();
            modificar.ShowDialog();
            Clases.LLenadoGrids.llenarCatArticulos(GVCatArticulos, "vArticulosCompras");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Catalogos.Cat.Articulos.Buscar buscar = new Catalogos.Cat.Articulos.Buscar();
            buscar.ShowDialog();
            Clases.LLenadoGrids.llenarCatArticulos(GVCatArticulos, "vArticulosCompras");
        }

        private void CatArticulos_Load(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarCatArticulos(GVCatArticulos, "vArticulosCompras");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.stconexion.scon;
            string SqlString = "Delete from CatArticulos where Descripcion='"+ Clases.Variables.referencia+"'";
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(SqlString, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Articulo eliminado correctamente.");
                Clases.LLenadoGrids.llenarCatArticulos(GVCatArticulos, "vArticulosCompras");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
            }
        }

        private void GVCatArticulos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GVCatArticulos.CurrentRow;
            Clases.Variables.referencia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.desc = filaSeleccionada.Cells[1].Value.ToString();
        }
    }
}
