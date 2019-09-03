using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");         //intro 
            Console.WriteLine("-----------This program can give the result of base^exponent-------------");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Enter the value of the base: ");                 //base number

            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of the exponent: ");             //exponent number
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1}^{num2} = {num1 * num2}");                //equation is wrong but I've forgotten how to code this certain equation.
            Console.ReadLine();
        }
    }
}
