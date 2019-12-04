using System;

namespace solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    sealed class Dog
    {
        public void Size()
        {
            throw new NotImplementedException();
        }
    }

    //class Minpin : Dog { } // Error - Cannot be derived from sealed class

    abstract class Animal
    {
        public abstract void Size();
    }

    class Fish : Animal
    {
        public sealed override void Size()
        {
            throw new NotImplementedException();
        }

        void Swims()
        {
            throw new NotImplementedException();
        }
    }
}
