using System;

namespace PrimeNumberCheckerApp
{
    public class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; //Numbers less than or equal to 1 are not prime
            }

            //Check divisibility up to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; //Not a prime number
                }
            }

            return true; //It's a prime number
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(inputNumber))
            {
                Console.WriteLine($"{inputNumber} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is not a prime number.");
            }

            Console.ReadLine();
        }
    }
}
