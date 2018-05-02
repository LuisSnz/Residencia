﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using BarcodeLib;
using System.Data;

namespace ProyectoResidencias.Clases
{
    class Etiquetas
    {
        public static void ImprimirEtiquetas(/*PrintDialog VImpresion, */string min, string max)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = ("ZDesigner GC420t (EPL)");
                //VImpresion.Document = pd;
                //DialogResult resultado = VImpresion.ShowDialog();
                //if (resultado == DialogResult.OK)
                //{
                DataSet ds = Clases.LLenadoGrids.GenerarDataSet("select bienes.Etiqueta, CatArticulos.Descripcion" +
                        " from bienes inner join CatArticulos on bienes.IdArticulo = CatArticulos.Id where " +
                        "bienes.Etiqueta between "+min+" and "+max, "bienes");
                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                    {
                        Clases.Variables.IEtiqueta = ds.Tables[0].Rows[x][0].ToString();
                        Clases.Variables.IArticulo = ds.Tables[0].Rows[x][1].ToString();
                        pd.PrintPage += new PrintPageEventHandler(documentoAimprimir);
                        pd.Print();
                    }
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show("Printing " + exp.Message);
            }

        }

        public static void documentoAimprimir(object sender, PrintPageEventArgs e)
        {
            try
            {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    Font fnt = new Font("Times New Roman", 12);
                    string texto = string.Format("JMAS CAMARGO");
                    e.Graphics.DrawString(texto, fnt, Brushes.Black, 125, 15, stringFormat);
                    fnt = new Font("Times New Roman", 7);
                    texto = string.Format(Clases.Variables.IArticulo);
                    e.Graphics.DrawString(texto, fnt, Brushes.Black, 125, 30, stringFormat);
                    Barcode code = new Barcode();
                    Image codigo = code.Encode(TYPE.CODE128,Clases.Variables.IEtiqueta, Color.Black, Color.White, 220, 70);
                    e.Graphics.DrawImage(codigo, 45, 40, 160, 65);
                    fnt = new Font("Times New Roman", 8);
                    texto = string.Format(Clases.Variables.IEtiqueta);
                    e.Graphics.DrawString(texto, fnt, Brushes.Black, 125, 116, stringFormat);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Printpage" + ex.Message);
            }
        }
    }
}
