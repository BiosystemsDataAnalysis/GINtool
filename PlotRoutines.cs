﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

using System.IO;
using SysData = System.Data;
using System.Data;
using GINtool.Properties;
using Microsoft.Office.Core;
using System.Globalization;
using System.Threading;

namespace GINtool
{
    public static class PlotRoutines
    {      
        public static Excel.Application theApp = null;
     
        static double estimatedFontSize(int nritems)
        {
            return -Math.Log10(nritems) + 2.6021;
        }

        static int fontsize(int nritems)
        {
            int size = (int)Math.Pow(10, estimatedFontSize(nritems));
            if (size < 2)
                size = 2;
            if (size > 10)
                size = 10;
            return size;
        }

        public static Excel.Chart CreateDistributionPlot(List<double> sortedFC, List<int> sortedIndex, string chartName)
        {
            if (theApp == null)
                return null;

            Excel.Worksheet aSheet = theApp.Worksheets.Add();

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)aSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 500, 500);
            Excel.Chart chartPage = myChart.Chart;

            //chartPage.ChartType = Excel.XlChartType.xlXYScatter;
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            var series = (Excel.SeriesCollection)chartPage.SeriesCollection();

            var aSerie = series.NewSeries();
            aSerie.Name = String.Format("Serie {0}", 1);
            //aSerie.ChartType = Excel.XlChartType.xlXYScatter;


            //aSerie.XValues = sortedIndex.ToArray();
            aSerie.Values = sortedFC.ToArray();


            //distributionChart.Palette = (ChartColorPalette)Properties.Settings.Default.defaultPalette;
            //distributionChart.Titles.Add("distribution plot");

            var yAxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
            yAxis.HasTitle = true;
            yAxis.AxisTitle.Text = "index (sorted)";

            var xAxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
            xAxis.HasTitle = true;
            xAxis.AxisTitle.Text = "fold change";


            chartPage.Axes(Excel.XlAxisType.xlCategory).TickLabelPosition = Excel.XlTickLabelPosition.xlTickLabelPositionNone;
            chartPage.Axes(Excel.XlAxisType.xlValue).MajorGridLines.Delete();
            chartPage.Legend.Delete();
            chartPage.ChartTitle.Delete();

            chartPage.Location(Excel.XlChartLocation.xlLocationAsNewSheet, chartName);


            aSheet.Delete();

