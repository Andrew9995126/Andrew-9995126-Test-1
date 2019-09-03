using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("-------------Can you solve the following algebraic expression: -----------------");          //intro 
            Console.WriteLine("----------------------------- 2(x - 3) * x = 12 --------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.Write("Enter your guess at the value of x: ");
            int guess = int.Parse(Console.ReadLine());                          //users guess

            int x = 17;                                                         //Answer of x

            if (guess == x)
            {
                Console.WriteLine("Congratulations you are correct!");             //if answer is correct
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that guess is incorrect.");                //if answer is wrong
                Console.ReadLine();
            }
        }
    }               // 2(x - 3) + x = 12
                    //= 2 * x - 3 + x 
                    //= -6x + x 
                    //= -5x = 12
                    //x = 17
}
