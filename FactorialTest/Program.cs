using System;

namespace FactorialTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, num;
            Console.WriteLine("-- FACTORIAL --");
            Console.WriteLine("Please enter the number:");
            x = Convert.ToInt32(Console.ReadLine()); //string to int

            num = x;

            if(x > 0)
            {
                if(x <=30)
                {
                    for (int i = 1 ; i < x ; i++)
                    {
                        num = num * i;
                    }
                    Console.WriteLine("Factorial of {0}! = {1}\n", x, num);
                }
                else
                {
                    Console.WriteLine("The resulting number is very large.\n{0} is the entered value. ", x);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }
    }
}
