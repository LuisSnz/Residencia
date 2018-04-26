using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using BarcodeLib;

namespace ProyectoResidencias
{
    public partial class pruebimprimir : Form
    {
        public pruebimprimir()
        {
            InitializeComponent();
        }

        private void pruebimprimir_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                printDialog1.Document = pd;

                DialogResult resultado = printDialog1.ShowDialog();
                if(resultado==DialogResult.OK)
                pd.Print();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Printing " + exp.Message);
            }

        }

        private void documentoAimprimir(object sender, PrintPageEventArgs e)
        {
            try
            {
                for (int x = 0; x < 2; x++)
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
