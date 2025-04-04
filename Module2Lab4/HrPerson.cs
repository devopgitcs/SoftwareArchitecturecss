using System;
using System.Collections;
using System.Collections.Generic;

namespace Module2Lab4
{
    public class HrPerson
    {
        private List<Employee> Employees;

        public HrPerson()
        {
            Employees = new List<Employee>();
        }

        public void HireEmployee(String FirstName, String LastName, String Ssn)
        {
            Employee e = new Employee(FirstName, LastName, Ssn);
            Employees.Add(e);
            OrientEmployee(e);
        }

        private void OrientEmployee(Employee emp)
        {
            emp.DoFirstTimeOrientation("B101");
        }

        public void OutputReport(String Ssn)
        {
            // find employee in list
            foreach (var emp in Employees)
            {
                if (emp.Ssn == Ssn)
                {
                    // if found run report
                    if (emp.MetWithHr && emp.MetDeptStaff
                                      && emp.ReviewedDeptPolicies && emp.MovedIn)
                    {
                        emp.PrintReport();
                    }
                }
            }
        }
    }
}