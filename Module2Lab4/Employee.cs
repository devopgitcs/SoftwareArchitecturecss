using System;

namespace Module2Lab4
{
    public class Employee
    {
        private readonly String REQUIRED_MSG = " is mandatory. ";
        private readonly String NEWLINE = "\n";

        private String _FirstName;

        public String FirstName
        {
            get { return _FirstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FirstName" + REQUIRED_MSG);
                    // Console.WriteLine("FirstName" + REQUIRED_MSG);
                }

                _FirstName = value;
            }
        }

        private String _LastName;

        public String LastName
        {
            get { return _LastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("LastName" + REQUIRED_MSG);
                    // Console.WriteLine("LastName" + REQUIRED_MSG);
                }

                _LastName = value;
            }
        }

        private String _Ssn;

        public String Ssn
        {
            get { return _Ssn; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 9 || value.Length > 11)
                {
                    throw new ArgumentException("Ssn" + REQUIRED_MSG +
                                                "and must be between 9 and 11 characters (if hyphens are used)");
                    // Console.WriteLine("Ssn" + REQUIRED_MSG);
                }

                _Ssn = value;
            }
        }

        private Boolean _MetWithHr;

        public Boolean MetWithHr
        {
            get { return _MetWithHr; }
            set
            {
                _MetWithHr = value;
                ReportService.AddData(FirstName + " " + LastName + " met with dept staff on " + GetFormattedDate() +
                                      NEWLINE);
            }
        }

        private Boolean _MetDeptStaff;

        public Boolean MetDeptStaff
        {
            get { return _MetDeptStaff; }
            set
            {
                _MetDeptStaff = value;
                ReportService.AddData(FirstName + " " + LastName + " met with dept staff on " + GetFormattedDate() +
                                      NEWLINE);
            }
        }

        private Boolean _ReviewedDeptPolicies;

        public Boolean ReviewedDeptPolicies
        {
            get { return _ReviewedDeptPolicies; }
            set
            {
                _ReviewedDeptPolicies = value;
                ReportService.AddData(FirstName + " " + LastName + " reviewed dept policies on " + GetFormattedDate() +
                                      NEWLINE);
            }
        }

        // Did not convert given method in original code also contained changing CubeId variable
        public Boolean MovedIn { get; private set; }
        private String CubeId { get; set; }
        private DateTime OrientationDate { get; set; }
        private EmployeeReportService ReportService;

        // constructor with required fields
        public Employee(String firstName, String lastName, String ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            ReportService = new EmployeeReportService();
        }

        private String GetFormattedDate()
        {
            return OrientationDate.ToString("M/d/yy");
        }

        public void DoFirstTimeOrientation(String cubeId)
        {
            OrientationDate = DateTime.Now;
            MetWithHr = true;
            MetDeptStaff = true;
            ReviewedDeptPolicies = true;
            MoveIntoCubicle(cubeId);
        }

        private void MoveIntoCubicle(String cubeId)
        {
            SetCubeId(cubeId);
            MovedIn = true;
            ReportService.AddData(FirstName + " " + LastName + " moved into cubicle " + cubeId + " on " +
                                  GetFormattedDate() + NEWLINE);
        }

        private void SetCubeId(String cubeId)
        {
            if (String.IsNullOrEmpty(cubeId))
            {
                throw new ArgumentException("cube id" + REQUIRED_MSG);
            }
        }

        public void PrintReport()
        {
            ReportService.OutPutReport();
        }

        public override String ToString()
        {
            return "Employee{" + "FirstName=" + FirstName + ", LastName=" + LastName + ", Ssn=" + Ssn + "}";
        }
    }
}

// PARKING LOT
// private void MeetWithHrForBenefitAndSalaryInfo()
// {
//     MetWithHr = true;
//     ReportService.AddData(FirstName + " " + LastName + " met with HR on " + GetFormattedDate() + NEWLINE);
// }

// private void MeetDepartmentStaff()
// {
//     MetDeptStaff = true;
//     ReportService.AddData(FirstName + " " + LastName + " met with dept staff on " + GetFormattedDate() + NEWLINE);
// }

// private void ReviewDeptPolicies()
// {
//     ReviewedDeptPolicies = true;
//     ReportService.AddData(FirstName + " " + LastName + " reviewed dept policies on " + GetFormattedDate() + NEWLINE);
// }