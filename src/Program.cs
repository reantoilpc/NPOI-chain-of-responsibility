using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using NPOI.Util;
using NPOI.XSSF.UserModel;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World!");

            var employees = new List<Employee>
            {
                new Employee{ Id = "A01001", Title = "處長", Name = "王大明", OnBoard = "2006-07-01", Salary = 120000},
                new Employee{ Id = "A01102", Title = "協理", Name = "陳大明", OnBoard = "2012-11-01", Salary = 96000},
                new Employee{ Id = "A01203", Title = "主任", Name = "李大明", OnBoard = "2015-05-01", Salary = 78000},
                new Employee{ Id = "A01311", Title = "資深工程師", Name = "林大明", OnBoard = "2016-03-01", Salary = 64000},
                new Employee{ Id = "A01392", Title = "工程師", Name = "張大明", OnBoard = "2018-12-01", Salary = 42000}
            };

            var filePath = $"sample.xlsx";
            WriteToExcel(filePath, employees);

        }

        public static void WriteToExcel(string filePath, IEnumerable<Employee> employees)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                var workbook = new XSSFWorkbook();
                var sheet = workbook.CreateSheet("薪資報表");

                var count = 1;
                foreach (var employee in employees)
                {
                    
                    var row = sheet.CreateRow(count);

                    // row.CreateCell((int)ReportFields.員工編號).SetCellValue(employee.Id);
                    // row.CreateCell((int)ReportFields.員工職稱).SetCellValue(employee.Title);
                    // row.CreateCell((int)ReportFields.員工姓名).SetCellValue(employee.Name);
                    // row.CreateCell((int)ReportFields.到職日期).SetCellValue(employee.OnBoard);
                    // row.CreateCell((int)ReportFields.員工薪資).SetCellValue(employee.Salary);

                    row.CreateCellValue(ReportFields.員工編號, employee.Id)
                        .CreateCellValue(ReportFields.員工職稱, employee.Title)
                        .CreateCellValue(ReportFields.員工姓名, employee.Name)
                        .CreateCellValue(ReportFields.到職日期, employee.OnBoard)
                        .CreateCellValue(ReportFields.員工薪資, employee.Salary);

                    count++;
                }   
                
                workbook.Write(fileStream);
                fileStream.Close();
            }
        }
    }
}
