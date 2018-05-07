using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoResidencias.Catalogos.Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Nuevo nuevo = new Catalogos.Proveedores.Nuevo();
            nuevo.ShowDialog();
            if(nuevo.DialogResult==DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Modificar modificar = new Catalogos.Proveedores.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Buscar buscar = new Buscar();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            GridProveedor.Width = Clases.Variables.GridWidth;
            GridProveedor.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "SELECT Id, RTRIM(Nombre) AS 'Nombre', RTRIM(Direccion) AS 'Direccion'," +
                " Fax, RTRIM(Ciudad) AS 'Ciudad', Contacto, Giro, PadronGobierno, Certificaciones, Email, Observaciones," +
                " Telefono, Accionistas, Curp FROM Proveedores";
            Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void GridProveedor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdProveedores = GridProveedor.CurrentRow.Cells[0].Value.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FConfirmacion confirmacion = new FConfirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK) {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from Proveedores where Id=" + Clases.Variables.IdProveedores;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Departamento eliminado correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Clases.excel.GridViewExcel(GridProveedor);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            RVProveedores viewer = new RVProveedores();
            viewer.ShowDialog();
        }

        private void GridProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Proveedores.Modificar modificar = new Catalogos.Proveedores.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, "Select Id,RTRIM(Nombre) as 'Nombre',RTRIM(Direccion)as 'Direccion'," +
                "Rfc as 'RFC',Fax,Ciudad,RTRIM(Email) as 'eMail',Telefono,Curp,Contacto,Giro,PadronGobierno,Accionistas," +
                "Observaciones from Proveedores", "Proveedores");
        }
    }
}
