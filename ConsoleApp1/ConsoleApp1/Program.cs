// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

            Console.WriteLine();

            // Check if a number is a palindrome

            
            Console.Write("Enter a Number to check for Palindrome: ");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                remainder = number % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + remainder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            

            // Check if a string is a palindrome

            Console.Write("Enter a string to check Palindrome : ");
            string palindromeName = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = palindromeName.Length - 1; i >= 0; i--)
            {
                reverse += palindromeName[i];
            }

            if (palindromeName == reverse)
            {
                Console.WriteLine($"{palindromeName} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{palindromeName} is not a Palindrome.");
            }
            

            // end palindrome string check


            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

