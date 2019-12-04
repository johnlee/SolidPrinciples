using System;

namespace i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle");
        }
    }

    interface IPerson
    {
        string Name { get; set; }
        string SSN { get; set; }
    }

    interface IEmployee : IPerson
    {
        int EmployeeId { get; set; }
        string OfficeAddress { get; set; }
    }

    class Manager : IEmployee
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        public int EmployeeId { get; set; }
        public string OfficeAddress { get; set; }
    }
}
