﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Windows.Forms;

namespace GINtool
{
    class ExcelUtils
    {
        public static DataTable ReadExcelToDatable(Excel.Application theApp, string worksheetName, string saveAsLocation, int HeaderLine, int ColumnStart)
        {

            if (theApp != null)
                theApp.EnableEvents = false;
            else
                return null;

            DataTable dataTable = new DataTable();
            Excel.Application excel;
            Excel.Workbook excelworkBook;
            Excel.Worksheet excelSheet;
            Excel.Range range;
            try
            {
                // Get Application object.
                excel = theApp;
                //  excel.Visible = false;
                excel.DisplayAlerts = false;
                // Creation a new Workbook                
                excelworkBook = excel.Workbooks.Open(saveAsLocation);
                // Work sheet                
                excelSheet = (Excel.Worksheet)excelworkBook.Worksheets.Item[worksheetName];
                range = excelSheet.UsedRange;
                int cl = range.Columns.Count;
                // loop through each row and add values to our sheet
                int rowcount = range.Rows.Count; ;
                //create the header of table
                for (int j = ColumnStart; j <= cl; j++)
                {
                    dataTable.Columns.Add(Convert.ToString
                                         (range.Cells[HeaderLine, j].Value2), typeof(string));
                }
                //filling the table from  excel file                
                for (int i = HeaderLine + 1; i <= rowcount; i++)
                {
                    DataRow dr = dataTable.NewRow();
                    for (int j = ColumnStart; j <= cl; j++)
                    {

                        dr[j - ColumnStart] = Convert.ToString(range.Cells[i, j].Value2);
                    }

                    dataTable.Rows.InsertAt(dr, dataTable.Rows.Count + 1);
                }

                //now close the workbook and make the function return the data table                                
                excelworkBook.Close();
                theApp.EnableEvents = true;

                excelSheet = null;
                range = null;
                excelworkBook = null;

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                excelSheet = null;
                range = null;
                excelworkBook = null;
                theApp.EnableEvents = true;
            }
        }
    }
}