using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using E = Microsoft.Office.Interop.Excel;


namespace reporteHallazgos
{
    public partial class formHistorial : Form
    {
        public formHistorial()
        {
            InitializeComponent();
        }

        private void formHistorial_Load(object sender, EventArgs e)
        {
            classHistorial historial = new classHistorial(); 
            string[] lines = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\paths.txt");            
            historial.setStringBD(lines[9]); 
            DataTable tablaHistorial = historial.selectAll();
            dataGridHistorial.DataSource = tablaHistorial;
            
        }

        private void autosizeGridUsuarios()
        {

            dataGridHistorial.AllowUserToOrderColumns = true;
            dataGridHistorial.AllowUserToResizeColumns = true;

            dataGridHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dial = new SaveFileDialog();
            dial.DefaultExt = "xlsx";
            dial.FileName = "ExportacionConsulta.xlsx";
            dial.Filter = "Archivos de Excel | *.xlsx";
            if (dial.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                
                this.Cursor = Cursors.WaitCursor;
                string saveFilePath = dial.FileName;
                CopyAllToClipboard();
                InsertarDatos(saveFilePath);
                dataGridHistorial.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo de Excel.\n\n" + ex.Message + "\n\n" + ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void InsertarDatos(string fileName)
        {
            E.Application xlexcel;
            E.Workbook xlWorkBook;
            E.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new E.Application();
            //xlexcel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            xlexcel.Visible = false;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (E.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Name = "Existencias";
            xlWorkSheet.Range["A1:AG50000"].NumberFormat = "@";
            E.Range CR = (E.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.Paste(CR, Clipboard.GetText()); 
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            FormatearHoja(xlWorkSheet);
            xlWorkBook.SaveAs(fileName);
            xlexcel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            xlexcel.Visible = true;
        }

        private void FormatearHoja(E.Worksheet ws)
        {
            try
            {
                //ws.Range["A1:AG1"].Interior.Color = Color.FromArgb(157, 228, 252);
                ws.Range["A1:AG1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Range["A1:AG1"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ws.Range["A1:AG1"].Cells.Font.Bold = true;
                //ws.Range["A1:AG" + ws.UsedRange.Rows.Count].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //ws.Range["A1:AG" + ws.UsedRange.Rows.Count].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //Modificacion de los bordes 
                E.Range myRange = ws.Range["A1:AG" + ws.UsedRange.Rows.Count];
                E.Borders borders = myRange.Borders;
                borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                borders.Weight = 2d;

                //Modificion de ajustar texto (Se quitó ajustar texto) 
                myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignGeneral; 
                myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom; 
                myRange.WrapText = false; 
                myRange.Orientation = 0; 
                myRange.AddIndent = false;
                myRange.IndentLevel = 0;
                myRange.ShrinkToFit = false; 
                //myRange.ReadingOrder = Microsoft.Office.Interop.Excel.XlSortOrder.xlAscending; 
                myRange.MergeCells = false;

                //Se realiza el ciclo para colocar el formato de texto en las claves. 
                myRange = ws.Range["T1:T" + dataGridHistorial.Rows.Count + 1]; 
                

                foreach (E.Range cell in myRange)
              {
                  cell.Value = "" + cell.Value; 
                  
              }
              



            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString()); 
            }
        }

        private void CopyAllToClipboard()
        {
            dataGridHistorial.SelectAll();

            //dataGridHistorial.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridHistorial.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dataGridHistorial.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
