using System;

namespace Mainmethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Operator FirstOp = new Operator(); //instantiating the class
            Console.WriteLine("Pick a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

          

            Operator Second = new Operator(); //instantiating the class

            Console.WriteLine("You do not need to enter another number: ");
            var num2isValid = int.TryParse(Console.ReadLine(), out int num2);

            int result = 0;

            if (num2isValid) //using if statement to validate user input
            {
                result = (num1 * num2);
            }
            else
            {
                result = (num1); 

            }

            Console.WriteLine( "The product is: " + result); // writing in the console the sum of the 2 parameters
            Console.WriteLine("Passing result as an integer");
            Console.WriteLine(result);
            Console.ReadLine();
        
            
                

        }

      
    }
}
