using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias.Activo.BienesDadosDeBaja
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            Clases.BienesBaja.CBEtiqueta(CBBuscar);
        }

        private void Etiqueta_CheckedChanged(object sender, EventArgs e)
        {
            if(Etiqueta.Checked==true)
                Clases.BienesBaja.CBEtiqueta(CBBuscar);
        }

        private void Motivo_CheckedChanged(object sender, EventArgs e)
        {
            if (Motivo.Checked == true)
                Clases.BienesBaja.CBMotivo(CBBuscar);
        }

        private void Articulo_CheckedChanged(object sender, EventArgs e)
        {
            if (Articulo.Checked == true)
                Clases.BienesBaja.CBArticulo(CBBuscar);
        }

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Empleado.Checked == true)
                Clases.BienesBaja.CBEmleado(CBBuscar);
        }

        private void Factura_CheckedChanged(object sender, EventArgs e)
        {
            if (Factura.Checked == true)
                Clases.BienesBaja.CBFactura(CBBuscar);
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
               " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
               "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
               "AS Modelo, RTRIM(MotivoBaja) AS Motivo, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
               "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (CBBuscar.SelectedIndex >= 0)
            {
                if (Etiqueta.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
               " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
               "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
               "AS Modelo, RTRIM(MotivoBaja) AS Motivo, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
               "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes where Etiqueta=" + CBBuscar.SelectedItem.ToString();
                else if (Empleado.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
               " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
               "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
               "AS Modelo, RTRIM(MotivoBaja) AS Motivo, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
               "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes where Empleado='"+CBBuscar.SelectedItem.ToString()+"'";
                else if (Motivo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
               " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
               "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
               "AS Modelo, RTRIM(MotivoBaja) AS MotivoBaja, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
               "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes where MotivoBaja='"+CBBuscar.SelectedItem.ToString()+"'";
                else if (Articulo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
               " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
               "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
               "AS Modelo, RTRIM(MotivoBaja) AS Motivo, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
               "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes where Articulo='"+CBBuscar.SelectedItem.ToString()+"'";
                else if (Factura.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura,Total," +
               " RTRIM(Articulo) AS Articulo, RTRIM(Observacion) AS Observaciones,RTRIM( Departamento) AS Departamento, " +
               "RTRIM(Empleado) AS Empleado, FechaCompra, RTRIM(Marca) AS Marca, RTRIM(Serie) AS Serie, RTRIM(Modelo) " +
               "AS Modelo, RTRIM(MotivoBaja) AS Motivo, FechaBaja, RTRIM(ObservacionBaja) as ObservacionesBaja, " +
               "RTRIM(RutaFoto) as Foto, ValorActual, Consumible, Borro FROM dbo.BajaBienes where NoFactura='" + CBBuscar.SelectedItem.ToString() + "'";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Seleccione un valor a buscar");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
