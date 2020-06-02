using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length?");
            string l = Console.ReadLine();
            int length = int.Parse(l);

            Console.WriteLine("Width?");
            string w = Console.ReadLine();
            int width = int.Parse(w);

            int area = length * width;
            Console.WriteLine("Area: " + area);
        }
    }
}
