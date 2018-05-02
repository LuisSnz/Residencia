﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Proveedores
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNombre.Checked == true)
                Clases.Proveedores.CBBuscar(comboBuscar, "Select RTRIM(Nombre) as 'Nombre' from Proveedores", "Nombre");
        }

        private void radioRFC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRFC.Checked == true)
                Clases.Proveedores.CBBuscar(comboBuscar, "Select RTRIM(Rfc) as RFC from Proveedores", "RFC");
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            Clases.Proveedores.CBBuscar(comboBuscar, "Select RTRIM(Nombre) as 'Nombre' from Proveedores", "Nombre");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "Select Id,RTRIM(Nombre) as 'Nombre',RTRIM(Direccion)as 'Direccion'," +
                "Rfc as 'RFC',Fax,Ciudad,RTRIM(Email) as 'eMail',Telefono,Curp from Proveedores";
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBuscar.SelectedIndex >= 0)
            {
                if (radioNombre.Checked == true)
                    Clases.Variables.ConsultaBuscar = "Select Id,RTRIM(Nombre) as 'Nombre',RTRIM(Direccion)as 'Direccion'," +
                    "Rfc as 'RFC',Fax,Ciudad,RTRIM(Email) as 'eMail',Telefono,Curp from Proveedores where Nombre LIKE '%" + comboBuscar.Text + "%'";
                if (radioRFC.Checked == true)
                    Clases.Variables.ConsultaBuscar = "Select Id,RTRIM(Nombre) as 'Nombre',RTRIM(Direccion)as 'Direccion'," +
                    "Rfc as 'RFC',Fax,Ciudad,RTRIM(Email) as 'eMail',Telefono,Curp from Proveedores where RFC LIKE '%" + comboBuscar.Text + "%'";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Debe seleccionar un valor a buscar valido");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
