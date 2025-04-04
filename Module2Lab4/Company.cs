using System;

namespace Module2Lab4
{
    public class Company
    {
        private HrPerson hr;

        public Company()
        {
            hr = new HrPerson();
        }

        public void HireEmployee(String FirstName, String LastName, String Ssn)
        {
            hr.HireEmployee(FirstName, LastName, Ssn);
            hr.OutputReport(Ssn);
        }
    }
}