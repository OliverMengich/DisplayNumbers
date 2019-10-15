using System;

namespace Exercise_gitSoln
{
    class Program
    {
        double lenght = 30.5d;
        double width = 15.6d;
        static void Main(string[] args)
        {
           Program p1 = new Program();
           p1.Display();
        }
        public void Display()
        {
            Program p = new Program();
            System.Console.WriteLine($"the length is {p.lenght}");
            System.Console.WriteLine($"the width is {p.width}");
        }
    }
}
