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
            Console.WriteLine("Pick another number:");
            var num2isValid = int.TryParse(Console.ReadLine(), out int num2);

            int result = 0;
            if (num2isValid)
            {
                result = (num1 + num2);
            }
            else
            {
                result = (num1);

            }

            Console.WriteLine(result);
            Console.ReadLine();
      


               
            
                

        }
    }
}
