using System;
using System.Windows.Forms;

namespace Module2Lab4
{
    public class EmployeeReportService
    {
        private String Report = "";

        public void AddData(String data)
        {
            Report += data;
        }

        public void OutPutReport()
        {
            Console.WriteLine(Report,"Employee Report Service");
        }

        public void ClearReport()
        {
            Report = "";
        }
    }
}
