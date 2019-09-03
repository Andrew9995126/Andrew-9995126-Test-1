using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");         //intro
            Console.WriteLine("-----------This program will give the sum total of 5 prices--------------");
            Console.WriteLine("-------------------------------------------------------------------------");

            

            
                {

                Console.Write("Enter the price of item 1: $");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the price of item 2: $");
                double num2 = double.Parse(Console.ReadLine());                                 //block of code for obtaining prices

                Console.Write("Enter the price of item 3: $");
                double num3 = double.Parse(Console.ReadLine());

                Console.Write("Enter the price of item 4: $");
                double num4 = double.Parse(Console.ReadLine());

                Console.Write("Enter the price of item 5: $");
                double num5 = double.Parse(Console.ReadLine());

                Console.WriteLine($"The total of those items is: {num1 + num2 + num3 + num4 + num5}");          //sum total of prices, forgot how to make it stay at 2 decimal points.
                Console.ReadLine();
            }
            
            
        }
    }
}
