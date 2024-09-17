
using OfficeOpenXml;

namespace ColectorMakita1
{
    public class ProductoSeries
    {
        public string CodigoProducto { get; set; }
        public List<string> Series { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var result = new List<ProductoSeries>();

            string path = @"C:\datos\dato\archivoIngreso5.txt";

            using (var fileStream = File.OpenRead(path))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string codproducto = line.Substring(0, 20).Trim();
                        string serieinicial = line.Substring(20, 9);
                        string seriefinal = line.Substring(29, 9);

                        string letraserie = line.Substring(38, 1);
                        long numserieinicial = long.Parse(serieinicial);
                        long numseriefinal = long.Parse(seriefinal);
                        List<long> series = new List<long>();

                        for (int i = 0; i <= numseriefinal - numserieinicial; i++)
                        {
                            series.Add(numserieinicial + i);
                        }

                        var dataLinea = new ProductoSeries();
                        dataLinea.CodigoProducto = codproducto;
                        dataLinea.Series = new List<string>();

                        foreach (long nroserie in series)
                        {
                            string serieformateada = nroserie.ToString().PadLeft(9, '0') + letraserie;
                            dataLinea.Series.Add(serieformateada);
                        }

                        result.Add(dataLinea);
                    }
                }
            }

            // Exportar a Excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\datos\datos\archivoSalida.xlsx";
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets.Add("Series");
                worksheet.Cells["A1"].Value = "Código Producto";
                worksheet.Cells["B1"].Value = "Serie";

                int row = 2;
                foreach (var productoSeries in result)
                {
                    foreach (var serie in productoSeries.Series)
                    {
                        worksheet.Cells[$"A{row}"].Value = productoSeries.CodigoProducto;
                        worksheet.Cells[$"B{row}"].Value = serie;
                        row++;
                    }
                }

                package.Save();
            }

            Console.WriteLine("Archivo exportado con éxito");
        }
    }
}