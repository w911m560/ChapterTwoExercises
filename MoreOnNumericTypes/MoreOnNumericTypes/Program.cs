using System;

namespace MoreOnNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles driven?");
            string m = Console.ReadLine();
            int miles = int.Parse(m);

            Console.WriteLine("Gas consumed?");
            string g = Console.ReadLine();
            int gas = int.Parse(g);

            int mpg = miles / gas;
            Console.WriteLine("MPG: " + mpg);
        }
    }
}
