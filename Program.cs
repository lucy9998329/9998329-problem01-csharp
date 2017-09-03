using System;

namespace Comp5202_problem1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Start the program with Clear();
           Console.Clear();
           
           
            Console.WriteLine("================================================================= ");
            Console.WriteLine("This program will check two numbers and see which one is greater. ");
            Console.WriteLine("==================================================================");
            

            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Please type in number 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type in number 2");
            num2 = int.Parse(Console.ReadLine());

            if(num2 > num1)
            {
                Console.WriteLine("Number 2 is greater than number 1");
            } 
            else{

                if(num2 == num1)
                {
                  Console.WriteLine("Number 2 is equal number 1");   
                }
            else{
                if(num2 < num1)
                {
                  Console.WriteLine("Number 2 is smaller than number 1");   
                }
            }

            }           
    



           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();
           
            
        }
    }
}
