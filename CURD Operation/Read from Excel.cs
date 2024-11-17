using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace CURD_Operation
{
    public class Read_from_Excel
    {
        public void Process_Excel_data()
        {
            string inputFilePath = @"C:\Users\Gokul\Desktop\SAmpleExceldata.xlsx";  // Input file
            string outputFilePath = @"C:\Users\Gokul\Desktop\SampleWritFile.xlsx"; // Output file

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // For non-commercial use

            // Reading Data
            Console.WriteLine("Reading Data from Excel:");
            using (var package = new ExcelPackage(new FileInfo(inputFilePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.Write($"{worksheet.Cells[row, col].Text}\t");
                    }
                    Console.WriteLine();
                }
            }

            // Writing Data
            Console.WriteLine("Writing Data to Excel:");
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Writing data to cells
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "DOB";
                worksheet.Cells[1, 4].Value = "Gender";
                worksheet.Cells[1, 5].Value = "Contact";

                worksheet.Cells[2, 1].Value = 1;
                worksheet.Cells[2, 2].Value = "jhon";
                worksheet.Cells[2, 3].Value = "1022456";
                worksheet.Cells[2, 4].Value = "m";
                worksheet.Cells[2, 5].Value = "78899455";

                worksheet.Cells[3, 1].Value = 2;
                worksheet.Cells[3, 2].Value = "main";
                worksheet.Cells[3, 3].Value = "102545";
                worksheet.Cells[3, 4].Value = "m";
                worksheet.Cells[3, 5].Value = "5588911";

                // Save to a new file
                package.SaveAs(new FileInfo(outputFilePath));
            }

            Console.WriteLine($"Data written successfully to {outputFilePath}");
        }
    }


    public class threading
    {

        public void thread()
        {
            Stopwatch stopwatch = new Stopwatch();

            Thread thread = new Thread(() =>
            {
                stopwatch.Start(); // Start timing
                Thread.Sleep(2000); // Simulate work
                stopwatch.Stop();  // Stop timing
            });

            thread.Start();
            thread.Join(); // Wait for thread to finish

            Console.WriteLine($"Thread execution time: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void appendthread()
        {
            Thread worker = new Thread(() =>
            {
                Console.WriteLine("Task 1: Hello");
                Thread.Sleep(500); // Simulate work
                Console.WriteLine("Task 2: World");
            });

            worker.Start();
            worker.Join(); // Wait for thread to complete
            Console.WriteLine("All tasks done.");
        }
    }
}
