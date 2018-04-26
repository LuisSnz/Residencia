using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using BarcodeLib;

namespace ProyectoResidencias.Clases
{
    class Etiquetas
    {
        public static void ImprimirEtiquetas(PrintDialog VImpresion)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(documentoAimprimir);
                // Especifica que impresora se utilizara!!
                //pd.PrinterSettings.PrinterName = "ZDesigner GC420t (EPL)";
                //PageSettings pa = new PageSettings();
                //pa.Margins = new Margins(0, 0, 0, 0);
                //pd.DefaultPageSettings.Margins = pa.Margins;
                //PaperSize ps = new PaperSize("Custom", 253, 128);
                //pd.DefaultPageSettings.PaperSize = ps;
                VImpresion.Document = pd;
                DialogResult resultado = VImpresion.ShowDialog();
                if (resultado == DialogResult.OK)
                    pd.Print();
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
                for (int x = 0; x< 2; x++)
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    Font fnt = new Font("Arial", 12);
                    string texto = string.Format("JMAS CAMARGO");
                    e.Graphics.DrawString(texto, fnt, Brushes.Black, 125, 10, stringFormat);
                    fnt = new Font("Arial", 8);
                    texto = string.Format("Enfriador y Calentador de Agua");
                    e.Graphics.DrawString(texto, fnt, Brushes.Black, 125, 30, stringFormat);
                    Barcode code = new Barcode();
                    code.IncludeLabel = true;
                    Image codigo = code.Encode(TYPE.CODE128, "1234567890", Color.Black, Color.White, 220, 80);
                    e.Graphics.DrawImage(codigo, 45, 40, 160, 80);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printpage" + ex.Message);
            }
        }
    }
}
