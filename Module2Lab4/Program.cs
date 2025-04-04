using System.Windows.Forms;

namespace Module2Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            
            company.HireEmployee("John", "Doe", "444-44-4444");
        }
    }
}