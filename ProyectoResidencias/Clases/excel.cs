﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace ProyectoResidencias.Clases
{
    class excel
    {
        public static Hashtable myHashtable;
        public static string ruta;

        public static void GridViewExcel(DataGridView grd)
        {
            CheckExcellProcesses();
            ExportDataToExcel(grd);
            KillExcel();
            openExcel();
        }

        public static void CheckExcellProcesses()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            myHashtable = new Hashtable();
            int iCount = 0;

            foreach (Process ExcelProcess in AllProcesses)
            {
                myHashtable.Add(ExcelProcess.Id, iCount);
                iCount = iCount + 1;
            }
        }

        public static void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            foreach (Process ExcelProcess in AllProcesses)
            {
                if (myHashtable.ContainsKey(ExcelProcess.Id) == false)
                    ExcelProcess.Kill();
            }

            AllProcesses = null;
        }
        public static void ExportDataToExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                for (int j = 0; j < grd.ColumnCount; j++)
                {
                    hoja_trabajo.Cells[1, j + 1] = grd.Columns[j].HeaderText;
                }
                hoja_trabajo.Rows[1].Font.Bold = true;
                hoja_trabajo.Rows[1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                hoja_trabajo.Columns.AutoFit();
                libros_trabajo.SaveAs(fichero.FileName,
                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close();
                aplicacion.Quit();
                ruta ="\"" +fichero.FileName+ "\"";
            }
        }
        public static void openExcel()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Excel.exe";
            startInfo.Arguments = ruta;
            Process.Start(startInfo);
        }
    }
}
