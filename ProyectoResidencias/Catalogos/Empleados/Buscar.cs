using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Catalogos.Empleados
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombre(comboBuscar);
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNombre.Checked==true)
                Clases.Empleados.CBNombre(comboBuscar);
        }

        private void radioDeptos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeptos.Checked == true)
                Clases.Empleados.CBDeptos(comboBuscar);
        }

        private void radioJefe_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJefe.Checked == true)
                Clases.Empleados.CBJefe(comboBuscar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioNombre.Checked == true)
                Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' " +
                            "from empleados where Nombre LIKE '%"+comboBuscar.Text+"%'";
            else if (radioDeptos.Checked==true)
                Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' " +
                            "from empleados where Departamento='" + comboBuscar.Text + "'";
            else if (radioJefe.Checked == true)
                Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' " +
                            "from empleados where NoEmpleadoJefe=(select NoEmp from empleados where Nombre='"+comboBuscar.Text+"')";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
