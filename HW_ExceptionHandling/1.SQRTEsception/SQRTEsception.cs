//1.Write a program that reads an integer number and calculates and prints its square root.
//  If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
using System;


namespace SQRTEsception
{
    class SQRTEsception
    {
        static void Main()
        {
            Console.WriteLine("The following program is going to calculate a square root of a random integer.");
            Console.Write("Please enter an integer: ");
            try
            {
                Console.WriteLine("The square root of your integer is {0}.", SQRT(int.Parse(Console.ReadLine())));
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number."); ;
            }
            finally
            {
                Console.WriteLine("Good buy.");
            }
        }

        static double SQRT(int a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double result = Math.Sqrt(a);
            return result;

        }
    }
}
