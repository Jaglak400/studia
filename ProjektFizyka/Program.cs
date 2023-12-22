using Excel = Microsoft.Office.Interop.Excel;

double x, y, s, zmienna;
x = 0; y = 0; //ustawienie hipotetycznej cząsteczki w punkcie {0, 0}
var rng = new Random(); //losowanie zmiennej

Console.WriteLine("Podaj ilość ruchów");
var ilosc_ruchow = int.Parse(Console.ReadLine());
string katalog = Directory.GetCurrentDirectory();


// Tworzenie nowego obiektu aplikacji Excel
var excelApp = new Excel.Application();
excelApp.Visible = true;
var workbook = excelApp.Workbooks.Add();
var worksheet = workbook.ActiveSheet;

worksheet.Cells[1, 1].Value = "X";
worksheet.Cells[1, 2].Value = "Y";

for (int i = 2; i <= ilosc_ruchow + 1; i++)
{
    zmienna = Math.PI * rng.Next() / Int32.MaxValue * 2;
    x = x + Math.Cos(zmienna);
    y = y + Math.Sin(zmienna);
    Console.WriteLine($"X[{x}] Y[{y}]");
    worksheet.Cells[i, 1].Value = x;
    worksheet.Cells[i, 2].Value = y;
}

// Dodawanie wykresu
var chartRange = worksheet.Range["A1:B" + ilosc_ruchow + 1];
var chart = (Excel.ChartObjects)worksheet.ChartObjects();
var chartObject = chart.Add(100, 50, 300, 300);
var xyChart = chartObject.Chart;
xyChart.ChartType = Excel.XlChartType.xlXYScatter;
xyChart.SetSourceData(chartRange);

// Zmiana nazw osi
xyChart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
xyChart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Text = "X";
xyChart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
xyChart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Text = "Y";

s = Math.Sqrt(x * x * y * y);
Console.WriteLine("Cząsteczka przemieściła się o {0}", s);