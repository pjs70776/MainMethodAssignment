using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method 1
            Console.WriteLine("What number do you want to select to do the math operation?");
            Console.WriteLine("Enter a number to be added to 5");
            int additon = Convert.ToInt32(Console.ReadLine());
            int sum = Class1.method1(additon);
            Console.WriteLine(sum + " is the answer.");

            //method 2 with decimal (float)
            Console.WriteLine("enter a decimal up to 6 decimal digits to be subtracted by 5");
            int subtract = Convert.ToInt32(Console.ReadLine());
            int diff = Class1.method2(subtract);
            Console.WriteLine(diff + " is the answer.");

            //method 3 that takes a string, converts it to an integer
            Console.WriteLine("Enter a string, that will be converted to an integer, to be multiplied by 5");
            int mult = Convert.ToInt32(stringToInt);  //converting string to intiger
            int prod = Class1.method3(mult);
            Console.WriteLine(prod + " is the answer.");
            Console.ReadLine();
        }
    }
}
