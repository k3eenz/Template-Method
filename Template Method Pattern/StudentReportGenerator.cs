using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void DataCollection()
        {
            Console.WriteLine("Информация о студентах собрана");
        }
        protected override void DataProcessing()
        {
            Console.WriteLine("Информация о студентах обработана");
        }
        protected override void ReportFormatting()
        {
            Console.WriteLine("Информация о студентах отформатирована");
        }
        protected override void ReportExportting()
        {
            Console.WriteLine("Экспорт информации о студентах");
        }
    }
}
