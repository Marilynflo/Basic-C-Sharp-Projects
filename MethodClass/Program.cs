
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 10;

            

            MathOp FirstOp = new MathOp(); //instantiating the class
            FirstOp.MathMethodFirst (int num1, int num2);

            

            Console.WriteLine(num2); //writing in the console the second parameter
            Console.WriteLine("Passing 9 as an integer");

           


            Console.ReadLine();
        }
    }
}