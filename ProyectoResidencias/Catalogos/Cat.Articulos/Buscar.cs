﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Cat.Articulos
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            Clases.Articulos.CBBuscarArticulo(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                if (RBArticulo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "select ID,Descripcion,Familia,Inventariable,Medida,TipoArticulo as 'Tipo Articulo',ActivoContratos as 'Activos por Contrato' from vArticulosCompras where Descripcion LIKE '%" + comboBox1.Text + "%' order by id";
                else if (RBFamilia.Checked == true)
                    Clases.Variables.ConsultaBuscar = "select ID,Descripcion,Familia,Inventariable,Medida,TipoArticulo as 'Tipo Articulo',ActivoContratos as 'Activos por Contrato' from vArticulosCompras where Familia LIKE '%" + comboBox1.Text + "%' order by id";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un valor a buscar");
            }
        }

        private void RBFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFamilia.Checked == true)
                Clases.Articulos.CBArticulosFamilia(comboBox1);

        }

        private void RBArticulo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBArticulo.Checked == true)
                Clases.Articulos.CBBuscarArticulo(comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select ID,Descripcion,Familia,Inventariable,Medida,TipoArticulo as 'Tipo Articulo',ActivoContratos as 'Activos por Contrato' from vArticulosCompras order by id";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
