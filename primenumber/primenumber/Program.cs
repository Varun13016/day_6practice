using System;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the number is a prime number");
            }
            else
            {
                Console.WriteLine("the number is a not prime number");
            }
        }
    }
}