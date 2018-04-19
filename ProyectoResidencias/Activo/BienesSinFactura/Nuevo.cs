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


namespace ProyectoResidencias.Activo.BienesSinFactura
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }
        private void llenaretiqueta()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT MAX(ETIQUETA)+1 as etiqueta FROM BIENES", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TBEtiqueta.Text = dr["etiqueta"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CBArticulo.SelectedIndex >= 0 && CBConservacion.SelectedIndex >= 0 && CBEmpleado.SelectedIndex >= 0 && CBProveedor.SelectedIndex >= 0 && CBMarca.SelectedIndex >= 0 && TBNoOrden.Text.Length > 0 && TBPrecio.Text.Length > 0)
            {
                var con = 0;
                if (CHConsumible.Checked == true)
                    con = 1;
                var creador = "DANIEL";
                string ConnString = Clases.Variables.scon;
                string SqlString = "Insert Into bienes (Etiqueta,NoOrden,Mes,AOrden,NoFactura,Precio,iva,total,TipoIva," +
                    "IdArticulo,Observacion,NoEmpleado,IdProveedor,FechaCompra,Baja,IdMarca,Serie,Modelo,Color,Bloqueado," +
                    "Consumible,Estado,Creador) values (" + TBEtiqueta.Text + "," + TBNoOrden.Text + ",9,2013,''," +
                    "" + TBPrecio.Text + ",0.00," + TBPrecio.Text + ",2,(select id from CatArticulos where descripcion='"
                    + CBArticulo.SelectedItem + "'),'" + TBObservaciones.Text + "',(select NoEmp from empleados where nombre='"
                    + CBEmpleado.SelectedItem + "'),(select id from proveedores where nombre='" + CBProveedor.SelectedItem + "')" +
                    ",(convert(datetime,'" + TimeFecha.Text + "')),0,(select id from marca where descripcion='" + CBMarca.SelectedItem + "')," +
                    "'" + TBSerie.Text + "','" + TBModelo.Text + "','" + TBColor.Text + "',0," + con + ",'" + CBConservacion.SelectedItem + "','"
                    + creador + "')";
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Bien agregado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los espacios que contengan un (*)");
            }
        }

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TBPrecio_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            if ((!(bln)))
            {
                tb.Clear();
                MessageBox.Show("Precio Incorrecto");
                return;
            }
            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }

        private void CBProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select direccion,rfc from proveedores where Nombre='" + CBProveedor.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LBDomicilio.Text = dr["direccion"].ToString();
                    LBRFC.Text = dr["rfc"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Familia.Descripcion as familia from CatArticulos,Familia where Familia.Id=CatArticulos.IdFamilia and CatArticulos.Descripcion='" + CBArticulo.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LBFamilia.Text = dr["familia"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void CBEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select departamento from empleados where Nombre='" + CBEmpleado.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LBDepartamento.Text = dr["departamento"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            llenaretiqueta();
            Clases.Empleados.CBNombre(CBEmpleado);
            Clases.Articulos.CBBuscarArticulo(CBArticulo);
            Clases.Bienes.CBMarca(CBMarca);
            Clases.Bienes.CBProveedor(CBProveedor);
        }
    }
}
