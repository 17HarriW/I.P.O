using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.P.O
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = Input();

            // Process - Calculate volume of a sphere
            double volume = Math.PI * (4/3) * (radius ^ 3);

            // Output - Display volume
            Console.WriteLine($"The volume is {volume}");

            Console.ReadLine();

        }
        static int Input()
        {
            // Input - Retrieve radius from user
            Console.Write("Enter an integer radius for the sphere: ");
            string strRadius = Console.ReadLine();
            int radius = int.Parse(strRadius);
            return radius;
        }
    }
}
