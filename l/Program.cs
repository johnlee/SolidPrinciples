using System;

namespace l
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Subsitution Principle");
        }
    }

    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public virtual int CalculateRate()
        {
            int baserate = 12;
            return baserate * this.Grade;
        }
    }

    public class Contractor : BaseEmployee
    {
        public override int CalculateRate()
        {
            int baserate = 14;
            return baserate * this.Grade;
        }
    }

    public class Manager : BaseEmployee
    {
        public override int CalculateRate()
        {
            return base.CalculateRate();
        }
    }
}
