﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void formularios(object hijo) {
            if (this.Base.Controls.Count > 0) 
                this.Base.Controls.RemoveAt(0);
            Form hi = hijo as Form;
            hi.TopLevel = false;
            hi.FormBorderStyle = FormBorderStyle.None;
            hi.Dock = DockStyle.Fill;
            this.Base.Controls.Add(hi);
            this.Base.Tag = hi;
            hi.Show();
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Base.Width = this.Width;
            Base.Height = this.Height-70;
            Clases.Variables.GridHeight = this.Height - 130;
            Clases.Variables.GridWidth = this.Width - (this.Width / 3);
            pictureBox2.Location=new Point( this.Width -(this.Width/5),80);
            pictureBox2.Height = this.Height / 3;
            pictureBox2.Width = this.Width /6;
            pictureBox1.Location = new Point(this.Width - (this.Width / 4), this.Height-(this.Height/2));
            pictureBox1.Height = this.Height / 3;
            pictureBox1.Width = this.Width / 4;
        }

        private void bienesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Bienes());
            this.Text = "Sistema de activo Fijo - Bienes";
        }

        private void areasODireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.AreasODirecciones.Areas());
            this.Text = "Sistema de activo Fijo - Areas";
        }

        private void subDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Subdirecciones.SubDireccion());
            this.Text = "Sistema de activo Fijo - SubDireccion";
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Departamentos.Departamentos());
            this.Text = "Sistema de activo Fijo - Departamentos";
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Empleados.Empleados());
            this.Text = "Sistema de activo Fijo - Empleados";
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Vehiculos.Vehiculos());
            this.Text = "Sistema de activo Fijo - Vehiculos";
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Proveedores.Proveedores());
            this.Text = "Sistema de activo Fijo - Proveedores";
        }

        private void catArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            formularios(new Catalogos.Cat.Articulos.CatArticulos());
            this.Text = "Sistema de activo Fijo - Articulos";
        }
        private void imprimirEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activo.ImprimirEtiquetas imprimir = new Activo.ImprimirEtiquetas();
            imprimir.ShowDialog();
        }


        private void bienesDadosDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Sistema de activo Fijo - Bienes dadoes de Baja";
            formularios(new Activo.BienesDadosDeBaja.InicioBajaBienes());
        }        

        private void CambioDeBienesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void historicoDelBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CBienes.Reportes.HistoricoDelBien historicodelbien = new CBienes.Reportes.HistoricoDelBien();
            historicodelbien.ShowDialog();
        }

        private void costoBienesActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new CBienes.Reportes.CostoBienesResguardados());
            this.Text = "Sistema de activo Fijo - Costo en Bienes";
        }

        private void bienesSinFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Activo.BienesSinFactura.BienesSF());
            this.Text = "Sistema de activo Fijo - Bienes sin Factura";
        }

        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Activo.Marcas.Marcas());
            this.Text = "Sistema de activo Fijo - Marcas";
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Activo.Familias.Familia());
            this.Text = "Sistema de activo Fijo - Familias";
        }

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONF_IMPRESORA impresora = new CONF_IMPRESORA();
            impresora.ShowDialog();
        }
    }
}