            return chartPage;



        }

        public static Excel.Chart CreateCategoryPlot(List<element_fc> element_Fcs, string chartName)
        {
            if (theApp == null)
                return null;

            Excel.Worksheet aSheet = theApp.Worksheets.Add();

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)aSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 500, 500);
            Excel.Chart chartPage = myChart.Chart;

            chartPage.ChartType = Excel.XlChartType.xlXYScatter;

            var series = (Excel.SeriesCollection)chartPage.SeriesCollection();

            int nrCategories = element_Fcs.Count;

            double  MMAX = 0;
            double MMIN = 0;

            for (int _i = 0; _i < nrCategories; _i++)
            {
                if (element_Fcs[_i].fc != null)
                {
                    if (element_Fcs[_i].fc.Min() < MMIN)
                        MMIN = element_Fcs[_i].fc.Min();
                    if (element_Fcs[_i].fc.Max() > MMAX)
                        MMAX = element_Fcs[_i].fc.Max();
                }
            }

            foreach (var element_Fc in element_Fcs.Select((value, index) => new { value, index }))
            {
                var xy1 = series.NewSeries();
                xy1.Name = element_Fc.value.catName;
                xy1.ChartType = Excel.XlChartType.xlXYScatter;
                if (element_Fc.value.fc != null)
                {
                    xy1.XValues = element_Fc.value.fc;
                    xy1.Values = Enumerable.Repeat(element_Fc.index + 0.5, element_Fc.value.fc.Length).ToArray();
                    xy1.MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone;
                    xy1.MarkerSize = 2;
                    xy1.ErrorBar(Excel.XlErrorBarDirection.xlY, Excel.XlErrorBarInclude.xlErrorBarIncludeBoth, Excel.XlErrorBarType.xlErrorBarTypeFixedValue, 0.1);
                    Excel.ErrorBars errorBars = xy1.ErrorBars;
                    errorBars.EndStyle = Excel.XlEndStyleCap.xlNoCap;
                    errorBars.Format.Line.Weight = 1.25f;

                    // give each serie different color
                    switch (element_Fc.index % 6)
                    {
                        case 0:
                            errorBars.Format.Line.ForeColor.ObjectThemeColor = MsoThemeColorIndex.msoThemeColorAccent1;
                            break;
                        case 1:
                            errorBars.Format.Line.ForeColor.ObjectThemeColor = MsoThemeColorIndex.msoThemeColorAccent2;
                            break;
                        case 2:
                            errorBars.Format.Line.ForeColor.ObjectThemeColor = MsoThemeColorIndex.msoThemeColorAccent3;
                            break;
                        case 3:
                            errorBars.Format.Line.ForeColor.ObjectThemeColor = MsoThemeColorIndex.msoThemeColorAccent4;
                            break;
                        case 4:
                            errorBars.Format.Line.ForeColor.ObjectThemeColor = MsoThemeColorIndex.msoThemeColorAccent5;
                            break;
                        case 5:
                            errorBars.Format.Line.ForeColor.ObjectThemeColor = MsoThemeColorIndex.msoThemeColorAccent6;
                            break;
                    }


                    //Excel.Points sPoints = xy1.Points();

                    ////xy1.HasDataLabels = true;

                    ////For every row in the values table, plot the date against the variable value
                    //for (int p = 0; p < element_Fc.value.fc.Count(); p++)
                    //{
                    //    Excel.Point lPoint = sPoints.Item(p + 1);
                    //    //lPoint.Name = "P" + p.ToString();

                    //    //myChart.Series[Variable].Points.AddXY(Convert.ToDateTime(row["Date"].ToString()), row["Variable"].ToString());
                    //    lPoint.HasDataLabel = true;
                    //    lPoint.DataLabel.Text = "P" + p.ToString(); // " = #VALY \r\nDate = #VALX{d} \r\np = "+ p.ToString();
                    //    lPoint.DataLabel.Font.Size = 2;
                    //    //Excel.Point lPoint = sPoints.Item(p);
                    //    //points += 1;
                    //}

                }
                var yAxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
                //yAxis.AxisTitle.Text = "Regulon";
                Excel.TickLabels labels = yAxis.TickLabels;
                labels.Offset = 1;
            }


            chartPage.ChartColor = 1; // Properties.Settings.Default.defaultPalette;

            // as a last step, add the axis labels series

            if (true)
            {

                var xy2 = series.NewSeries();

                xy2.ChartType = Excel.XlChartType.xlXYScatter;
                //# Excel.Range rng = (Excel.Range)_tmpSheet.Range[_tmpSheet.Cells[3, (i*2)+1], _tmpSheet.Cells[6, (i * 2) + 1]];
                xy2.XValues = Enumerable.Repeat(MMIN, nrCategories).ToArray();

                //rng = (Excel.Range)_tmpSheet.Range[_tmpSheet.Cells[3, (i * 2) + 2], _tmpSheet.Cells[6, (i * 2) + 2]];
                float[] yv = new float[nrCategories];
                for (int _i = 0; _i < nrCategories; _i++)
                {
                    yv[_i] = ((float)_i) + 0.5f;
                }

                xy2.Values = yv;

                xy2.MarkerStyle = Excel.XlMarkerStyle.xlMarkerStyleNone;
                xy2.HasDataLabels = true;

                for (int _i = 0; _i < nrCategories; _i++)
                {
                    xy2.DataLabels(_i + 1).Text = element_Fcs[_i].catName;
                }

                xy2.DataLabels().Position = Excel.XlDataLabelPosition.xlLabelPositionLeft;
                xy2.DataLabels().Font().Size = fontsize(element_Fcs.Count);

            }


            chartPage.Axes(Excel.XlAxisType.xlValue).TickLabelPosition = Excel.XlTickLabelPosition.xlTickLabelPositionNone;
            chartPage.Axes(Excel.XlAxisType.xlValue).MajorGridLines.Delete();

            chartPage.Axes(Excel.XlAxisType.xlValue).Format.Line.Weight = 0.25;
            chartPage.Axes(Excel.XlAxisType.xlValue).Format.Line.DashStyle = Excel.XlLineStyle.xlDashDot;
            chartPage.Axes(Excel.XlAxisType.xlValue).MaximumScale = nrCategories;
            chartPage.Axes(Excel.XlAxisType.xlValue).MinimumScale = 0;
            chartPage.Legend.Delete();

            chartPage.Location(Excel.XlChartLocation.xlLocationAsNewSheet, chartName);

            aSheet.Delete();

            return chartPage;

        }
        


        public static (float, float) CalculateStepSize(float range, float targetSteps)
        {
            // calculate an initial guess at step size
            float tempStep = range / targetSteps;

            // get the magnitude of the step size
            float mag = (float)Math.Floor(Math.Log10(tempStep));
            float magPow = (float)Math.Pow(10, mag);

            // calculate most significant digit of the new step size
            float magMsd = (int)(tempStep / magPow + 0.5);

            // promote the MSD to either 1, 2, or 5
            if (magMsd > 5.0)
                magMsd = 10.0f;
            else if (magMsd > 2.0)
                magMsd = 5.0f;
            else if (magMsd > 1.0)
                magMsd = 2.0f;

            return (magMsd * magPow, magMsd);
        }
    }


}