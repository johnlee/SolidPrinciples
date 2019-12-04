using System;

namespace o
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open Closed Principle");
        }
    }

    // Example1 - Worker class is unable to adjust to future changes
    public class Worker
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        int EmployeeId { get; set; } // only for employee
        string OfficeLocation { get; set; } // only for employees
        int ContractorId { get; set; } // only for contractors
        string Company { get; set; } // only for contractors

        string MaidenName { get; set; } // Was added later
    }

    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MaidenName { get; set; }
        string EmailAddress { get; set; }

        public void ChangeLastName(string newlastname);
    }

    public class Employee : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string EmailAddress { get; set; }
        public int EmployeeId { get; set; }
        public string OfficeLocation { get; set; }

        public void ChangeLastName(string newlastname)
        {
            this.MaidenName = this.LastName;
            this.LastName = newlastname;
        }
    }

    public class Contractor : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string EmailAddress { get; set; }
        public int ContractorId { get; set; }
        public string Company { get; set; }

        public void ChangeLastName(string newlastname)
        {
            this.MaidenName = this.LastName;
            this.LastName = newlastname;
        }
    }
}
