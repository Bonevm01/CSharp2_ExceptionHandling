//2.Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//  If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

namespace ReadNum
{
    class ReadNum
    {
        static int start = 1;
        static void Main()
        {
            Console.WriteLine("The following code will allow you to enter 10 numbers. 1 < a1 < … < a10 < 100.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Attempt {0}", i + 1);
                try
                {
                    ReadNumber(start, 100);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The entered number is out of the range {0}...100.", start);
                }
            }

        }
        static void ReadNumber(int a, int b)
        {
            Console.Write("Please enter a number between {0} and {1}: ", a, b);
            string str = Console.ReadLine();
            try
            {
                int input = int.Parse(str);
                if (input <= a || input >= b)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Console.WriteLine("Your choice is valid -->{0}", input);
                    start = input;
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("You have just entered an invalid input.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The entered number is out of the range. (overflow int)");
            }


        }
    }
}
