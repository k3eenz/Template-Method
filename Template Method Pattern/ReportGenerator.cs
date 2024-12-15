using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            DataCollection();
            DataProcessing();
            ReportFormatting();
            ReportExportting();
        }
        protected abstract void DataCollection();
        protected abstract void DataProcessing();
        protected abstract void ReportFormatting();
        protected abstract void ReportExportting();
    }
}
