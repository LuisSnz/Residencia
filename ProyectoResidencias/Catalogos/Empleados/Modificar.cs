using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Empleados
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            if (Clases.Variables.ECHBaja == "True")
                checkBaja.Checked = true;
            if (Clases.Variables.ECHBloqueado == "True")
                checkBloqueado.Checked = true;
            if (Clases.Variables.ECHJefe == "True")
                checkJefe.Checked = true;
            if (Clases.Variables.ECHPliegos == "True")
                checkPliegos.Checked = true;
            if (Clases.Variables.ECHNoPliegos == "True")
                checkSinPliegos.Checked = true;
            Clases.Empleados.CBJefe(comboJefe);
            Clases.Empleados.CBDeptos(comboDepto);
            Nombre.Text = Clases.Variables.desc;
            NombreM.Text = Clases.Variables.desc5;
            Fecha.Value = Convert.ToDateTime(Clases.Variables.desc4);
            Clases.Empleados.BuscarJefe(comboJefe, Clases.Variables.desc6);
            Clases.Empleados.BuscarMotivo(Motivo,Clases.Variables.referencia);
            int index = comboDepto.FindString(Clases.Variables.desc2);
            comboDepto.SelectedIndex = index;
            NumLicencia.Text = Clases.Variables.desc3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pliegos = 0, Jefe = 0, Baja = 0, SinPliego = 0, Bloqueado = 0;
            if (checkPliegos.Checked == true)
                pliegos = 1;
            if (checkJefe.Checked == true)
                Jefe = 1;
            if (checkSinPliegos.Checked == true)
                SinPliego = 1;
            if (checkBloqueado.Checked == true)
                Bloqueado = 1;
            if (checkBaja.Checked == true)
                Baja = 1;

            if (Nombre.Text.Length > 0 && NombreM.Text.Length > 0 && comboDepto.SelectedIndex >= 0
               && NumLicencia.Text.Length > 0 && comboJefe.SelectedIndex >= 0)
            {
                string ConnString = Clases.stconexion.scon;
                string SqlString = "Update empleados set Nombre='"+Nombre.Text+"',NombrePliegos='"+NombreM.Text+
                    "',Departamento='"+comboDepto.SelectedItem.ToString()+"',NoLicencia='"+NumLicencia.Text+
                    "',FechaVencimiento=(convert(datetime,'"+Fecha.Text+"')),NoEmpleadoJefe=(select NoEmp from empleados" +
                    " where Nombre='"+comboDepto.SelectedItem.ToString()+"'),ActivoPliegos="+pliegos+",JefeDepto="+Jefe
                    +",Baja="+Baja+",NoVerifica="+SinPliego+",Bloqueado="+Bloqueado+",Textobloqueado='"+Motivo.Text+"'" +
                    "where NoEmp="+Clases.Variables.referencia+";";
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
                            MessageBox.Show("Empleado modificado correctamente.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
