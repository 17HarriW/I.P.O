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
            double volume = CalcVolume(radius);
            Output(volume);

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
        static double CalcVolume(int radius)
        {
            // Process - Calculate volume of a sphere
            double volume = Math.PI * (4 / 3) * (radius * radius * radius);
            return volume;
        }
        static void Output(double volume)
        {
            // Output - Display volume
            Console.WriteLine($"The volume is {volume}");
        }
    }
}
