using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            int userNumber;
            Console.WriteLine("Enter your number: ");
             userNumber = int.Parse(Console.ReadLine());
            if(userNumber < 0)
            {
                Console.WriteLine("The number is negative.");
            } 
            else if(userNumber > 0)
            {
                Console.WriteLine("The number is positive.");
            }
           
       
            
}

    

