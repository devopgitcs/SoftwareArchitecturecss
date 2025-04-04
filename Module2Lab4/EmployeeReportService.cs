using System;

namespace Module2Lab4
{
    public class EmployeeReportService
    {
        private string Report = "";

        public void AddData(string data)
        {
            Report += data;
        }

        public void OutPutReport()
        {
            // Write the report to console rather than trying to display a modal dialog.
            Console.WriteLine("Employee Report Service: " + Report);
        }

        public void ClearReport()
        {
            Report = "";
        }
    }
}
