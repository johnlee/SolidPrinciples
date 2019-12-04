using System;

namespace s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of SRP - Single Responsibiliy Principle");
            Example1();
            Example2();
            
            // Output
            // Jane Smith (Doe), Jane.Smith@email.com, 1
            // Jane Smith (Doe), Jane.Smith@email.com, 1
        }

        // Example 1, no classes, everything in single place
        static void Example1()
        {
            // Declarations
            var firstname = string.Empty;
            var lastname = string.Empty;
            var maidenname = string.Empty;
            var email = string.Empty;
            var eid = 0;

            // Inputs
            firstname = "Jane";
            lastname = "Doe";
            email = "Jane.Doe@email.com";

            // Actions
            eid = 1;
            email = "Jane.Smith@email.com";
            maidenname = "Doe";
            lastname = "Smith";
            Console.WriteLine($"{firstname} {lastname} ({maidenname}), {email}, {eid}");
        }

        // Example 2, break everything out into its own classes
        static void Example2()
        {
            Employee e = new Employee("Jane", "Doe", 1);
            e.ChangeLastName("Smith");
            Console.WriteLine($"{e.FirstName} {e.LastName} ({e.MaidenName}), {e.Email}, {e.Eid}");
        }
    }

    public interface Person
    {
        string FirstName {get; set;}
        string LastName {get;set;}
    }

    public class Employee : Person
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string MaidenName {get;set;}
        public int Eid {get;set;}
        public string Email
        {
            get { return this.EmailObj.Address; }
        }
        private Email EmailObj;

        public Employee(string fname, string lname, int eid) 
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Eid = eid;
            this.EmailObj = new Email(GetEmail());
        }

        public void ChangeLastName(string newlastname)
        {
            this.MaidenName = this.LastName;
            this.LastName = newlastname;
            this.EmailObj = new Email(GetEmail());
        }

        private string GetEmail()
        {
            return $"{this.FirstName}.{this.LastName}@email.com";
        }
    }

    public class Email
    {
        public string Address {get;set;}

        public Email(string email) 
        {
            if (ValidateEmail(email)) this.Address = email;
        }

        public void ChangeEmail(string newEmail)
        {
            if (ValidateEmail(newEmail)) this.Address = newEmail;
        }

        private bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
