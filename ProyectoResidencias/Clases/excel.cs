using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoResidencias.Clases
{
    class excel
    {
        public static void GridViewExcel(DataGridView grd)
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
            aplicacion.Visible = true;
        }
    }
}
