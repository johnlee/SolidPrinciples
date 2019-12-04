using System;
namespace solid
{
    public class Example1
    {
        public Example1()
        {
        }
    }

    class Fruit
    {
        public string color { get; set; }
    }

    class Apple : Fruit
    {
        public Seed Seeds;

        public Apple()
        {
            this.color = "Red";
            this.Seeds = new Seed(10);
        }
    }

    class Seed
    {
        public int count { get; set; }

        public Seed(int count)
        {
            this.count = count;
        }
    }
}
